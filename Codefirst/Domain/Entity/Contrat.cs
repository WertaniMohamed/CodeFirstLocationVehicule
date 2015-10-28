using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Contrat
    {
        [Key]
        public int ContratId { get; set; }
        public DateTime DateLocation { get; set; }
        public DateTime DateRetour { get; set; }
        public int Km { get; set; }

        public int AgenceId { get; set; }
        

        public int ClientId { get; set; }

        public int VoitureId { get; set; }

        public virtual Agence Agence { get; set; }
        public virtual Client Client { get; set; }
        public virtual Voiture Voiture { get; set; }
    }
}
