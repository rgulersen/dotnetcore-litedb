using dotnetcore_litedb.Models;
using dotnetcore_litedb.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_litedb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StakeItemController : ControllerBase
    {
        private readonly ILogger<StakeItemController> _logger;
        private readonly IStakeItemService _stakeItemService;

        public StakeItemController(IStakeItemService stakeItemService, ILogger<StakeItemController> logger)
        {
            _stakeItemService = stakeItemService;
            _logger = logger;
        }



        [HttpGet(Name = "stake/items")]
        public IActionResult GetAll()
        {
            return Ok(_stakeItemService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _stakeItemService.FindById(id);
            if (item == null) return NotFound();
            return Ok(item);
        }


        [HttpPost]
        public IActionResult CreateItem([FromBody] StakeItem item)
        {
            _stakeItemService.Add(item);
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }
    }
}
