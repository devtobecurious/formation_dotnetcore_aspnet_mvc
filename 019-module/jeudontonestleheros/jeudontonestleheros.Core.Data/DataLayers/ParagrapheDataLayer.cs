using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace jeudontonestleheros.Core.Data.DataLayers
{
    /// <summary>
    /// Layer gérant les échanges vers la base de données pour les paragraphes
    /// </summary>
    public class ParagrapheDataLayer
    {
        #region Fields
        private DefaultContext _context = null;
        #endregion

        #region Constructors
        public ParagrapheDataLayer(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Retourne le premier paragraphe
        /// </summary>
        /// <returns></returns>
        public Models.Paragraphe GetFirst()
        {
            return this._context.Paragraphes
                                .Include(item => item.MaQuestion)
                                .ThenInclude(item => item.MesReponses)
                                .First(item => item.EstInitial);
        }

        /// <summary>
        /// Retourne un paragraphe
        /// </summary>
        /// <param name="id">Identifiant du paragraphe recherché</param>
        /// <returns></returns>
        public Models.Paragraphe GetOne(int id)
        {
            return this._context.Paragraphes
                                .Include(item => item.MaQuestion)
                                .ThenInclude(item => item.MesReponses)
                                .First(item => item.Id == id);
        }
        #endregion
    }
}
