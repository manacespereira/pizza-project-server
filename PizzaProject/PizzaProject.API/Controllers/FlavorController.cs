using Microsoft.AspNetCore.Mvc;
using PizzaProject.Domain.Queries.CustomizationQueries;
using PizzaProject.Domain.Queries.FlavorQueries;
using PizzaProject.Domain.QueryHandlers;

namespace PizzaProject.API.Controllers
{
    [Route("api/v1/flavors")]
    [ApiController]
    public class FlavorController : ControllerBase
    {
        private readonly FlavorQueryHandler flavorQueryHandler;

        public FlavorController(FlavorQueryHandler flavorQueryHandler)
        {
            this.flavorQueryHandler = flavorQueryHandler;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var query = new GetAllFlavorsQuery();
            query.Validate();

            if (query.Invalid) return BadRequest(query.Notifications);

            return Ok(flavorQueryHandler.Handle(query));
        }
    }
}
