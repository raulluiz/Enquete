using Enquete.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enquete.Infrastructure.EntityConfig
{
    public class PoolConfig : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder.ToTable("Poll");
            builder.HasKey(c => c.PollId);
            builder.Property(c => c.PollId).ValueGeneratedOnAdd();
            builder.Property(c => c.PollDescription);
            builder.Property(c => c.Views);
        }
    }
}
