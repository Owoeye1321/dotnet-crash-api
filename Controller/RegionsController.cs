using Microsoft.AspNetCore.Mvc;
using NzedWalks.Data;
using NzedWalks.Model.Domain;

namespace NzedWalks.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        public readonly NZedWalksDbContext _dbContext;

        public RegionsController(NZedWalksDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = _dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}