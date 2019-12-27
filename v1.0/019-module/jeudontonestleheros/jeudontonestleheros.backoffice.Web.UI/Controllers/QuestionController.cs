using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheros.backoffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        #region Champs privés
        private DefaultContext _context = null;
        #endregion

        #region Constructeurs
        public QuestionController(DefaultContext context)
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
            this.ViewBag.ParagrapheList = this._context.Paragraphes.ToList();

            return this.View();
        }

        [HttpPost]
        public IActionResult Add(Question question)
        {
            if(this.ModelState.IsValid)
            {
                this._context.Questions.Add(question);
                this._context.SaveChanges();
            }

            this.ViewBag.ParagrapheList = this._context.Paragraphes.ToList();

            return this.View(question);
        }
    }
}