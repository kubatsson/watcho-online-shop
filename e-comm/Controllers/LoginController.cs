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
                return View(model);

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


    }
}
