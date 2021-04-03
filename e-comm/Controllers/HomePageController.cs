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
        public IActionResult Index(bool logged=false)
        {
            HomePageIndexVM hm = new HomePageIndexVM
            {
                
                Rows = con.Products.Where(x => x.Id <= 6).Select(x => new HomePageIndexVM.Row
                {
                    Route = x.ImageRoute,
                }
                ).ToList(),
                Categories = con.Categories.Select(x => x).ToList()

            };
            hm.logged = logged;
            return View(hm);
        }
        public IActionResult ProductListing(int GenderId=0,int CategoryId=0,bool logged=false,string search=null)
        {
            ProductListingVM hm = new ProductListingVM();
            if (search != null)
            {
                hm.Rows = con.Products.Where(x => x.ProductName.Contains(search)).Select(x => new ProductListingVM.Row
                {
                    Price = x.Price.ToString(),
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    GenderId = x.GenderId,
                    ShortDescription = x.ShortDescription,
                    Route = x.ImageRoute
                }).ToList();
                hm.Categories = con.Categories.Select(x => x).ToList();
                hm.logged = logged;
                return View(hm);
            }

                                                           
                if (CategoryId == 0)
                {
                    hm.Rows = con.Products.Where(x => x.GenderId == GenderId).Select(x => new ProductListingVM.Row
                    {
                        Price = x.Price.ToString(),
                        ProductName = x.ProductName,
                        CategoryId = x.CategoryId,
                        GenderId = x.GenderId,
                        ShortDescription = x.ShortDescription,
                        Route = x.ImageRoute
                    }).ToList();
                    hm.Categories = con.Categories.Select(x => x).ToList();
                hm.logged = logged;
                return View(hm);

            }
                hm.Rows = con.Products.Where(x => x.CategoryId == CategoryId).Select(x => new ProductListingVM.Row
                {
                    Price = x.Price.ToString(),
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    GenderId = x.GenderId,
                    ShortDescription = x.ShortDescription,
                    Route = x.ImageRoute
                }).ToList();

                hm.logged = logged;



            return View(hm);


        }
        public IActionResult BrandListing(bool logged=false)
        {
            BrandListingVM hm = new BrandListingVM
            {
                Rows = con.Categories.Select(x => new BrandListingVM.Row
                {
                    ProductName=x.CategoryName,
                    Route=x.ImageRoute,
                    CategoryId=x.Id
                }).ToList(),
                
            };
            hm.logged = logged;

            return View(hm);
        }
        public IActionResult Search(HomePageIndexVM modelH=null,BrandListingVM modelB=null,ProductListingVM modelP=null )
        {
            string search = null;
            
            bool logged = false;
            if (modelH.Search != null)
            {
                logged = bool.Parse(modelH.loggedString);               
                search = modelH.Search;

            }
            else if (modelB.Search != null)
            {
                logged = bool.Parse(modelB.loggedString);
                search = modelB.Search;
            }
            else if (modelP.Search != null)
            {
                logged = bool.Parse(modelP.loggedString);
                search = modelP.Search;
            }


            return RedirectToAction("ProductListing", new {logged=logged,search=search });
        }





    }
}
