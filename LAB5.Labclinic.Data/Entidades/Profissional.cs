namespace LAB5.Labclinic.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profissional")]
    public partial class Profissional
    {
        public Profissional()
        {
            Caso = new HashSet<Caso>();
        }

        [Key]
        public int IdPessoa { get; set; }

        public int RegistroOrdem { get; set; }

        [Required]
        [StringLength(100)]
        public string Especialidade { get; set; }

        public virtual ICollection<Caso> Caso { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
