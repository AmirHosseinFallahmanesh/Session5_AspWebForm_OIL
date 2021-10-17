using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            shopOilEntities ctx = new shopOilEntities();
            Product product = new Product();
            product.Name = NameTextBox.Text;
            product.Desciption = DetailTextBox.Text;
            product.Price = int.Parse(PriceTextBox.Text);

            if (FileUpload1.HasFile)
            {
              
                try
                {
                    Guid guid = Guid.NewGuid();
                    string name = guid.ToString() + ".jpg";
                    FileUpload1.SaveAs(@"C:\Users\amirihoseein\Desktop\Session5_AspWebForm_OIL\Demo02\Images\" +name );
                    product.ImagePath = "Images/" + name; 

                }
                catch (Exception ex)
                {

                  
                }
            }
            ctx.Products.Add(product);
            ctx.SaveChanges();
           
        }
    }
}