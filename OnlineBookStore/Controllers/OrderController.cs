using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Api.Data;
using OnlineBookStore.Api.Dtos;
using OnlineBookStore.Api.Services;
using OnlineBookStore.Entity;

namespace OnlineBookStore.Api.Controllers
{

    [Route("api/[controller]")]

    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;
        private readonly IMessageProducer messageProducer;

        public OrderController(IOrderRepository orderRepository, IMessageProducer messageProducer)
        {
            this.orderRepository = orderRepository;
            this.messageProducer = messageProducer;
        }
        [HttpPost("place-order")]
        public async Task<IActionResult> PlaceOrder(OrderDto orderDto)
        {

            if (orderDto == null)
            {
                return BadRequest("Invalid order data.");
            }

            // Create an Order object based on the OrderDto
            var order = new Order
            {
                Id = orderDto.Id,   
                OrderDate = DateTime.Now,
                OrderItems = orderDto.OrderItems // Assuming OrderDto contains order item details
            };

            //add the order to the orders table for
            await orderRepository.AddOrder(order);


            // Send a message to the messaging system to notify the Order Processing Service

            messageProducer.SendingMessage<Order>(order);
            // You can return a success response or some confirmation to the client
            return Ok("Order placed successfully.");

        }
    }
}
