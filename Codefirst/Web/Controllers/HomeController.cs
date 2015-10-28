using Data;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        MyFinanceContext db = new MyFinanceContext();
        public ActionResult Index()
        {
            Agence a = db.Agences.Create();
            Client c = db.Clients.Create();
            Voiture v = db.Voitures.Create();
            


            v.Km = 120;
            v.VoitureId = 134456;
            v.Couleur = "vert";
            v.Disponible = true;
            v.Immatriculation = "2134 tu 76";
            v.Marque = "Saxo";
            v.Modele = "Familiale";
           
            
            

            c.ClientId = 29;
            c.Cin = 233242345;
            c.Adresse = "wesddsnjkssas";
            c.Email = "DJKNHDFJKsadf";
            c.Nom = "onasdfsdr";
            c.Prenom = "nasdfdjjar";
            c.NumTel = 23434234;
            

            a.Adresse = "adr23342";
            a.AgenceId = 06;
            a.NumTel1 = 79408176;
                
            db.Agences.Add(a);
            db.Clients.Add(c);
            db.Voitures.Add(v);


            db.SaveChanges();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}