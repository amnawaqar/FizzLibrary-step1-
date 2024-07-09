using FizzLibrary.Server.Model;
using FizzLibrary.Shared.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserValue userValue) : ControllerBase
    {
        [HttpPost]
        public IActionResult Save([FromBody] UserValueDto userValueDto)
        {
            if (userValueDto == null)
            {
                return BadRequest("Invalid input data");
            }

            var createdEntry = userValue.Save(userValueDto);
            return createdEntry !=null ?  Ok(createdEntry): BadRequest("Error saving the data") ;

        }
    }
}
