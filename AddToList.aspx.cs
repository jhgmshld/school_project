using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddToList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("sNum");
            dt.Columns.Add("swriter");
            dt.Columns.Add("sName");
            dt.Columns.Add("snumofcomments");
            dt.Columns.Add("sdiscreption");
            dt.Columns.Add("image");
            if(Request.QueryString["userId"] != null)
            {
                if(Session["storiesinlist"] != null)
                {
                    dr = dt.NewRow();
                    string mycon = "Data Source=HP-PC\\SQLEXPRESS;Initial Catalog=jhgmshld;Integrated Security=True";
                    SqlConnection s;
                    SqlConnection scon = new SqlConnection(mycon);
                    string myquery = "select * from booktb where booid=" + Request.QueryString["userId"];
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = myquery;
                    cmd.Connection = scon;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                }
            }
        }*/
    }
}