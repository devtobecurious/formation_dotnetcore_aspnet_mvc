using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region A supprimer après entities
        private List<Paragraphe> _maList = new List<Paragraphe>()
        {
            new Paragraphe() { Id = 1, Numero = 1, Titre = "Titre 1"},
            new Paragraphe() { Id = 2, Numero = 10, Titre = "Titre 2"},
            new Paragraphe() { Id = 5, Numero = 14, Titre = "Titre 3"}
        };
        #endregion

        #region Méthodes publiques
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }

        public ActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            #region A changer avec l'appel en base de données / entities
            paragraphe = _maList.First(item => item.Id == id);
            #endregion

            return this.View(paragraphe);
        }

        [HttpPost]
        public ActionResult Edit(Paragraphe paragraphe)
        {
            return this.View(paragraphe);
        }
        #endregion
    }
}
