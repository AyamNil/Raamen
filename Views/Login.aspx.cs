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
            HttpCookie cookie = Request.Cookies["user_cookie"];
            tbUsername.Text = cookie != null ? cookie.Value : null;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UserRepository u = new UserRepository();
            User a = u.checkUser(tbUsername.Text, tbPassword.Text);
            if (a != null)
            {
                Session["user"] = a;
                if (CbRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = tbUsername.Text;
                    cookie.Expires = DateTime.Now.AddHours(3);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/ViewAdmin.aspx");
            }
        }
    }
}