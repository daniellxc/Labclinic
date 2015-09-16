namespace LAB5.Labclinic.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        public Pessoa()
        {
            Caso = new HashSet<Caso>();
        }

        [Key]
        public int IdPessoa { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [StringLength(20)]
        public string RG { get; set; }

        [StringLength(14)]
        public string CPF { get; set; }

        [StringLength(50)]
        public string TelefoneFixo { get; set; }

        [MaxLength(50)]
        public string TelefoneMovel { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Caso> Caso { get; set; }

        public virtual Profissional Profissional { get; set; }
    }
}
