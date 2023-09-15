using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Order> AddOrder(Order order)
        {
            appDbContext.Orders.Add(order);   
            await appDbContext.SaveChangesAsync();  
            return order;   
        }
    }
}
