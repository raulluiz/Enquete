using Enquete.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.Infrastructure.EntityConfig
{
    public class OptionConfig : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            builder.ToTable("Option");
            builder.HasKey(c => c.OptionId);
            builder.Property(c => c.OptionId).ValueGeneratedOnAdd();
            builder.Property(c => c.OptionDescription);
        }
    }
}
