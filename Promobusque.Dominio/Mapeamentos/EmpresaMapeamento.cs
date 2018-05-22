using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobusque.Dominio.Mapeamentos
{
    public class EmpresaMapeamento : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMapeamento()
        {
            ToTable("Empresa");

            HasKey(e => e.Id);

            Property(e => e.RazaoSocial)
                .HasColumnName("RazaoSocial")
                .HasColumnType("varchar");

            Property(e => e.Cep)
                .HasColumnName("Cep")
                .HasColumnType("varchar");

            Property(e => e.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("varchar");

            Property(e => e.Cnpj)
                .HasColumnName("Cnpj")
                .HasColumnType("varchar");

            Property(e => e.DataAlteracao)
                .HasColumnName("DataAlteracao")
                .HasColumnType("datetime");

            Property(e => e.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("datetime");

            Property(e => e.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("varchar");

            Property(e => e.Estado)
                .HasColumnName("Estado")
                .HasColumnType("varchar");

            Property(e => e.Site)
                .HasColumnName("Site")
                .HasColumnType("varchar");

            Property(e => e.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("varchar");

            Property(e => e.Logo)
                .HasColumnName("Logo")
                .HasColumnType("varbinary");

            Property(e => e.Celular)
                .HasColumnName("Estado")
                .HasColumnType("varchar");

            Property(e => e.IdUsuario)
                .HasColumnName("IdUsuario")
                .HasColumnType("bigint");
        }
    }
}
