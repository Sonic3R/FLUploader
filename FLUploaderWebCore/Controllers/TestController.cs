using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceCore;

namespace FLUploaderWebCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            FTPManager man = new FTPManager();
            man.Connect();

            return Content("test");
        }
    }
}