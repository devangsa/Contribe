using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContribeBookStore.Models;

namespace ContribeBookStore.Models
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}