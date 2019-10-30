using System;
using Microsoft.AspNetCore.Mvc;
using PizzaProject.Domain.CommandHandlers;
using PizzaProject.Domain.Commands.OrderCommands;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.QueryHandlers;

namespace PizzaProject.API.Controllers
{
    [Route("api/v1/pizza-sizes")]
    [ApiController]
    public class PizzaSizeController : ControllerBase
    {
        private readonly PizzaSizeQueryHandler pizzaSizeQueryHandler;

        public PizzaSizeController(PizzaSizeQueryHandler pizzaSizeQueryHandler)
        {
            this.pizzaSizeQueryHandler = pizzaSizeQueryHandler;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var query = new GetAllPizzaSizesQuery();
            query.Validate();

            if (query.Invalid) return BadRequest(query.Notifications);

            return Ok(pizzaSizeQueryHandler.Handle(query));
        }
    }
}
