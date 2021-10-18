namespace Demo02.Models
{
    public class CartService
    {
        private static Cart cart;
        private  CartService()
        {

        }

        public  Cart GetCart()
        {
            if (  ==null)
            {
                cart = new Cart();
               
            }
            return cart;
        }
    }
}