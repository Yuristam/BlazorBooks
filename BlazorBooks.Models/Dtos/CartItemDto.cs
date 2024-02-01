namespace BlazorBooks.Models.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CartId { get; set; }
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public string BookAuthorName { get; set; }
        public string BookImageURL { get; set; }
        public DateTime DatePublished { get; set; }
        public string Language { get; set; }
        public int CountPages { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
    }
}
