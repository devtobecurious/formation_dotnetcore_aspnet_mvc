using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Reponse
    {
        #region Propriétés
        /// <summary>
        /// Id de la réponse
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Proposition de réponse
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
