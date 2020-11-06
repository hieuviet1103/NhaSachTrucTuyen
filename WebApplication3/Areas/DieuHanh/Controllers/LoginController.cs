using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Areas.DieuHanh.Controllers
{
    public class LoginController : Controller
    {
        // GET: DieuHanh/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View("Index",model);
        }
    }
}