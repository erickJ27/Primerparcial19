﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using primerparcial19.Models;
namespace primerparcial19.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripciones> Incripcion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder.UseSqlite(@"Data source=Database/primerparcial.db"));
        }
    }
}
