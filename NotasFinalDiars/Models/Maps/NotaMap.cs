using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasFinalDiars.Models.Maps
{
    public class NotaMap : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)
        {
            builder.ToTable("Notas");
            builder.HasKey(o => o.idNota);
        }
    }
}
