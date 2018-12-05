using jeudontestleheros.Web.UI.Models;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontestleheros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        //private readonly DefaultContext _context = null;

        //public AventureController(DefaultContext context)
        //{
        //    this._context = context;
        //}

        public ActionResult Index([FromServices] DefaultContext context)
        {
            this.ViewBag.MonTitre = "Aventures";

            var query = from item in context.Aventures
                        select item;

            return View(query.ToList());
        }
    }
}
