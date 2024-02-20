using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Models;
using OnlineStore.Core;

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public TestController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetTests()
        {
            var testData = _dbContext.Tests.ToList();
            return Ok(testData);
        }

        // Test submodule 
        //[HttpGet("{testId:int}")]
        //public async Task<ActionResult<Test>> GetTestByIdAsync(int testId)
        //{
        //    var test = await _dbContext.Tests.FindAsync(testId);
        //    return test;
        //}

        [HttpPost]
        public IActionResult Createq([FromBody] Test test)
        {
            _dbContext.Tests.Add(test);
            _dbContext.SaveChanges();
            return Created("", test);
        }
    }
}
