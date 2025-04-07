using CodingTest.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class CharactersController(_DBEntities _db) : ControllerBase
    {


        [HttpGet]
        [Route("[controller]/get")]
        public IActionResult Get()
        {

            return Ok(_db.Characters);
        }
        [HttpGet]
        [Route("[controller]/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();

        }
        [HttpPost]
        [Route("[controller]/post")]
        public IActionResult Post(Character character)
        {
            return Ok();

        }
        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok();
        }
    }
}
