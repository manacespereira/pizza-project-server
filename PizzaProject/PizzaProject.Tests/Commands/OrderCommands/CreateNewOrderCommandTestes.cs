using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using PizzaProject.Domain.CommandHandlers;
using PizzaProject.Domain.Commands.OrderCommands;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.QueryHandlers;
using PizzaProject.Domain.Repositories;
using PizzaProject.Tests.Fixtures;
using Xunit;

namespace PizzaProject.Tests.Commands.OrderCommands
{
    public class CreateNewOrderCommandTestes : IClassFixture<PizzaFixture>
    {
        private readonly Mock<IOrderRepository> orderRepository;
        private readonly PizzaFixture pizzaFixture;
        private readonly OrderCommandHandler orderCommandHandler;
        private readonly OrderQueryHandler orderQueryHandler;

        public CreateNewOrderCommandTestes(PizzaFixture pizzaFixture)
        {
            this.pizzaFixture = pizzaFixture;
            orderRepository = new Mock<IOrderRepository>();
            var uOw = new Mock<IUnitOfWork>();
            orderCommandHandler = new OrderCommandHandler(orderRepository.Object, uOw.Object);
            orderQueryHandler = new OrderQueryHandler(orderRepository.Object);
        }

        [Fact]
        void Should_Calculate_Total_Price_And_TimeToPrepare_When_Pizza_Is_Simple_And_Small()
        {
            var command = new CreateNewOrderCommand(pizzaFixture.PizzaSmallCalabresa);

            var result = orderCommandHandler.Handle(command);

            Assert.NotNull(result);
            Assert.Equal(20, result.TotalPrice);
            Assert.Equal(15, result.TimeToPrepare);
        }

        [Fact]
        void Should_Returns_2_Orders_When_Call_Query_To_Get_All_Orders()
        {
            var query = new GetAllOrdersQuery();

            orderRepository.Setup(x => x.FindAll()).Returns(new List<Order> {
                new Order(pizzaFixture.PizzaSmallCalabresa),
                new Order(pizzaFixture.PizzaSmallCalabresaWithExtraBacon),
            });

            var result = orderQueryHandler.Handle(query);

            Assert.Equal(2, result.Count());
        }
    }
}
