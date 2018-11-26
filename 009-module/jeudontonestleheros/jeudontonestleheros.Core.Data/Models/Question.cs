using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    public class Question
    {
        #region Propriétés
        /// <summary>
        /// Id de l'instance
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titre de la question
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Liste des réponses possibles
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
        #endregion
    }
}
