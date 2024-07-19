using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ProductView : System.Web.UI.Page
{
    static int i=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["storiesinlist"];

        if(dt != null)
        {
            Label4.Text = dt.Rows.Count.ToString();
        }
        else
        {
            Label4.Text = "0";//i.ToString();
        }
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "AddToList")
        {
            ClassCart c = new ClassCart();
            c.SNum =((Label)e.Item.FindControl("lblSnumm")).Text;
            c.SName = ((Label)e.Item.FindControl("lbltitlet")).Text;
            c.Swriter = ((Label)e.Item.FindControl("lblwritern")).Text;
            c.Snumofcomments = ((Label)e.Item.FindControl("lblcomn")).Text;
            c.Sdiscreption = ((Label)e.Item.FindControl("lbldesc")).Text;
            c.Image = ((Image)e.Item.FindControl("image1")).ImageUrl;
            c.Suserid= ((Label)e.Item.FindControl("Label5")).Text;
            
            if (ClassCart.FindCartBySnum(c.SNum) == -1)
            {
                c.Insert();
                i++;
                Label4.Text = i.ToString();
                Session["sNum"] = c.SNum;
                Response.Redirect("UserCart.aspx");
            }
            
        }
    }
}
