using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Massages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = ClassMessage.GetAll();
        gdvMessags.DataSource = dt;
        gdvMessags.DataBind();
    }
}