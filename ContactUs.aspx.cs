using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string uType="", uId="";
        if (Session["userId"] != null) uId = (string)Session["userId"];

        if (Session["userType"] != null) uType = (string)Session["userType"];

        ClassMessage cm = new ClassMessage(txtSubject.Text,txtContent.Text,uType,uId);
        cm.Insert();
        Clear();
    }
    public  void Clear()
    {
        txtContent.Text = "";
        txtSubject.Text = "";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }
}