using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
