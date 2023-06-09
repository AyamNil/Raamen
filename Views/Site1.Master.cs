using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.Views
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userRole"] != null)
            {
                if (Session ["userRole"].Equals("Member"))
                {
                    LogInbtn.Visible = false;
                    LogOutBtn.Visible = true;
                }
                else if (Session["userRole"].Equals("Staff"))
                {
                    LogInbtn.Visible = false;
                    LogOutBtn.Visible = true;
                    StaffBtn.Visible = true;
                }
                else if (Session["userRole"].Equals("Admin"))
                {
                    LogInbtn.Visible = false;
                    LogOutBtn.Visible = true;
                    StaffBtn.Visible = true;
                }
            }
        }

        protected void LogInbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void LogOutBtn_Click(object sender, EventArgs e)
        {
            string[] cookies = Response.Cookies.AllKeys;
            foreach(string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Session["userId"] = null;
            Session["userRole"] = null;
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void StaffBtn_Click(object sender, EventArgs e)
        {

        }
    }
}