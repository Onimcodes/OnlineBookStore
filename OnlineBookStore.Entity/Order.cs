using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        [NotMapped] 
        public decimal TotalAmount { get; set; }
    }
}
