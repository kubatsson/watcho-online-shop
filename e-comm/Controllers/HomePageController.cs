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
using e_comm.Helpers;

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
            if (HttpContext.GetLoggedUser() != null)
            {
                TempData["logged"] = "True";
            }
            
            HomePageIndexVM hm = new HomePageIndexVM
            {                
                Rows = con.Products.Where(x => x.Id <= 6).Select(x => new HomePageIndexVM.Row
                {
                    Route = x.ImageRoute,
                    Id=x.Id
                }
                ).ToList(),
                Categories = con.Categories.Select(x => x).ToList()
            };
            
            return View(hm);
        }

        

        public IActionResult ProductListing(int GenderId=0,int CategoryId=0,string search=null)
        {
            if (HttpContext.GetLoggedUser() != null)
            {
                TempData["logged"] = "True";
            }


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
                    Route = x.ImageRoute,
                    Id=x.Id
                   
                }).ToList();

                hm.Categories = con.Categories.Select(x => x).ToList();

                
                return View(hm);
            }

                if (CategoryId == 0 && GenderId==3)
                {
                    hm.Rows = con.Products.Select(x => new ProductListingVM.Row
                    {
                    Price = x.Price.ToString(),
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    GenderId = x.GenderId,
                    ShortDescription = x.ShortDescription,
                    Route = x.ImageRoute,
                    Id = x.Id

                    }).ToList();

                    hm.Categories = con.Categories.Select(x => x).ToList();


                     return View(hm);
                }
            if (CategoryId == 0 ) 
                {
                    hm.Rows = con.Products.Where(x => x.GenderId == GenderId).Select(x => new ProductListingVM.Row
                    {
                        Price = x.Price.ToString(),
                        ProductName = x.ProductName,
                        CategoryId = x.CategoryId,
                        GenderId = x.GenderId,
                        ShortDescription = x.ShortDescription,
                        Route = x.ImageRoute,
                        Id=x.Id

                    }).ToList();

                    hm.Categories = con.Categories.Select(x => x).ToList();

                
                return View(hm);
                 }
                hm.Rows = con.Products.Where(x => x.CategoryId == CategoryId).Select(x => new ProductListingVM.Row
                {
                    Price = x.Price.ToString(),
                    ProductName = x.ProductName,
                    CategoryId = x.CategoryId,
                    GenderId = x.GenderId,
                    ShortDescription = x.ShortDescription,
                    Route = x.ImageRoute,
                    Id=x.Id
                }).ToList();

                
                return View(hm);
        }
        
        public IActionResult BrandListing()
        {

            if (HttpContext.GetLoggedUser() != null)
            {
                TempData["logged"] = "True";
            }

            BrandListingVM hm = new BrandListingVM
            {
                Rows = con.Categories.Select(x => new BrandListingVM.Row
                {
                    ProductName=x.CategoryName,
                    Route=x.ImageRoute,
                    CategoryId=x.Id
                }).ToList(),               
            };
          
            return View(hm);
        }

        //search bar
        public IActionResult Search(HomePageIndexVM modelH=null,BrandListingVM modelB=null,ProductListingVM modelP=null )
        {
            string search = null;
            
            
            if (modelH.Search != null)
            {
                               
                search = modelH.Search;

            }
            else if (modelB.Search != null)
            {
                
                search = modelB.Search;
            }
            else if (modelP.Search != null)
            {
                
                search = modelP.Search;
            }
            return RedirectToAction("ProductListing", new { search = search }) ;
        }

        public IActionResult ContactUs()
        {

            if (HttpContext.GetLoggedUser() != null)
            {
                TempData["logged"] = "True";
            }
            
            return View();
        }

        public IActionResult ContactUsSend(ContactUsVM model)
        {
         


            string messageRequest = "Message from: " + model.Name + "\n Email address: "+model.Email+"\n Subject: "+model.Subject+"\n Message: "+model.Message;
            string messageForUser = "We have successfully received your request and you will get an answer in short period!";    

            

            EmailSettings.SendEmail(_configuration, model.Name, model.Email, "Ticket confirmation", messageForUser);
            EmailSettings.SendEmail(_configuration, "Adis Kubat", "adiskubatsson@gmail.com", "Message request", messageRequest);

            return RedirectToAction("ContactUs");
        }
    }
}
