using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.Views
{
    public partial class Register : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] == null)
            {
                
            }
            RoleRepository rp = new RoleRepository();
            DropDownList1.DataSource = rp.getRole();
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }
           
        protected void Button3_Click(object sender, EventArgs e)
        {
            UserRepository rp = new UserRepository();

            rp.InsertUser(
                tbUsername.Text,
                tbEmail.Text,
                radioGender.SelectedValue,
                TbPassword.Text,
                Convert.ToInt32(DropDownList1.SelectedValue)
                );
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string role = DropDownList1.SelectedValue.ToString();
        }

      
    }
}