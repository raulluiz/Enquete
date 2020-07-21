using Enquete.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.Infrastructure.EntityConfig
{
    public class PollOptionConfig : IEntityTypeConfiguration<PollOption>
    {
        public void Configure(EntityTypeBuilder<PollOption> builder)
        {
            builder.ToTable("PollOption");
            builder.HasKey(c => new { c.PollId, c.OptionId });
        }
    }
}
