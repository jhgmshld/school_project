using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "read")
        {
            Session["sNum"] = ((Label)e.Item.FindControl("lblSnumm")).Text;
            Response.Redirect("read.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}