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

    public class ClientsController : ControllerBase 
    {
        private readonly IMapper _mapper;
        private readonly AppDBContext _db;

        public ClientsController(IMapper mapper, AppDBContext db)
        {
            // clientsList.Add(new Client () {Id=1,UserName="Anatta",Email="Anatta@gmail.com",Password="1234"});
            // clientsList.Add(new Client () {Id=2,UserName="Warintorn",Email="Warintorn@gmail.com",Password="2345"});
            // clientsList.Add(new Client () {Id=3,UserName="Teerawit",Email="Teerawit@gmail.com",Password="3456"});
            // clientsList.Add(new Client () {Id=4,UserName="Nutthaphong",Email="Nutthaphong@gmail.com",Password="4567"});
            // clientsList.Add(new Client () {Id=5,UserName="Sattra",Email="Sattra@gmail.com",Password="5678"});
            // clientsList.Add(new Client () {Id=6,UserName="Phitcha",Email="Phitcha@gmail.com",Password="4567"});
            // clientsList.Add(new Client () {Id=7,UserName="Briboon",Email="Briboon@gmail.com",Password="5678"});
            // clientsList.Add(new Client () {Id=8,UserName="Sansaboon",Email="Sansaboon@gmail.com",Password="5678"});
            // clientsList.Add(new Client () {Id=9,UserName="Phurich",Email="Phurich@gmail.com",Password="5678"});
            // clientsList.Add(new Client () {Id=10,UserName="Parichat",Email="Parichat@gmail.com",Password="5678"});
            this._mapper = mapper;
            this._db = db;
        }
        
        [HttpGet]
        public IActionResult GetAllClients(){
            
            var client = _db.Clients.ToList();
            var result = _mapper.Map<List<ClientDTO_ToReturn>>(client);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult PostClient(ClientDTO_ToCreate input){
            var client = new Client();
            client.UserName=input.UserName;
            client.Email=input.Email;
            client.Password = input.Password;

            _db.Clients.Add(client);
            _db.SaveChanges();

            var resultToReturn = _mapper.Map<ClientDTO_ToReturn>(client);
            return Ok(resultToReturn);

        }

        [HttpGet("{id}")]
        public IActionResult GetClient (int id){
            
            
            if(id != 0){
            var client = _db.Clients.SingleOrDefault(x => x.Id==id);
            var result = _mapper.Map<ClientDTO_ToReturn>(client);
            return Ok(result);
            }else {
                return NotFound("ID Requite");
            }
        }

        

        // [HttpGet("/list")]
        // public IActionResult GetClientList(int taaaaaa){
        //     var client = _db.Clients.AsQueryable();

        //     // if(searchClient.Id != 0){
        //     // client = client.Where(x => x.Id == searchClient.Id).ToList().AsQueryable();
        //     // }
            
        //     // if(searchClient.UserName != null){
        //     //     client = client.Where(x => x.UserName.Contains(searchClient.UserName)).ToList().AsQueryable();
        //     // }
        //     return Ok(taaaaaa);
        // }
    }
}