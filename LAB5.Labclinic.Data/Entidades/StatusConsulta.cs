namespace LAB5.Labclinic.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusConsulta")]
    public partial class StatusConsulta
    {
        public StatusConsulta()
        {
            Consulta = new HashSet<Consulta>();
        }

        [Key]
        public int IdStatusConsulta { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeStatusConsulta { get; set; }

        [StringLength(100)]
        public string DescricaoStatusConsulta { get; set; }

        public bool NecessitaJustificativa { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
