using Microsoft.AspNetCore.Mvc;
using Alloro.DisasterEmergency.Api.Repositories;
using Alloro.DisasterEmergency.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Alloro.DisasterEmergency.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisastersController : ControllerBase
    {
        private readonly DisasterEmergencyContext _dbContext;

        public DisastersController(DisasterEmergencyContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> NotifyDisaster([FromBody] Disaster disaster)
        {
            await _dbContext.Disaster.AddAsync(disaster);

            await _dbContext.SaveChangesAsync();

            return Created($"api/[controller]/{disaster.DisasterId}", disaster);
        }

        [HttpGet]
        public async Task<IActionResult> GetDisasters()
        {
            return Ok(_dbContext.Disaster
                .Include(d => d.DisasterType)
                .Include(d => d.DisasterLevel)
                .Include(d => d.Resource)
                .ToList());
        }
    }
}