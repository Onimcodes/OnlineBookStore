using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Api.Data;
using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetBooks()
        {
            try
            {
                return Ok(await bookRepository.GetBooks());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            try
            {
                var result = await bookRepository.GetBook(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retreiving data from database");
            }
        }
    }
}
