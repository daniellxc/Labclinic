namespace LAB5.Labclinic.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consulta")]
    public partial class Consulta
    {
        [Key]
        public int IdConsulta { get; set; }

        public int IdCaso { get; set; }

        public int IdStatusConsulta { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime? DataTermino { get; set; }

        [Column(TypeName = "text")]
        public string Relato { get; set; }

        public virtual Caso Caso { get; set; }

        public virtual StatusConsulta StatusConsulta { get; set; }
    }
}
