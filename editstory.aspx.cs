using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ProductSell : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string uType = "", uId = "";
        if (Session["userId"] != null) uId = (string)Session["userId"];

        if (Session["userType"] != null) uType = (string)Session["userType"];


        /*if (Session["userId"] != null)
        {
            DataTable dt = ClassProduct.GetAll();
            int i = ClassUser.FindUserByUserName(Session["userName"].ToString());
            txtContent.Text = dt.Rows[i]["mContent"].ToString();

            ClassProduct cm = new ClassProduct(Session["userName"].ToString(),dt.Rows[i]["snumofcomments"].ToString(), txtContent.Text, uType, uId);
            cm.Insert();
            Clear();
        }*/
    }
    public void Clear()
    {
        txtContent.Text = "";
    }
}