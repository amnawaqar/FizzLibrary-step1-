using FizzLibrary.Shared.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController(IFizzBuzz fizzBuzz) : ControllerBase
    {
        
        [HttpGet("{number}")]
        public IActionResult GenerateFizzBuzz(int number)
        {
            if (number <1 || number>1000)
            {
                return BadRequest("Number must be between 1 and 1000.");
            }
            var result = fizzBuzz.GenerateFizzBuzz(number);
            return Ok(result);
        }
    }
}
