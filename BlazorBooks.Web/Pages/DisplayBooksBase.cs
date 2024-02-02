using BlazorBooks.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorBooks.Web.Pages
{
    public class DisplayBooksBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<BookDto> Books { get; set; }
    }
}
