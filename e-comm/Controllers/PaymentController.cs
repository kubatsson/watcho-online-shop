using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_comm.DB.Domain;
using e_comm.DB.EF;
using e_comm.Helpers;
using e_comm.ViewModels.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using static e_comm.ViewModels.Payment.PaymentFirstVM;

namespace e_comm.Controllers
{
    public class PaymentController : Controller
    {
        private DBcon con;
        private IConfiguration _configuration;

        public PaymentController(DBcon _con, IConfiguration configuration)
        {
            con = _con;
            _configuration = configuration;
        }

        public IActionResult Index(int ProductId)
        {

            if (HttpContext.GetLoggedUser() == null)
            {
                return RedirectToAction("Index", "Login");
            }
            TempData["logged"] = "True";

            Product product = con.Products.Find(ProductId);

            var user = HttpContext.GetLoggedUser();

            BillingDetails billing = con.BillingDetails.Where(x => x.UserId ==user.Id).FirstOrDefault();

            ShippingInfo shipping = new ShippingInfo();

            if (billing != null)
            {
                shipping.FullName = billing.Fullname;
                shipping.Email = billing.Email;
                shipping.Zip = billing.Zip;
                shipping.Country = billing.Country;
                shipping.StreetAddress = billing.StreetAddress;
                shipping.City = billing.City;
                shipping.PhoneNumber = billing.PhoneNumber;               
            }         

            PaymentFirstVM model = new PaymentFirstVM
            {
                ProductId=ProductId,
                Price=product.Price,
                ShortDescription=product.ShortDescription,
                GenderId=product.GenderId,
                CategoryId=product.CategoryId,
                ImageRoute=product.ImageRoute,
                ProductName=product.ProductName,
                CustomerInfo=shipping                                              
            };
            return View(model);
        }

        public IActionResult PaymentOption(PaymentFirstVM model)
        {
            if (HttpContext.GetLoggedUser() != null)
            {
                TempData["logged"] = "True";
            }

            var user = HttpContext.GetLoggedUser();
           
            var details = con.BillingDetails.Where(x=>x.UserId==user.Id).FirstOrDefault();
            BillingDetails billing = new BillingDetails();
            if (model.CustomerInfo != null && details!=null)
            {
                details.Email = model.CustomerInfo.Email;
                details.Fullname = model.CustomerInfo.FullName;
                details.Zip = model.CustomerInfo.Zip;
                details.Country = model.CustomerInfo.Country;
                details.City = model.CustomerInfo.City;
                details.StreetAddress = model.CustomerInfo.StreetAddress;
                details.UserId = user.Id;
                details.PhoneNumber = model.CustomerInfo.PhoneNumber;

                con.SaveChanges();
            }
            else
            {
                billing.Email = model.CustomerInfo.Email;
                billing.Fullname = model.CustomerInfo.FullName;
                billing.Zip = model.CustomerInfo.Zip;
                billing.Country = model.CustomerInfo.Country;
                billing.City = model.CustomerInfo.City;
                billing.StreetAddress = model.CustomerInfo.StreetAddress;
                billing.UserId = user.Id;
                billing.PhoneNumber = model.CustomerInfo.PhoneNumber;
              
                con.Add(billing);                
            }
            
            con.SaveChanges();
            int product = con.Products.Find(model.ProductId).Id;

            if (!ModelState.IsValid)
                return RedirectToAction("Index","HomePage");
          
            PaymentOptionVM pay = new PaymentOptionVM
            {
                Price = model.Price,
                ProductName = model.ProductName,
                PaypalRoute = "https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_xclick&amount=" + model.Price.ToString() + "&business=adiskubatsson@gmail.com&item_name="
                + model.ProductName + "&return=https://localhost:44342/Payment/PaymentSuccess?ProductId=" + product
            };

            return View(pay);
        }

        public IActionResult PaymentSuccess(int ProductId)
        {
            if (HttpContext.GetLoggedUser() != null)
            {
                TempData["logged"] = "True";
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

            User user = con.Users.Find(HttpContext.GetLoggedUser().Id);
            Product product = con.Products.Find(ProductId);

            Payment payment = new Payment
            {
                UserId = user.Id,
                ProductId = product.Id
            };


            con.Payments.Add(payment);
            con.SaveChanges();

            string messageRequest = "You have new order on your online shop! Check it out";
            string messageForUser = "You've successfully ordered a new watch. You will get your order in next 15 days on the address you have " +
                "entered in the 'Billing details' form.";

            EmailSettings.SendEmail(_configuration, user.Username, user.Email, "Order confirmation", messageForUser);
            EmailSettings.SendEmail(_configuration, "Adis Kubat", "adiskubatsson@gmail.com", "New order", messageRequest);

            return View();
            
        }
    }
}
