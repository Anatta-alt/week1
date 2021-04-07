using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using week1.DTOs;
using week1.Models;
namespace week1.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private List<Customer> customersList = new List<Customer>();

        public CustomersController(IMapper mapper)
        {
            customersList.Add(new Customer () {Id=1,FirstName="A",BankAccount="1234",ATMCode="1234",Balance=100});
            customersList.Add(new Customer () {Id=2,FirstName="B",BankAccount="2345",ATMCode="2345",Balance=200});
            customersList.Add(new Customer () {Id=3,FirstName="C",BankAccount="4567",ATMCode="3456",Balance=300});
            customersList.Add(new Customer () {Id=4,FirstName="D",BankAccount="7891",ATMCode="4567",Balance=400});
            customersList.Add(new Customer () {Id=5,FirstName="E",BankAccount="3456",ATMCode="5678",Balance=500});
            this._mapper = mapper;
        }
        // [HttpGet] แสดงผลแบบ no mapper
        // public IActionResult GetAllCustomers(){
        //     return Ok(customersList);
        // }

        [HttpGet]
        public IActionResult GetAllCustomers(){
            
            var result = _mapper.Map<List<CustomerDTO_ToReturn>>(customersList);
            return Ok(result);
        }
        // [HttpGet("{id}")]  // url/api/Customer/1
        // public IActionResult GetCustomer(int id) {
        //     var result = customerList.Where(x => x.Id == id).SingleOrDefault();

        //     var resultToReturn = new CustomerDTO_ToReturn();
        //     //No AutoMapper
        //     resultToReturn.Id = result.Id;
        //     resultToReturn.FirstName = result.FirstName;
        //     resultToReturn.BankAccount = result.BankAccount;
        //     resultToReturn.Balance = result.Balance;

        //     return Ok(resultToReturn);
        // }
         [HttpGet("{id}")]
        public IActionResult GetCustomer(int id){

            var customerFromGet = customersList.Where(x => x.Id==id).SingleOrDefault();
            var result = _mapper.Map<CustomerDTO_ToReturn>(customerFromGet);
            return Ok(result);
        }
    }
}