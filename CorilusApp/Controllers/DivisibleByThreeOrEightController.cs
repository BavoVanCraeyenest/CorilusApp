using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorilusApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisibleByThreeOrEightController : ControllerBase
    {
        // GET: api/DivisibleByThreeOrEight
        [HttpGet]
        public IActionResult Get(int value)
        {
            try
            {
                if (value % 3 == 0 && value % 8 == 0)
                {
                    return Ok("Het getal is deelbaar door 3 en door 8");
                }
                else if (value % 3 == 0)
                {
                    return Ok("Het getal is deelbaar door 3");
                }
                else if (value % 8 == 0)
                {
                    return Ok("Het getal is deelbaar door 8");
                }
                return Ok("Het getal is niet deelbaar door 3 of 8");
            } catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
