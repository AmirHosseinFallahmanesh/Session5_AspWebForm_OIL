using Demo03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo03
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["test"] !=null)
            {
            TextBox1.Text = (ViewState["test"] as UserModelSummery).Name;
            }
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = (Session["test"] as UserModelSummery).Name;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cart"];
            if (cookie != null)
            {
                TextBox3.Text = cookie.Value;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Application["name"] != null)
            {
                TextBox4.Text = Application["name"].ToString();
            }

        }
    }
}