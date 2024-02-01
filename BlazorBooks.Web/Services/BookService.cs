using BlazorBooks.Models.Dtos;
using BlazorBooks.Web.Services.Contracts;
using System.Net.Http.Json;

namespace BlazorBooks.Web.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<BookDto>> GetBooks()
        {
            try
            {
                var books = await _httpClient.GetFromJsonAsync<IEnumerable<BookDto>>("api/Book");
                return books;
            }
            catch (Exception)
            {
                // Log exception
                throw;
            }
        }
    }
}
