using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_password.Text;

            MsUser user = UserRepository.FindByName(name);

            if (user != null && user.UserPassword == password)
            {
                Response.Redirect("~/View/ViewStationery.aspx");
            }
            else
            {
                lbl_error.Text = "Invalid Credentials";
            }
        }
    }
}