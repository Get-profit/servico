using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Domain.Entities;

namespace ProjetoAPI.Domain.Context
{
    public partial class AcessoriosContext : DbContext
    {
        public AcessoriosContext()
        {
        }

        public AcessoriosContext(DbContextOptions<AcessoriosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<OrdemServico> OrdemServico { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=34.69.66.179; user=sqlserver; password=get123; Database=Acessorios; integrated security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .HasColumnName("cidade")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .HasColumnName("logradouro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdemServico>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataEntrada)
                    .HasColumnName("dataEntrada")
                    .HasColumnType("date");

                entity.Property(e => e.DataSaida)
                    .HasColumnName("dataSaida")
                    .HasColumnType("date");

                entity.Property(e => e.Defeito)
                    .HasColumnName("defeito")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenhaDesbloqueio)
                    .HasColumnName("senhaDesbloqueio")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorOrcado)
                    .HasColumnName("valorOrcado")
                    .HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.OrdemServico)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__OrdemServ__idCli__3A81B327");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apelido)
                    .HasColumnName("apelido")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasColumnName("senha")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
