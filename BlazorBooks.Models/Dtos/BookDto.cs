namespace BlazorBooks.Models.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string ImageURL { get; set; }
        public DateTime DatePublished { get; set; }
        public string Language { get; set; }
        public int CountPages { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
