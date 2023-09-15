using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Entity
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal UnitPrice { get; set; }

        //public int Quantity { get; set; }

    }
}
