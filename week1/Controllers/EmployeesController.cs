using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using week1.DTOs;
using week1.Models;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController  : ControllerBase
    {
        private readonly IMapper _mapper;
        private List<Employee> employeesList = new List<Employee>();

        public EmployeesController(IMapper mapper)
        {
            employeesList.Add(new Employee () {Id=001,FirstName="Anatta",LastName="Nonthasri",Age=21,IdCard="1234"});
            employeesList.Add(new Employee () {Id=002,FirstName="Warintorn",LastName="Thurachat",Age=22,IdCard="2345"});
            employeesList.Add(new Employee () {Id=003,FirstName="Teerawit",LastName="Ruksachat",Age=23,IdCard="3456"});
            employeesList.Add(new Employee () {Id=004,FirstName="Nutthaphong",LastName="Chutakun",Age=24,IdCard="4567"});
            employeesList.Add(new Employee () {Id=005,FirstName="Sattra",LastName="Sitthithai",Age=25,IdCard="5678"});
            employeesList.Add(new Employee () {Id=006,FirstName="Phitcha",LastName="Phiphatphatthananon",Age=26,IdCard="5678"});
            employeesList.Add(new Employee () {Id=007,FirstName="Briboon",LastName="Sawasmongkon",Age=27,IdCard="5678"});
            employeesList.Add(new Employee () {Id=008,FirstName="Sansaboon",LastName="Ounat",Age=28,IdCard="5678"});
            employeesList.Add(new Employee () {Id=009,FirstName="Phurich",LastName="Majchamek",Age=29,IdCard="5678"});
            employeesList.Add(new Employee () {Id=010,FirstName="Parichat",LastName="Wongkom",Age=30,IdCard="5678"});
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllEmployees(){
            
            var result = _mapper.Map<List<EmployeeDTO_ToReturn>>(employeesList);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id){

            if(id >=1 && id <= 10)
            {
            var employeeFromGet = employeesList.Where(x => x.Id==id).SingleOrDefault();
            var result = _mapper.Map<EmployeeDTO_ToReturn>(employeeFromGet);
            return Ok(result);
            }else {
                
                return NotFound("ID Between 1-10");
            }
        }

        // [HttpPost("/employee")]
        // public IActionResult AddEmployee(Employee employee){
            
        //     return Ok(employee);
        // }
    }
}