using LibraryManagement.DTOs;
using LibraryManagement.Exceptions;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            try
            {
                return Ok(_service.GetAllBooks());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{ISBN}")]
        public IActionResult GetBook(string ISBN)
        {
            try
            {
                return Ok(_service.GetBookById(ISBN));
            }
            catch (BookNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] BookDTO bookDTO)
        {
            try
            {

                return Ok();
            }
            catch (InvalidBookException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{ISBN}")]
        public IActionResult UpdateBook(string ISBN, [FromBody] BookDTO bookDTO)
        {
            try
            {
                _service.UpdateBook(ISBN, bookDTO);
                return NoContent();
            }
            catch (BookNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidBookException ex)
            {
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpDelete]
        public IActionResult DeleteBook(string ISBN)
        {
            try
            {
                _service.DeleteBookById(ISBN);
                return NoContent();
            }
            catch (BookNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
