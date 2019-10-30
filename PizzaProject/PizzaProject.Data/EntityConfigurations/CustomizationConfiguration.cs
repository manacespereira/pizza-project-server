using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data.EntityConfigurations
{
    public class CustomizationConfiguration : IEntityTypeConfiguration<Customization>
    {
        public void Configure(EntityTypeBuilder<Customization> builder)
        {
            builder.ToTable("Customizations");

            builder.HasKey(x => x.UId);

            builder.HasMany(x => x.PizzaCustomizations).WithOne(x => x.Customization);
        }
    }
}
