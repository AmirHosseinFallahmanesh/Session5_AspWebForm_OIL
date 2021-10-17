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
            shopOilEntities ctx = new shopOilEntities();
            return ctx.Products.Where(a => a.Name == name);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}