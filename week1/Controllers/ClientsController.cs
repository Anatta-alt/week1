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

    public class ClientsController : ControllerBase 
    {
        private readonly IMapper _mapper;
        private List<Client> clientsList = new List<Client>();

        public ClientsController(IMapper mapper)
        {
            clientsList.Add(new Client () {Id=1,UserName="Anatta",Email="Anatta@gmail.com",Password="1234"});
            clientsList.Add(new Client () {Id=2,UserName="Warintorn",Email="Warintorn@gmail.com",Password="2345"});
            clientsList.Add(new Client () {Id=3,UserName="Teerawit",Email="Teerawit@gmail.com",Password="3456"});
            clientsList.Add(new Client () {Id=4,UserName="Nutthaphong",Email="Nutthaphong@gmail.com",Password="4567"});
            clientsList.Add(new Client () {Id=5,UserName="Sattra",Email="Sattra@gmail.com",Password="5678"});
            clientsList.Add(new Client () {Id=6,UserName="Phitcha",Email="Phitcha@gmail.com",Password="4567"});
            clientsList.Add(new Client () {Id=7,UserName="Briboon",Email="Briboon@gmail.com",Password="5678"});
            clientsList.Add(new Client () {Id=8,UserName="Sansaboon",Email="Sansaboon@gmail.com",Password="5678"});
            clientsList.Add(new Client () {Id=9,UserName="Phurich",Email="Phurich@gmail.com",Password="5678"});
            clientsList.Add(new Client () {Id=10,UserName="Parichat",Email="Parichat@gmail.com",Password="5678"});
            this._mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetAllClients(){
            
            var result = _mapper.Map<List<ClientDTO_ToReturn>>(clientsList);
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetClients(int id){

            if(id >= 1 && id <= 10){
            var clientFromGet = clientsList.Where(x => x.Id==id).SingleOrDefault();
            var result = _mapper.Map<ClientDTO_ToReturn>(clientFromGet);
            return Ok(result);
            }else {
                return NotFound("ID Between 1-10");
            }
        }
    }
}