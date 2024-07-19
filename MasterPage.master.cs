using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        str = "";
        if (Session["UserType"] != null) str = Session["UserType"].ToString();

        if (str == "user")
        {
            RemoveMenuItem("Admin");
            RenameMenuItem("LogInOut", "Log Out");
        }
        else if (str == "admin")
        {
            RenameMenuItem("LogInOut", "Log Out");
            RemoveMenuItem("User");
        }
        else
        {
            RemoveMenuItem("User");
            RemoveMenuItem("Admin");
            RenameMenuItem("LogInOut", "Log In");
            RemoveMenuItem("Home");
        }

    }//Page_Load
    private void RemoveMenuItem(string Value)
    {
        MenuItem mi = Menu.FindItem(Value);
        if (mi != null)
        {
            Menu.Items.Remove(mi);
        }
    }//RemoveMenuItem

    private void RenameMenuItem(string Value, string Name)
    {

        MenuItem mi = Menu.FindItem(Value);
        if (mi != null)
        {
            mi.Text = Name;
        }
    }//RenameMenuItem



    protected void Menu_MenuItemClick(object sender, MenuEventArgs e)
    {
        if (e.Item.Value.Equals("LogInOut"))
        {
            if (e.Item.Text.Equals("Log Out"))
            {
                Session["UserType"] = "";
                Session["UserId"] = "";
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("LogIn.aspx");
            }
        }
        if (e.Item.Value.Equals("Products"))
        {
            
            if (str == "user")
                Response.Redirect("ProductsSell.aspx");
            else
                Response.Redirect("ProductsView.aspx");

        }
    }//Menu_MenuItemClick
}
