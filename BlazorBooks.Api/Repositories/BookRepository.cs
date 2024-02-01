using BlazorBooks.Api.Data;
using BlazorBooks.Api.Entities;
using BlazorBooks.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BlazorBooks.Api.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BlazorBooksDbContext _blazorBooksDbContext;

        public BookRepository(BlazorBooksDbContext blazorBooksDbContext)
        {
            _blazorBooksDbContext = blazorBooksDbContext;
        }

        public Task<Book> GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            var books = await _blazorBooksDbContext.Books.ToListAsync();

            return books;
        }

        public async Task<Genre> GetGenre(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Genre>> GetGenres()
        {
            var genres = await _blazorBooksDbContext.Genres.ToListAsync();

            return genres;
        }
    }
}
