using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using week1.Models;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string name) {
            var result = "Hello" + name;
            return Ok(result);
        }

        [HttpGet ("News")]
        public IActionResult GetNews(string name) {
            var result = "Hello" + name;
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(int id,string name) {
            var result = id.ToString() + "" + name;
            return Ok(result);
        }
        [HttpGet("Now")]
        public IActionResult GetNow() {
            var result = DateTime.Now;
            return Ok(result);
        }
        [HttpPost("PostFromModel")]
        public IActionResult PostFromModel(Book input) {
            var result = input;
            return Ok(result);
        }

        [HttpGet("GetBooks")]
        public IActionResult GetBooks() {
            
            var bookList = new List<Book>();

            // Shothand
            bookList.Add(new Book() {Id = 1,Name = "Salmon",Price = 20,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 2,Name = "Thuna",Price = 21,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 3,Name = "coke",Price = 22,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 4,Name = "Est",Price = 23,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 5,Name = "burger",Price = 24,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 6,Name = "KFC",Price = 25,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 7,Name = "MC",Price = 26,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 8,Name = "Pizza",Price = 27,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 9,Name = "Donut",Price = 28,CreatedDate = DateTime.Now});

            //Add
            var baconBook = new Book() { Id = 10,Name = "Salmon",Price = 30,CreatedDate = DateTime.Now};

            bookList.Add(baconBook);


            return Ok(bookList);
        }


        [HttpGet("SearchBook")]
        public IActionResult SearchBook(string searchText) {
            
            var bookList = new List<Book>();

            // Shothand
            bookList.Add(new Book() {Id = 1,Name = "Salmon",Price = 20,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 2,Name = "Thuna",Price = 21,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 3,Name = "coke",Price = 22,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 4,Name = "Est",Price = 23,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 5,Name = "burger",Price = 24,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 6,Name = "KFC",Price = 25,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 7,Name = "MC",Price = 26,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 8,Name = "Pizza",Price = 27,CreatedDate = DateTime.Now});
            bookList.Add(new Book() {Id = 9,Name = "Donut",Price = 28,CreatedDate = DateTime.Now});
            bookList.Add(new Book() { Id = 10,Name = "Salmon",Price = 30,CreatedDate = DateTime.Now});

            var searchResult = bookList.Where(x => x.Name.Contains(searchText)).ToList();

            return Ok(searchResult);
        }
    }
}