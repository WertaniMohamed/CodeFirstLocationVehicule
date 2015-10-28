using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Voiture
    {
        [Key]
        public int VoitureId { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Couleur { get; set; }
        public string Immatriculation { get; set; }
        public int Km { get; set; }
        public bool Disponible { get; set; }
       virtual public ICollection<Contrat> Contrats { get; set; }

    }
}
