using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_comm.DB.EF;
using e_comm.ViewModels.HomePage;
using e_comm.ViewModels.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace e_comm.Controllers
{
    public class HomePageController : Controller
    {
        private DBcon con;
        private IConfiguration _configuration;

        public HomePageController(DBcon _con, IConfiguration configuration)
        {
            con = _con;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            HomePageIndexVM hm = new HomePageIndexVM
            {
                Rows = con.Products.Where(x => x.Id <= 6).Select(x => new HomePageIndexVM.Row
                {
                    Route = x.ImageRoute,
                }
                ).ToList()
            };
            return View(hm);
        }
        public IActionResult ProductListing(int GenderId)
        {
            ProductListingVM hm = new ProductListingVM
            {
                Rows= con.Products.Where(x=>x.GenderId==GenderId).Select(x=> new ProductListingVM.Row
                {
                    Price=x.Price.ToString(),
                    ProductName=x.ProductName,
                    CategoryId=x.CategoryId,
                    GenderId=x.GenderId,
                    ShortDescription=x.ShortDescription,
                    Route=x.ImageRoute
                }).ToList()
            };
            return View(hm);
        }


    }
}
