using Demo03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo03
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["test"] = new UserModelSummery() { Name = TextBox1.Text };
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = (ViewState["test"] as UserModelSummery).Name;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["test"] = new UserModelSummery() { Name = TextBox3.Text };
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox4.Text = (Session["test"] as UserModelSummery).Name;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cart");
            cookie.Value = TextBox5.Text;
            cookie.Expires = DateTime.Now.AddDays(4);
            cookie.HttpOnly = true;
            Response.Cookies.Add(cookie);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cart"];
            if (cookie!=null)
            {
                TextBox6.Text = cookie.Value;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Application["name"] = TextBox7.Text;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (Application["name"]!=null)
            {
                TextBox8.Text = Application["name"].ToString();
            }
           
        }
    }
}