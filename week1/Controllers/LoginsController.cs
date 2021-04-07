using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using week1.Data;
using week1.DTOs;
using week1.Models;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public LoginsController(IMapper mapper, AppDBContext db)        
        {
            this._mapper = mapper;
            this._db = db;
        }

        [HttpGet]
        public IActionResult GetLogin(){
            var login = _db.Logins.ToList();
            return Ok(login);
        }
        

        [HttpPost]
        public IActionResult PostLogin(LoginDTO_ToCreate input){
            var login = new Login();

            login.Username=input.Username;
            login.Email=input.Email;
            login.Password=input.Password;

            _db.Logins.Add(login);
            _db.SaveChanges();

            var resultToReturn = _mapper.Map<LoginDTO_ToReturn>(login);
            return Ok(resultToReturn);
        }
    }
}   