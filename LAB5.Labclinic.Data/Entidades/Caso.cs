namespace LAB5.Labclinic.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Caso")]
    public partial class Caso
    {
        public Caso()
        {
            Consulta = new HashSet<Consulta>();
        }

        [Key]
        public int IdCaso { get; set; }

        public int IdPessoa { get; set; }

        public int IdProfissional { get; set; }

        public int IdStatusCaso { get; set; }

        [Required]
        [StringLength(50)]
        public string Periodicidade { get; set; }

        public int? ConsultasPrevistas { get; set; }

        public DateTime DataPrimeiroContato { get; set; }

        [Column(TypeName = "text")]
        public string Resumo { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual Profissional Profissional { get; set; }

        public virtual StatusCaso StatusCaso { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
