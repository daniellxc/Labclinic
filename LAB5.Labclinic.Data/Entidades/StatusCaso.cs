namespace LAB5.Labclinic.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusCaso")]
    public partial class StatusCaso
    {
        public StatusCaso()
        {
            Caso = new HashSet<Caso>();
        }

        [Key]
        public int IdStatusCaso { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeStatusCaso { get; set; }

        [StringLength(200)]
        public string DescricaoStatusCaso { get; set; }

        public virtual ICollection<Caso> Caso { get; set; }
    }
}
