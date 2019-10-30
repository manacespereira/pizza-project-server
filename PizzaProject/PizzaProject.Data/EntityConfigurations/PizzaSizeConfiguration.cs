using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Data.EntityConfigurations
{
    public class PizzaSizeConfiguration : IEntityTypeConfiguration<PizzaSize>
    {

        public void Configure(EntityTypeBuilder<PizzaSize> builder)
        {
            builder.ToTable("PizzaSizes");

            builder.HasKey(x => x.UId);
        }
    }
}
