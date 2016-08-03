using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Samples.DI;

namespace Samples.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IEmailSender _emailSender;

	    public HomeController(IEmailSender emailSender)
	    {
		    _emailSender = emailSender;
	    }

	    public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

	        _emailSender.SendEmail("to@email.com", "subject line", "message");

			return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
