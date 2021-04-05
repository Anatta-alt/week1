using Microsoft.AspNetCore.Mvc;

namespace week1.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class Works1 : ControllerBase
    {
         [HttpPost]
         public IActionResult Grade(int match,int eng,int scient) {
            var average = (match+eng+scient)/3;

            if(average > 80 && average <= 100) {
                return Ok("คะแนนของคุณ"+average+"Grade A");
            }else if(average > 70 && average < 80){
                return Ok("คะแนนของคุณ"+average+"Grade B");
            }else if(average > 60 && average < 70){
                return Ok("คะแนนของคุณ"+average+"Grade C");
            }else if(average > 50 && average < 60){
                return Ok("คะแนนของคุณ"+average+"Grade D");
            }else{
                return Ok("F");
            }
         }
    }
}