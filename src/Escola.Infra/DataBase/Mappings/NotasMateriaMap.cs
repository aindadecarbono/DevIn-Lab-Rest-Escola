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
    public class NotasMateriaMap : IEntityTypeConfiguration<NotasMateria>
    {

        public void Configure(EntityTypeBuilder<NotasMateria> builder)
        {
            builder.ToTable("NOTAS MATERIA");

            builder.HasKey(n => n.Id)
                    .HasName("PK_NotasMateriaID");

            builder.Property(n => n.Id)
                    .HasColumnName("ID")
                    .HasColumnType("uniqueidentifier");

            builder.Property(n => n.BoletimId)
                    .HasColumnName("BOLETIM_ID")
                    .HasColumnType("uniqueidentifier");

            builder.HasOne(n => n.Boletim)
                .WithMany(n => n.NotasMateria)
                .HasForeignKey(n => n.BoletimId);


            builder.Property(n => n.MateriaId)
                    .HasColumnName("MATERIA_ID")
                    .HasColumnType("uniqueidentifier");

            builder.HasOne(n => n.Materia)
                .WithMany(n => n.NotasMaterias)
                .HasForeignKey(n => n.MateriaId);


            builder.Property(n => n.Nota)
                    .HasColumnName("NOTA")
                    .HasColumnType("int");
                    
        }

        
    }
}
