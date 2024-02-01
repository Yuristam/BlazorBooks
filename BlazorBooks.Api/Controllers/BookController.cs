using Microsoft.AspNetCore.Mvc;
using BlazorBooks.Api.Repositories.Contracts;
using BlazorBooks.Models.Dtos;
using BlazorBooks.Api.Extensions;

namespace BlazorBooks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetItems()
        {
            try
            {
                var books = await _bookRepository.GetBooks();
                var genres = await _bookRepository.GetGenres();

                if (books == null || genres == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = books.ConvertToDto(genres);

                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
