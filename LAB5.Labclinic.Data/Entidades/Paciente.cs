using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Labclinic.Data.Entidades
{
    [Table("Paciente")]
    public class Paciente
    {
        [Key]
        public int IdPessoa { get; set; }

        [StringLength(20)]
        public string Identificador { get; set; }

        public string Observacao { get; set; }

        public virtual Pessoa Pessoa { get; set; }

    }
}
