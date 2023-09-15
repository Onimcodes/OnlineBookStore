using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Data
{
    public interface IOrderRepository
    {
        Task<Order> AddOrder(Order order);
    }
}
