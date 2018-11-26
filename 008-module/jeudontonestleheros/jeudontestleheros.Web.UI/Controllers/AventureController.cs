using jeudontestleheros.Web.UI.Models;
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
            this.ViewBag.MonTitre = "Aventures";

            List<Aventure> maList = new List<Aventure>();

            maList.Add(new Aventure()
            {
                Id = 1,
                Titre = "Ma première aventure"
            });

            maList.Add(new Aventure()
            {
                Id = 2,
                Titre = "Ma seconde aventure"
            });

            return View(maList);
        }
    }
}
