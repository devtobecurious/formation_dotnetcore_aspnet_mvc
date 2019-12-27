using jeudontonestleheros.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.DataLayers
{
    /// <summary>
    /// Layer d'accès à la base de données (encapsule l'appel entities)
    /// </summary>
    public class AventureDataLayer
    {
        #region Fields
        private DefaultContext _context = null;
        #endregion

        #region Constructors
        public AventureDataLayer(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Ajoute et sauvegarde une nouvelle aventure
        /// </summary>
        /// <param name="aventure"></param>
        public void Add(Aventure aventure)
        {
            this._context.Aventures.Add(aventure);
            this._context.SaveChanges();
        }
        #endregion
    }
}
