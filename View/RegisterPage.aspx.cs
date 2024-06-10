using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Button_Click(object sender, EventArgs e)
        {
            if (UserRepository.FindByName(txt_name.Text) == null)
            {
                string name = txt_name.Text;
                string gender = radio_gender.SelectedValue;
                string dob = txt_dob.Text;
                string phone = txt_phone.Text;
                string address = txt_address.Text;
                string password = txt_password.Text;
                string role = "Customer";
                UserRepository.CreateUser(name, gender, dob, phone, address, password, role);
            }
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}