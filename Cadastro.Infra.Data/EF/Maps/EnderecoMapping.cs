using Cadastro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infra.Data.EF.Maps
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Estado)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Cidade)
             .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.CEP)
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(x => x.Logradouro)
                 .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Numero)
               .IsRequired();

            builder.Property(x => x.Complemento)
                .IsRequired();

            builder.Property(x => x.UsuarioId)
             .IsRequired();

        }
    }
}
