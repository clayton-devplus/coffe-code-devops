using CoffeCodeDevops.Data.Dto;
using CoffeCodeDevops.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoffeCodeDevops.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TestController : Controller
    {
        private readonly TestTableRepository _tableRepository;
        public TestController(TestTableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        [HttpGet("GetRegs")]
        public async Task<IActionResult> GetRegs()
        {
            var tables = await _tableRepository.GetRegs();
            return Ok(tables);
        }


        [HttpPost("CreateRegs")]
        public async Task<IActionResult> CreateRegs([FromBody] TestTableDto table)
        {
            await _tableRepository.CreateReg(table);
            return Ok(table);
        }
    }
}
