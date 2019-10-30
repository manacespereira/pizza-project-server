using System;
using System.Collections.Generic;
using PizzaProject.Domain.CommandHandlers;
using PizzaProject.Domain.Entities;

namespace PizzaProject.Tests.Fixtures
{
    public class PizzaFixture
    {
        public Pizza PizzaSmallCalabresa { get; }
        public Pizza PizzaMediumMarguerita { get; }
        public Pizza PizzaBigPortuguesa { get; }
        public Pizza PizzaSmallCalabresaWithExtraBacon { get; }
        public Pizza PizzaMediumMargueritaWithoutOnion { get; }
        public Pizza PizzaBigPortuguesaFilledBorder { get; }

        private PizzaSize PizzaSizeSmall { get; }
        private PizzaSize PizzaSizeMedium { get; }
        private PizzaSize PizzaSizeBig { get; }

        private Flavor Calabresa { get; }
        private Flavor Marguerita { get; }
        private Flavor Portuguesa { get; }

        private IEnumerable<<PPizzaCustomization> ExtraBacon { get; }
        private IEnumerable<<PPizzaCustomization> WithoutOnion { get; }
        private IEnumerable<<PPizzaCustomization> FilledBorder { get; }

        public PizzaFixture()
        {

            PizzaSizeSmall = new PizzaSize("Pizza pequena", 20.00, 15);
            PizzaSizeMedium = new PizzaSize("Pizza média", 30.00, 20);
            PizzaSizeBig = new PizzaSize("Pizza grande", 40.00, 25);

            Calabresa = new Flavor("Calabresa", 0);
            Marguerita = new Flavor("Marguerita", 0);
            Portuguesa = new Flavor("Portuguesa", 5);

            ExtraBacon = new List<<PPizzaCustomization> { new  PPizzaCustomization { Customization = new Customization("Bacon Extra", 3.00, 0) } };
            WithoutOnion = new List<<PPizzaCustomization> { new  PPizzaCustomization { Customization = new Customization("Sem Cebola", 0.00, 0) } };
            FilledBorder = new List<<PPizzaCustomization> { new  PPizzaCustomization { Customization = new Customization("Borda Recheada", 5.00, 5) } };

            PizzaSmallCalabresa = new Pizza(PizzaSizeSmall, Calabresa, null);
            PizzaMediumMarguerita = new Pizza(PizzaSizeMedium, Marguerita, null);
            PizzaBigPortuguesa = new Pizza(PizzaSizeBig, Portuguesa, null);
            PizzaSmallCalabresaWithExtraBacon = new Pizza(PizzaSizeSmall, Calabresa, ExtraBacon);
            PizzaMediumMargueritaWithoutOnion = new Pizza(PizzaSizeMedium, Marguerita, WithoutOnion);
            PizzaBigPortuguesaFilledBorder = new Pizza(PizzaSizeBig, Portuguesa, FilledBorder);
        }
    }
}
