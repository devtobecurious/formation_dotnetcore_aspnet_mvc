using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.backoffice.Web.UI.v2.Controllers
{
    public class PropositionController : Controller
    {
        #region Champs privés
        private DefaultContext _context = null;
        #endregion

        #region Constructeurs
        public PropositionController(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            this.SetQuestionList();

            return this.View();
        }

        [HttpPost]
        public IActionResult Add(Reponse reponse)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Reponses.Add(reponse);
                this._context.SaveChanges();
            }

            this.SetQuestionList();

            return this.View(reponse);
        }

        private void SetQuestionList()
        {
            this.ViewBag.QuestionList = this._context.Questions.ToList();
        }
    }
}