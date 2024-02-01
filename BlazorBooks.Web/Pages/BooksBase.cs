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
    }
}
