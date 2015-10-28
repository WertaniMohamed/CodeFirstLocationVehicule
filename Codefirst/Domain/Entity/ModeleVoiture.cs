using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ModeleVoiture:Voiture
    {
        public string Categorie { get; set; }
        public string Carburant { get; set; }
        public int Nbplaces { get; set; }
        public string BoiteVidesse { get; set; }
    }
}
