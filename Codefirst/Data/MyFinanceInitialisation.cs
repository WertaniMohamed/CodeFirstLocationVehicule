using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyFinanceInitialisation : DropCreateDatabaseIfModelChanges<MyFinanceContext>
    {
        protected override void Seed(MyFinanceContext context)
        {
            List<Agence> Agences = new List<Agence>
                {

                new Agence
                {
                    AgenceId=21,
                    Adresse="adrtest1",
                    NumTel1=4533554

                },
                new Agence
                {
                   AgenceId=22,
                    Adresse="adrtest12",
                    NumTel1=45335542

                },
                new Agence
                {
                    AgenceId=23,
                    Adresse="adrtest13",
                    NumTel1=45335543

                }

            };
            List<Client> Clients = new List<Client>
{
                new Client
                {
                    ClientId=27,
                    Cin=23324234,
                    Adresse="wesddsnjk",
                    Email="DJKNHDFJK",
                    Nom="onar",
                    Prenom="najjar",
                    NumTel=23434234
                },
                new Client
                {
                    ClientId=28,
                    Cin=23324235,
                    Adresse="wesddsnjks",
                    Email="DJKNHDFJKs",
                    Nom="omar",
                    Prenom="najjaro",
                    NumTel=234342345
                }
};

            
            List<Voiture> Voitures = new List<Voiture>
{
                new Voiture
                {
                    Km=500,
                    VoitureId=134456,
                    Couleur="Blanche",
                    Disponible=true,
                    Immatriculation="4433 tu 69",
                    Marque="Mercedes",
                    Modele="Familiale"
                },
                new Voiture
                {
                    Km=200,
                    VoitureId=234556,
                    Couleur="Noir",
                    Disponible=true,
                    Immatriculation="1729 tu 139",
                    Marque="Renault",
                    Modele="Familiale"
                }
};

            
            context.Voitures.AddRange(Voitures);
            context.Agences.AddRange(Agences);
            context.Clients.AddRange(Clients);

            context.SaveChanges();

        }

    }
}