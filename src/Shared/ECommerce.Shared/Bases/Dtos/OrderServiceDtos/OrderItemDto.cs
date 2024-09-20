namespace ECommerce.Shared.Bases.Dtos.OrderServiceDtos
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
