using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Starcraft.Models;

namespace Starcraft.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //클래스 라이브러리 참조
            StarcraftLibrary.GoDoWa goDowa = new StarcraftLibrary.GoDoWa();
            string strTemp = string.Empty;
            strTemp = goDowa.ReturnReturn(ref strTemp, new string[] { "저그와 ", "테란" });

            Thread.Sleep(3000);

            ViewBag.Label = strTemp;


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
