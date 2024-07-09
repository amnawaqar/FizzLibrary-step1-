using FizzLibrary.Shared.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace FizzLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController(FizzBuzzStrategy _fizzBuzzStrategy) : ControllerBase
    {
        [HttpGet("{number}")]
        public IActionResult GenerateFizzBuzz(int number)
        {
            if (number >=1 && number<=1000)
            {
                var result = _fizzBuzzStrategy.GenerateFizzBuzz(number);
                return Ok(result);
               
            }
            return BadRequest("Number must be between 1 and 1000.");
        }
    }
}
