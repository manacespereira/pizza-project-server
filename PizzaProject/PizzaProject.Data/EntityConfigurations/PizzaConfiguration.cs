using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data.EntityConfigurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {

        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.ToTable("Pizzas");

            builder.HasKey(x => x.UId);

            builder.HasOne(x => x.Flavor).WithMany(x => x.Pizzas).HasConstraintName("FlavorUId").IsRequired();
            builder.HasOne(x => x.Size).WithMany(x => x.Pizzas).HasConstraintName("PizzaSizeUId").IsRequired();
            builder.HasMany(x => x.PizzaCustomizations).WithOne(x => x.Pizza);
        }
    }
}
