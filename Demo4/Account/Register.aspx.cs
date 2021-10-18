using Demo4.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo4.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            //ApplicationDbContext context = new ApplicationDbContext();
            var accountManager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManger = Context.GetOwinContext().Get<ApplicationSignInManager>();

            var user = new ApplicationUser() { UserName=Email.Text,Email=Email.Text};
            IdentityResult result = accountManager.Create(user, Password.Text);

            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleMgr = new RoleManager<IdentityRole>(roleStore);

            var finalrResult = accountManager.AddToRole(user.Id, "Guest");


            if (result.Succeeded)
            {

                //string token = accountManager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(token, user.Id, Request);
                //accountManager.SendEmail(user.Id, "Confirm Your Account [No Reply]", "please Confirm Your Account");


                signInManger.SignIn(user, false, false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}