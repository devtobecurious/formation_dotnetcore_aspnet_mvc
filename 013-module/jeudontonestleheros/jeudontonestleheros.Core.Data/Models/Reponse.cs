using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeudontonestleheros.Core.Data.Models
{
    [Table("Proposition")]
    public class Reponse
    {
        #region Propriétés
        /// <summary>
        /// Id de la réponse
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Proposition de réponse
        /// </summary>
        public string Description { get; set; }

        public int QuestionId { get; set; }
        #endregion
    }
}
