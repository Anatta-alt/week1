using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using week1.Models;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        public int Price { get; private set; }

        [HttpGet("SpecCar")]
        public IActionResult SpecCar(string Brand, string Model, int Year)
        {
            
    


            var CarList = new List<Car>();


            CarList.Add(new Car()
            {
                Id = 001,
                Brand = "Toyota",
                Model = "Altis",
                Year = 2012,
                Fuel = "Gasohol",
                Gear = "Auto",
                Color = "white",
                Price = 302000,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 002,
                Brand = "Honda",
                Model = "Civic",
                Year = 2015,
                Fuel = "Gasohol",
                Gear = "Auto",
                Color = "Black",
                Price = 408900,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 003,
                Brand = "Nisson",
                Model = "Almera",
                Year = 2014,
                Fuel = "Gasohol",
                Gear = "Manual",
                Color = "Red",
                Price = 270800,
                Issell = false,
            });

            CarList.Add(new Car()
            {
                Id = 004,
                Brand = "Ford",
                Model = "Ranger",
                Year = 2018,
                Fuel = "Desel",
                Gear = "Manual",
                Color = "Orange",
                Price = 450000,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 005,
                Brand = "Mazda",
                Model = "Bt-50",
                Year = 2005,
                Fuel = "Desel",
                Gear = "Auto",
                Color = "white",
                Price = 240890,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 006,
                Brand = "Benz",
                Model = "E220",
                Year = 2015,
                Fuel = "Gasohol",
                Gear = "Auto",
                Color = "Black",
                Price = 990000,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 007,
                Brand = "Subaru",
                Model = "Forester",
                Year = 2016,
                Fuel = "Gasohol",
                Gear = "Auto",
                Color = "Blue",
                Price = 769000,
                Issell = false,
            });

            CarList.Add(new Car()
            {
                Id = 008,
                Brand = "Mazda",
                Model = "Tribute",
                Year = 2004,
                Fuel = "Gasohol",
                Gear = "Auto",
                Color = "Black",
                Price = 108900,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 009,
                Brand = "Isuzu",
                Model = "V-Cross",
                Year = 2014,
                Fuel = "Desel",
                Gear = "Manual",
                Color = "Red",
                Price = 769000,
                Issell = true,
            });

            CarList.Add(new Car()
            {
                Id = 010,
                Brand = "Isuzu",
                Model = "Mu-x",
                Year = 2017,
                Fuel = "Desel",
                Gear = "Auto",
                Color = "White",
                Price = 769000,
                Issell = true,
            });

            var query = CarList;

            //TODO:Validation
            if(Brand != null){
                query = query.Where(x => x.Year >= Year && x.Year <= Year).ToList();
            } else {
                return NotFound("Brand valid");
            }

            if(Model != null){
                query = query.Where(x => x.Model.Contains(Model)).ToList();
            } else {
                return NotFound("Model valid");
            }

            if(Year >= 1800 && Year <= 2500){
                query = query.Where(x => x.Year >= Year && x.Year <= Year).ToList();
            } else {
                return NotFound("Year valid");
            }

            // if(Fuel != null){
            //     query = query.Where(x => x.Fuel.Contains(Fuel)).ToList();
            // } else {
            //     return NotFound("Fuel valid");
            // }

            // if(Gear != null){
            //    query = query.Where(x => x.Gear.Contains(Gear)).ToList();
            // } else {
            //     return NotFound("Gear valid");
            // }

            // if(Price != 0){
            //     query = query.Where(x => x.Price == Price).ToList();
            // } else {
            //     return NotFound("Price valid");
            // }


            // var searchResult = CarList.Where(x => x.Price >= 200000 && x.Price <= 2000000 ).ToList();

            return Ok(query);
        }
    }
}