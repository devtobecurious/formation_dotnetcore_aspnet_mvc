using JetBrains.Annotations;
using jeudontonestleheros.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        //public DefaultContext()
        //{
        //}

        #region Properties
        public DbSet<Aventure> Aventures { get; set; }

        public DbSet<Paragraphe> Paragraphes { get; set; }
        #endregion
    }
}
