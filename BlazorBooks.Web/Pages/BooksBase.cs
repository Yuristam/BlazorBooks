using BlazorBooks.Models.Dtos;
using BlazorBooks.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace BlazorBooks.Web.Pages
{
    public class BooksBase : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }

        public IEnumerable<BookDto> Books { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Books = await BookService.GetBooks();
        }

        protected IOrderedEnumerable<IGrouping<int, BookDto>> GetGroupedBooksByGenre()
        {
            return from book in Books
                   group book by book.GenreId into bookByGenreGroup
                   orderby bookByGenreGroup.Key
                   select bookByGenreGroup;
        }

        protected string GetGenreName(IGrouping<int, BookDto> groupedBookDtos) 
        {
            return groupedBookDtos.FirstOrDefault(pg => pg.GenreId == groupedBookDtos.Key).GenreName;
        }

    }
}
