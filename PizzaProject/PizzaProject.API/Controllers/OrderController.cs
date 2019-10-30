using System;
using Microsoft.AspNetCore.Mvc;
using PizzaProject.Domain.CommandHandlers;
using PizzaProject.Domain.Commands.OrderCommands;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.QueryHandlers;

namespace PizzaProject.API.Controllers
{
    [Route("api/v1/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderQueryHandler orderQueryHandler;
        private readonly OrderCommandHandler orderCommandHandler;

        public OrderController(OrderCommandHandler orderCommandHandler, OrderQueryHandler orderQueryHandler)
        {
            this.orderQueryHandler = orderQueryHandler;
            this.orderCommandHandler = orderCommandHandler;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var query = new GetAllOrdersQuery();
            query.Validate();

            if (query.Invalid) return BadRequest(query.Notifications);

            return Ok(orderQueryHandler.Handle(query));
        }


        [HttpPost]
        public IActionResult Post([FromBody] CreateNewOrderCommand command)
        {
            command.Validate();

            if (command.Invalid)
                return BadRequest(command.Notifications);

            var commandResult = orderCommandHandler.Handle(command);

            return Ok(commandResult);
        }
    }
}
