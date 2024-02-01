using BlazorBooks.Api.Entities;

namespace BlazorBooks.Api.Repositories.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<IEnumerable<Genre>> GetGenres();
        Task<Book> GetBook(int id);
        Task<Genre> GetGenre(int id);
    }
}
