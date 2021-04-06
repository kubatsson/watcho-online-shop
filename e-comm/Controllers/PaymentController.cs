using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_comm.DB.Domain;
using e_comm.DB.EF;
using e_comm.ViewModels.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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

        public IActionResult Index(int ProductId, bool logged)
        {

            //if (logged == false)
            //{
            //    return RedirectToAction("Index", "Login");
            //}

            Product product = con.Products.Find(ProductId);

            PaymentFirstVM model = new PaymentFirstVM
            {
                Price=product.Price,
                ShortDescription=product.ShortDescription,
                GenderId=product.GenderId,
                CategoryId=product.CategoryId,
                ImageRoute=product.ImageRoute,
                ProductName=product.ProductName
                
            };



            return View(model);
        }
        public IActionResult PaymentOption(PaymentFirstVM model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index","HomePage");

            PaymentOptionVM pay = new PaymentOptionVM
            {
                Price=model.Price,
                ProductName=model.ProductName,
                PaypalRoute= "https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_xclick&amount="+model.Price.ToString()+"&business=adiskubatsson@gmail.com&item_name="
                +model.ProductName+"&return=https://localhost:44342"
            };



            return View(pay);
        }
    }
}
