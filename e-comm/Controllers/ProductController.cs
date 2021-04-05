using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_comm.DB.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace e_comm.Controllers
{
    public class ProductController : Controller
    {
        private DBcon con;
        private IConfiguration _configuration;

        public ProductController(DBcon _con, IConfiguration configuration)
        {
            con = _con;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
