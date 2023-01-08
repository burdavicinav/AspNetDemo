using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    [Table("cart")]
    public class Cart
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public List<CartItem> Items { get; set; }
    }
}
