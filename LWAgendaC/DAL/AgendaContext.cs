using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using LWAgendaC.Models;

namespace LWAgendaC.DAL
{
    public class AgendaContext: DbContext
    {
        public AgendaContext() : base("AgendaContext")
        {

        }

        public DbSet<Register> Register { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}