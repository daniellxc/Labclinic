namespace LAB5.Labclinic.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using LAB5.Labclinic.Data.Entidades;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Caso> Caso { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Profissional> Profissional { get; set; }
        public virtual DbSet<StatusCaso> StatusCaso { get; set; }
        public virtual DbSet<StatusConsulta> StatusConsulta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caso>()
                .Property(e => e.Periodicidade)
                .IsUnicode(false);

            modelBuilder.Entity<Caso>()
                .Property(e => e.Resumo)
                .IsUnicode(false);

            modelBuilder.Entity<Caso>()
                .HasMany(e => e.Consulta)
                .WithRequired(e => e.Caso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Consulta>()
                .Property(e => e.Relato)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.TelefoneFixo)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Caso)
                .WithRequired(e => e.Pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasOptional(e => e.Profissional)
                .WithRequired(e => e.Pessoa);

            modelBuilder.Entity<Profissional>()
                .Property(e => e.Especialidade)
                .IsUnicode(false);

            modelBuilder.Entity<Profissional>()
                .HasMany(e => e.Caso)
                .WithRequired(e => e.Profissional)
                .HasForeignKey(e => e.IdProfissional)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusCaso>()
                .Property(e => e.NomeStatusCaso)
                .IsUnicode(false);

            modelBuilder.Entity<StatusCaso>()
                .Property(e => e.DescricaoStatusCaso)
                .IsUnicode(false);

            modelBuilder.Entity<StatusCaso>()
                .HasMany(e => e.Caso)
                .WithRequired(e => e.StatusCaso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusConsulta>()
                .Property(e => e.NomeStatusConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<StatusConsulta>()
                .Property(e => e.DescricaoStatusConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<StatusConsulta>()
                .HasMany(e => e.Consulta)
                .WithRequired(e => e.StatusConsulta)
                .WillCascadeOnDelete(false);
        }
    }
}
