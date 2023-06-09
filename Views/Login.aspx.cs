using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Raamen.Model;

namespace Raamen.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["username"];
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            UserRepository u = new UserRepository();
            RoleRepository r = new RoleRepository();

            User a = u.checkUser(TbUsername.Text, TbPassword.Text);
            if (a != null)
            {
                User currentUser = u.findUserByUsername(TbUsername.Text);
                
                
                Session["userId"] = currentUser.Id;
                Session["userRole"] = r.getRoleName(currentUser.Role_Id);

                if (CbRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = TbUsername.Text;
                    cookie.Expires = DateTime.Now.AddHours(3);
                    Response.Cookies.Add(cookie);
                    
                }
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}