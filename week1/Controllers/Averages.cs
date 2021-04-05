using System;
using Microsoft.AspNetCore.Mvc;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Averages : ControllerBase
    {
         [HttpPost]
        public IActionResult Average(float match,float eng,float scient) {
            float sum = (match+eng+scient)/3;
            var result = "เกรดเฉลี่ย : " + Math.Round(sum,2,MidpointRounding.AwayFromZero);  //Round(55, 2, MidpointRounding.AwayFromZero);
            return Ok(result);
        }
    }
}