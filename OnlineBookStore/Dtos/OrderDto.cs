using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
