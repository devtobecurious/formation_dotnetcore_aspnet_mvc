using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Propriétés
        /// <summary>
        /// Id venant de la base
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Numéro à afficher pour le jeu
        /// </summary>
        [Range(1, 9999999)]
        public int Numero { get; set; }

        /// <summary>
        /// C'est le titre du paragraphe
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Titre requis")]
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        [Required(AllowEmptyStrings =false, ErrorMessage ="Description requise")]
        public string Description { get; set; }

        /// <summary>
        /// Question du paragraphe
        /// </summary>
        public Question MaQuestion { get; set; }
        #endregion
    }
}
