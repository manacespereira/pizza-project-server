using System;
using PizzaProject.Domain.Commands.OrderCommands;
using PizzaProject.Domain.Core;
using PizzaProject.Domain.Entities;
using PizzaProject.Domain.Repositories;

namespace PizzaProject.Domain.CommandHandlers
{
    public class OrderCommandHandler : ICommandHandler<CreateNewOrderCommand, Order>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IOrderRepository orderRepository;

        public OrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.orderRepository = orderRepository;
        }

        public Order Handle(CreateNewOrderCommand command)
        {
            var order = new Order(command.Pizza);

            orderRepository.Add(order);

            unitOfWork.Commit();

            return order;
        }
    }
}
