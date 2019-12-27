using jeudontestleheros.Web.UI.Models;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.DataLayers;
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
        private readonly DefaultContext _context = null;
        private ParagrapheDataLayer _paragrapheLayer = null;

        public AventureController(DefaultContext context, ParagrapheDataLayer paragrapheLayer)
        {
            this._context = context;
            this._paragrapheLayer = paragrapheLayer;
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Aventure aventure)
        {
            ActionResult result = this.View(aventure);

            if (this.ModelState.IsValid)
            {
                this._context.Aventures.Add(aventure);
                this._context.SaveChanges();

                result = this.RedirectToAction("BeginNewOne");
            }
            return result;
        }

        public ActionResult BeginNewOne(int id)
        {
            Paragraphe item = null;

            if (id == 0)
                item = this._paragrapheLayer.GetFirst();
            else
                item = this._paragrapheLayer.GetOne(id);

            return this.View(item);
        }

        public ActionResult Edit(int id)
        {
            return this.View();
        }

        public ActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventures";

            var query = from item in this._context.Aventures
                        select item;


            return View(query.ToList());
        }
    }
}
