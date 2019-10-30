using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data.EntityConfigurations
{
    public class FlavorConfiguration : IEntityTypeConfiguration<Flavor>
    {
        public void Configure(EntityTypeBuilder<Flavor> builder)
        {
            builder.ToTable("Flavors");

            builder.HasKey(x => x.UId);
        }
    }
}
