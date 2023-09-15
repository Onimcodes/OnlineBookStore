using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Entity
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}
