
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("Name=DefaultConnection")
        {
            Database.SetInitializer<MyFinanceContext>(new MyFinanceInitialisation());
        }

        public DbSet<Agence> Agences { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Voiture> Voitures { get; set; }
        


        //dbcontext c'est le responsable de cree la base et faire par defaut donc en oblige de cree selon ma configuration

    }
}
