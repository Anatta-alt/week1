using System.Collections.Generic;
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

    public class HousesController : ControllerBase

    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public HousesController(IMapper mapper, AppDBContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }

        [HttpGet]

        public IActionResult GetHouse(){

            var houses = _db.Houses.ToList();
            var result = _mapper.Map<List<HouseDTO_ToReturn>>(houses);
            return Ok(result);

        }

        [HttpPost]
        public IActionResult PostHouse(HouseDTO_ToCreate input){
            var house =  new House();
            
            house.Number = input.Number;
            house.RoadName = input.RoadName;
            house.HouseDistric = input.HouseDistric;
            house.City = input.City;

            _db.Houses.Add(house);
            _db.SaveChanges();

            var result = _mapper.Map<HouseDTO_ToReturn>(house);
            return Ok(result);
            
        }
    }
}