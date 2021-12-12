using DesafioPjus.Domain.Cep;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioPjus.Infrastructure.Data.EntityConfigurations
{
    internal class CepEntityTypeConfiguration : IEntityTypeConfiguration<Cep>
    {
        public void Configure(EntityTypeBuilder<Cep> builder)
        {
            builder
                .ToTable(nameof(Cep))
                .HasKey(e => e.id);

            builder.Property(e => e.id).ValueGeneratedOnAdd();

            builder.Property(x => x.logradouro).IsRequired();
            builder.Property(x => x.gia);
            builder.Property(x => x.complemento).IsRequired();
            builder.Property(x => x.bairro).IsRequired();
            builder.Property(x => x.localidade).IsRequired();
            builder.Property(x => x.uf).IsRequired();
            builder.Property(x => x.cep).IsRequired();
            builder.Property(x => x.ddd).IsRequired();
            builder.Property(x => x.ibge);
            builder.Property(x => x.siafi);
        }
    }
}
