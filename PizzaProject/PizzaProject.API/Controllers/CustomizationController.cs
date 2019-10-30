using System;
using Microsoft.AspNetCore.Mvc;
using PizzaProject.Domain.CommandHandlers;
using PizzaProject.Domain.Commands.OrderCommands;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.QueryHandlers;

namespace PizzaProject.API.Controllers
{
    [Route("api/v1/customizations")]
    [ApiController]
    public class CustomizationController : ControllerBase
    {
        private readonly CustomizationQueryHandler customizationQueryHandler;

        public CustomizationController(CustomizationQueryHandler customizationQueryHandler)
        {
            this.customizationQueryHandler = customizationQueryHandler;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var query = new GetAllCustomizationsQuery();

            query.Validate();

            if (query.Invalid) return BadRequest(query.Notifications);

            return Ok(customizationQueryHandler.Handle(query));
        }
    }
}
