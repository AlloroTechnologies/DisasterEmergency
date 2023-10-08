using Microsoft.AspNetCore.Mvc;
using Alloro.DisasterEmergency.Api.Repositories;
using Alloro.DisasterEmergency.Api.Models;

namespace Alloro.DisasterEmergency.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParamsController : ControllerBase
    {
        private readonly DisasterEmergencyContext _dbContext;

        public ParamsController(DisasterEmergencyContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetParams()
        {
            return Ok(new Params()
            {
                DisasterLevels = _dbContext.DisasterLevel.OrderBy(l => l.Priority).ToList(),
                DisasterTypes = _dbContext.DisasterType.ToList(),
                Resources = _dbContext.Resource.ToList()
            });
        }
    }
}