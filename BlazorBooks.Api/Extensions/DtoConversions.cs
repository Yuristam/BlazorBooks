using BlazorBooks.Api.Entities;
using BlazorBooks.Models.Dtos;

namespace BlazorBooks.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<BookDto> ConvertToDto(this IEnumerable<Book> books,
                                                            IEnumerable<Genre> genres)
        {
            return (from book in books
                    join genre in genres
                    on book.GenreId equals genre.Id
                    select new BookDto
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Description = book.Description,
                        AuthorName = book.AuthorName,
                        ImageURL = book.ImageURL,
                        DatePublished = book.DatePublished,
                        Language = book.Language.ToString(),
                        CountPages = book.CountPages,
                        Price = book.Price,
                        GenreId = book.GenreId,
                        GenreName = genre.GenreName
                    }).ToList();
        }
    }
}
