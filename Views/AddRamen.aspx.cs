using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Raamen.Views
{
    public partial class AddRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {

            }
            MeatRepository rp = new MeatRepository();
            DropDownMeat.DataSource = rp.getMeat();
            DropDownMeat.DataTextField = "Name";
            DropDownMeat.DataValueField = "Name";
            DropDownMeat.DataBind();
        }
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            RamenRepository rp = new RamenRepository();
            rp.InsertRamen(
                itemnameTxt.Text,
                brothTxt.Text,
                PriceTxt.Text,
                Convert.ToInt32(DropDownMeat.SelectedValue)
                );
            Response.Redirect("~/Views/Home.aspx");
        }
    }
}