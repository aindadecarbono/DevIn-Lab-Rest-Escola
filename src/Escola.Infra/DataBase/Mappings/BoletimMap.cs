using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.DataBase.Mappings
{
    public class BoletimMap : IEntityTypeConfiguration<Boletim>
    {
        public void Configure(EntityTypeBuilder<Boletim> builder)
        {
            builder.ToTable("BOLETIM");

            builder.HasKey(x => x.Id)
                .HasName("PK_BoletimId");

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("uniqueidentifier");

            builder.Property(x => x.AlunoId)
                .HasColumnName("ALUNO_ID")
                .HasColumnType("uniqueidentifier");


            builder.HasOne(x => x.Aluno)
            .WithMany(x => x.Boletins)
            .HasForeignKey(x => x.AlunoId);


            builder.HasMany(x => x.NotasMateria)
                    .WithOne(x => x.Boletim);
                    

          
            builder.Property(x => x.Aprovado)
                .HasColumnName("APROVADO")
                .HasColumnType("BIT");
                

        }
    }
}
