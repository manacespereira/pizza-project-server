using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data.EntityConfigurations
{
    public class PizzaCustomizationConfiguration : IEntityTypeConfiguration<PizzaCustomization>
    {

        public void Configure(EntityTypeBuilder<PizzaCustomization> builder)
        {
            builder.ToTable("PizzaCustomizations");

            builder.HasKey(x => x.UId);
        }
    }
}
