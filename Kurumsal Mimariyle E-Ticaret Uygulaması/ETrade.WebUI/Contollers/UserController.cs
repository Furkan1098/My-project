using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.WebUI.Contollers
{
    public class UserController : Controller
    {

        public IActionResult MyAccount()
        {
            return View();
        }
    }
}
