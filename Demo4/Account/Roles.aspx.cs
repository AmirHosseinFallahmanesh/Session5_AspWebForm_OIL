using Demo4.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo4.Account
{
    public partial class Roles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
          

    
            var roleStore = new RoleStore<IdentityRole>(context);

           
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

        
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = TextBox1.Text });
         

        }
    }
}