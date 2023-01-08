using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    [Table("cartitem")]
    public class CartItem
    {
        public int Id { get; set; }

        public virtual Car Car { get; set; }

        public int Price { get; set; }

        public int Qty { get; set; }
    }
}
