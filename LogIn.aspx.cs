using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        DataTable dt = ClassUser.GetAll();
        int i = ClassUser.FindUserByUserName(txtUserName.Text);
        if (i != -1)
            if (dt.Rows[i]["password"].ToString().Equals(txtPassword.Text))
            {
                //valid user
                // save userid & userType to session
                Session["UserId"] = dt.Rows[i]["userId"].ToString();
                Session["UserType"] = dt.Rows[i]["userType"].ToString();
                Session["username"] = txtUserName.Text;
                Response.Redirect("Default.aspx");
            }
            else
                lblError.Text = "Error Password!";

        else
            lblError.Text = "user name not found !";
    }

    protected void txtUserName_TextChanged(object sender, EventArgs e)
    {

    }
}