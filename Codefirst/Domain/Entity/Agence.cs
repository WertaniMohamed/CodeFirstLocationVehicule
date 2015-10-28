using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Agence
    {
        [Key]
        public int AgenceId { get; set; }
        public int NumTel1 { get; set; }
        public string Adresse { get; set; }
        virtual public ICollection<Contrat> Contrats { get; set; }
    }
}
