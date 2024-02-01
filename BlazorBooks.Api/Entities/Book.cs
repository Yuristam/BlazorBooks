using BlazorBooks.Api.Enums;

namespace BlazorBooks.Api.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string ImageURL { get; set; }
        public DateTime DatePublished { get; set; }
        public Language Language { get; set; }
        public int CountPages { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }
    }
}
