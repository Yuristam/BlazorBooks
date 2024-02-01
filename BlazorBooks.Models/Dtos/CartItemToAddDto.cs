namespace BlazorBooks.Models.Dtos
{
    public class CartItemToAddDto
    {
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}
