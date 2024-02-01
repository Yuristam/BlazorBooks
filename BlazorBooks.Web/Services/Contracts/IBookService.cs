using BlazorBooks.Models.Dtos;

namespace BlazorBooks.Web.Services.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetBooks();
    }
}
