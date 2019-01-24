using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Propriétés
        /// <summary>
        /// C'est l'id de chaque aventure
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// C'est le titre de chaque aventure
        /// </summary>
        public string Titre { get; set; }
        #endregion
    }
}
