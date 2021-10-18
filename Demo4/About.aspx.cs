using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
               
                    Response.Redirect("account/login?ReturnUrl=about");
                
            }

                if (!User.IsInRole("guest"))
                {
                    Response.Redirect("account/login?ReturnUrl=about");
                }
           
        }
    }
}