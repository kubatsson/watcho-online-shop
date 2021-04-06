using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_comm.DB.Domain;
using e_comm.DB.EF;
using e_comm.Helpers;
using e_comm.ViewModels.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace e_comm.Controllers
{
    public class RegistrationController : Controller
    {
        private DBcon con;
        private IConfiguration _configuration;

        public RegistrationController(DBcon _con, IConfiguration configuration)
        {
            con = _con;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            if (HttpContext.GetLoggedUser() != null)
            {
                return RedirectToAction("Index", "HomePage");
            }
            return View();
        }

        public IActionResult SignUp(RegistrationIndexVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if(con.Users.Any(u=> u.Email == model.Email))
            {
                TempData["errorMessage"] = "Email address is already in use";
                return RedirectToAction("Index");
            }

            byte[] pwSalt = HashHelper.GetSalt();
            string pwHash = HashHelper.GetHash(model.Password, pwSalt);

            User user = new User
            {
                Email=model.Email,
                Username=model.Username,
                PasswordHash=pwHash,
                PasswordSalt=Convert.ToBase64String(pwSalt),
                GenderId=1
                
            };

            con.Users.Add(user);
            con.SaveChanges();
            TempData["successMessage"] = "You are a registered user now.";
            return RedirectToAction("Index", "Login");        
        }
    }
}
