using Demo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProduct([RouteData]string name)
        {
            ViewState["ProductName"] = name;
            shopOilEntities ctx = new shopOilEntities();
            return ctx.Products.Where(a => a.Name == name);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = ViewState["ProductName"].ToString();
            shopOilEntities ctx = new shopOilEntities();
            Product product= ctx.Products.Where(a => a.Name == name).First() ;
            var getCart = Session["cart"];
            if (getCart == null)
            {
                Cart cart1 = new Cart();
                cart1.AddToCart(product, 1);
                Session["cart"] = cart1;

            }
            var Cart = (Session["cart"] as Cart);
            Cart.AddToCart(product, 1);
            Session["cart"] = Cart;

        }
    }
}