using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobusque.Dominio
{
    public class UsuarioMapeamento : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeamento()
        {
            ToTable("Usuario");

            Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar");

            Property(u => u.Senha)
                .HasColumnName("Nome")
                .HasColumnType("varchar");

            Property(u => u.senhaMD5)
                .HasColumnName("Nome")
                .HasColumnType("varchar");
        }
    }
}
