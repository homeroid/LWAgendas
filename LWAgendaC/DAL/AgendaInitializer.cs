using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LWAgendaC.Models;

namespace LWAgendaC.DAL
{
    public class AgendaInitializer  : System.Data.Entity.DropCreateDatabaseIfModelChanges<AgendaContext>
    {
        protected override void Seed(AgendaContext context)
        {
            var contacts = new List<Register>
            {
                new Register{Name="Homero", LastName="Glez", Number="6144044649", NType="Oficina"},
                new Register{Name="Algo", LastName="Glez", Number="6144044649", NType="Oficina"}
            };
            contacts.ForEach(s => context.Register.Add(s));
            context.SaveChanges();
        }
    }
}