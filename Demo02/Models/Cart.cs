using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo02.Models
{
    public class Cart
    {

        private List<CartLine> CartLines { get; set; }

        public void AddToCart(Product product,int qunatity)
        {
            this.CartLines.Add(new CartLine() {Produc= product, Quantity=qunatity });
        }

        public int GetTotal()
        {
            return 0;
        }

        public IEnumerable<CartLine> GetCartLines() => CartLines;

    }
}