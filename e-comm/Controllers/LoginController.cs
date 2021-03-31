using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_comm.DB.Domain;
using e_comm.DB.EF;
using e_comm.Helpers;
using e_comm.ViewModels.Login;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace e_comm.Controllers
{
    public class LoginController : Controller
    {

        private DBcon con;
        private IConfiguration _configuration;

        public LoginController(DBcon _con, IConfiguration configuration)
        {
            con = _con;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn(LoginIndexVM model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            User useracc = null;
            bool check = false;

            foreach (var user in con.Users)
            {
                byte[] temp = Convert.FromBase64String(user.PasswordSalt);
                if (user.Email == model.Email && user.PasswordHash == HashHelper.GetHash(model.Password, temp))
                {
                    useracc = user;
                    check = true;
                }
                if (check)
                {
                    break;
                }
            }

            if (useracc == null)
            {
                TempData["errorMessage"] = "Incorrect credentials, try again!";
                return View(model);
            }
            else
            {
                HttpContext.setLoggedUser(useracc, true);
                return RedirectToAction("Index", "Registration");
            }          
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult SendConfirmation(ForgotPasswordVM model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("SendConfirmation", model);

            User user = con.Users.SingleOrDefault(i => i.Email == model.Email);

            if (user == null)
            {
                TempData["errorMessage"] = "Email address doesn't exist.";
                return RedirectToAction("SendConfirmation", model);
            }

            ChangePasswordCode changepw = con.ChangePasswords.SingleOrDefault
               (i => i.UserId == user.Id);

            if (changepw != null)
            {
                if ((DateTime.Now - changepw.Created).TotalHours < 24)
                {
                    TempData["errorMessage"] = "Email has been already sent to this email address";
                    return RedirectToAction("SendConfirmation", model);
                }
                else
                {
                    con.ChangePasswords.Remove(changepw);
                    con.SaveChanges();
                }
            }
            string messageReceiver = user.FirstName + " " + user.LastName;


            string value = RandomString.GetString(30);
            string link =
                $"{ this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/Login/ChangePassword?value=" + value;

            string message = "Visit this link for password change: \n" + link +
                "\nIf you don't change your password in next 24 hours this link will disappear " +
                "will be invalid.";

            EmailSettings.SendEmail(_configuration, messageReceiver, user.Email, "Change password", message);

            ChangePasswordCode passwordRequest = new ChangePasswordCode
            {
                Value = value,
                UserId = user.Id,
                Created = DateTime.Now
            };

            con.ChangePasswords.Add(passwordRequest);
            con.SaveChanges();

            TempData["successMessage"] = "Email for password confirmation is successfully sent. Check your inbox.";
            return RedirectToAction("Index");
            
        }
        public IActionResult ChangePassword(string value)
        {
            if (con.ChangePasswords.SingleOrDefault(i => i.Value == value) == null)
                return RedirectToAction("Index");

            TempData["value"] = value;
            return View("ChangePassword");
        }

        public IActionResult ConfirmNewPassword(ChangePasswordVM model)
        {
            if (!ModelState.IsValid)
            {
                return View("ChangePassword", model);
            }

            string value = (string)TempData["value"];

            ChangePasswordCode changepw = con.ChangePasswords.SingleOrDefault(i => i.Value == value);

            User user = con.Users.SingleOrDefault
                (i => i.Id == changepw.UserId);

            user.PasswordHash = HashHelper.GetHash(model.Password, Convert.FromBase64String(user.PasswordSalt));

            con.ChangePasswords.Remove(changepw);
            con.SaveChanges();

            TempData["successMessage"] = "Your password is successfully changed.";
            return RedirectToAction("Index");
        }






    }
}
