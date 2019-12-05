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
    public class DivisibleController : ControllerBase
    {
        // GET: api/Divisible
        [HttpGet]
        public IActionResult Get(int value1, int value2)
        {
            try
            {
                if (value1 % value2 == 0)
                {
                    return Ok(true);
                }
                else
                {
                    return Ok(false);
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
