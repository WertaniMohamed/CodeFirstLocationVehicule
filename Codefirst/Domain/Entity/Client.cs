using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Cin { get; set; }
        public String Adresse { get; set; }
        public String Email { get; set; }
        public int NumTel { get; set; }

        virtual public ICollection<Contrat> Contrats { get; set; }
    }
}
