using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
public partial class UserManagment : System.Web.UI.Page
{
    static int i;
    static DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = ClassUser.GetAll();
            i = 0;
            FillData();
        }
        lblError.Text = "";

    }
    public void FillData()
    {
        if (dt.Rows.Count > 0)
        {
            lblId.Text = dt.Rows[i]["userId"].ToString();//dt.Rows[i][0]
            txtFullName.Text = dt.Rows[i]["fullName"].ToString();
            txtBirthdate.Text = dt.Rows[i]["birthDate"].ToString();
            if (dt.Rows[i]["gender"].ToString() == "male")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;
            txtUserName.Text = dt.Rows[i]["userName"].ToString();
            txtPassword.Text = dt.Rows[i]["password"].ToString();
            //fill checkbox
            if (dt.Rows[i]["userType"].ToString().Equals("admin"))
                chbUserType.Checked = true;
            else
                chbUserType.Checked = false;

            // fill image
            if (dt.Rows[i]["userImage"].ToString() != "")
                imgUser.ImageUrl = dt.Rows[i]["userImage"].ToString();
            else
                imgUser.ImageUrl = null;

               // fill th dropDownList ddlFindUserById;
               fillDdlFindUserById();
        }
        else
        {
            ClearData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        // fill GridView
        gdvUser1.DataSource = dt;
        gdvUser1.DataBind();
    }//FillData
    public void fillDdlFindUserById()
    {
        ddlFindUserById.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
            ddlFindUserById.Items.Add(dt.Rows[i]["userId"].ToString());

    }
    public bool IsRightDate(string dateString)
    {
        DateTime dob;

        return DateTime.TryParse(dateString, out dob);

    }//IsRightDate

    public bool CheckData()
    {
        if (!IsRightDate(txtBirthdate.Text))
        {
            lblError.Text = "Error Date Formate !";
            return false;
        }
        if (rdbMale.Checked == false && rdbFemale.Checked == false)
        {
            lblError.Text = "Choose gender !";
            return false;
        }
        if (txtUserName.Text.Length < 6)
        {
            lblError.Text = "input username >= 6";
            return false;
        }
        if (ClassUser.FindUserByUserName(txtUserName.Text) != -1)
        {
            lblError.Text = "Error.. userName in Used ! !";
            return false;
        }
        if (txtPassword.Text.Length < 6)
        {
            lblError.Text = "input Password >= 6";
            return false;
        }
        // check uploadfile... isValid ?
        if (FileUploadUser.HasFile)
        {
            string ext = Path.GetExtension(FileUploadUser.FileName);
            ext.ToLower();
            if(ext != ".jpg" && ext != ".jpeg" && ext != ".png" && ext != ".gif" )
            {
                lblError.Text = "You Have to upload jpg/jpeg/gif/png file only!";
                return false;
            }
            int fileSize = FileUploadUser.PostedFile.ContentLength;
            if(fileSize > 2097152)
            {
                lblError.Text = "Error.. Maximum image size (2MB) !";
                return false;
            }
        }

        return true;
    }//CheckData
    protected void btnFirst_Click(object sender, EventArgs e)
    {



        btnAdd.Enabled = false;
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;

        i = 0;
        FillData();
    }//btnFirst_Click

    protected void btnNext_Click(object sender, EventArgs e)
    {

        btnAdd.Enabled = false;
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;

        if (i < dt.Rows.Count - 1)
        {
            i++;

        }
        FillData();
    }//btnNext_Click

    protected void btnPrev_Click(object sender, EventArgs e)
    {
        if (i > 0)
        {
            i--;
            FillData();
        }

        btnAdd.Enabled = false;
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;


    }//btnPrev_Click

    protected void btnLast_Click(object sender, EventArgs e)
    {


        btnAdd.Enabled = false;
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;

        i = dt.Rows.Count - 1;
        FillData();
    }// btnLast_Click

    public void ClearData()
    {
        lblId.Text = "";
        txtFullName.Text = "";
        txtBirthdate.Text = "";
        rdbMale.Checked = false;
        rdbFemale.Checked = false;
        txtUserName.Text = "";
        txtPassword.Text = "";
        chbUserType.Checked = false;
    }//ClearData
    protected void btnNew_Click(object sender, EventArgs e)
    {
        btnAdd.Enabled = true;
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
        ClearData();
    }//btnNew_Click

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // after check data...
        if (CheckData())
        {    // check & save gender
            string g = "male";
            if (rdbFemale.Checked)
                g = "female";
            // check & save userType
            string ut = "user";
            if (chbUserType.Checked)
                ut = "admin";
            //get name of image & save it in folder OR empty string
            // after check uploadFile in check data = valid image
            string ImageName = "";
            if(FileUploadUser.HasFile)
            {   //save the image name
                ImageName ="images\\"+ FileUploadUser.FileName;
                //save the file in folder images
                string path = Server.MapPath("images/");
                FileUploadUser.SaveAs(path + FileUploadUser.FileName);
                // show the image in image tool
                imgUser.ImageUrl = ImageName;
            }





            ClassUser u = new ClassUser(txtFullName.Text, txtBirthdate.Text, g, txtUserName.Text, txtPassword.Text,ut, ImageName);
            u.Insert();
            dt = ClassUser.GetAll();
            ClearData();
            gdvUser1.DataSource = dt;
            gdvUser1.DataBind();
            fillDdlFindUserById();

        }
    } //btnAdd_Click

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        ClassUser u = new ClassUser();
        u.UserId = lblId.Text;
        u.Delete();
        // update i
        // work with old dt
        if (i == dt.Rows.Count - 1 && i > 0) i--;


        // new dt after delete
        dt = ClassUser.GetAll();
        FillData(); // under construction
        gdvUser1.DataSource = dt;
        gdvUser1.DataBind();
    }//btnDelete_Click

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // check & save gender
        string g = "male";
        if (rdbFemale.Checked)
            g = "female";
        // check & save userType
        string ut = "user";
        if (chbUserType.Checked)
            ut = "admin";
        //get name of image & save it in folder OR empty string
        // after check uploadFile in check data = valid image
        string ImageName = "";
        if (FileUploadUser.HasFile)
        {   //save the image name
            ImageName = "images\\" + FileUploadUser.FileName;
            //save the file in folder images
            string path = Server.MapPath("images/");
            FileUploadUser.SaveAs(path + FileUploadUser.FileName);
            // show the image in image tool
            imgUser.ImageUrl = ImageName;
        }
        ClassUser u = new ClassUser(txtFullName.Text, txtBirthdate.Text, g, txtUserName.Text, txtPassword.Text,ut, ImageName);
        u.UserId = lblId.Text;
        u.Update();
        dt = ClassUser.GetAll();
        FillData();
        gdvUser1.DataSource = dt;
        gdvUser1.DataBind();
    }//btnUpdate_Click

    protected void btnFindUserByUserName_Click(object sender, EventArgs e)
    {
        if (txtFindUserByUserName.Text == "")
        {
            lblError.Text = "no data for search !!";
            return;
        }
        int x = ClassUser.FindUserByUserName(txtFindUserByUserName.Text);
        if (x == -1)
        {
            lblError.Text = "User not found !!";
            return;
        }

        i = x;
        FillData();
        txtFindUserByUserName.Text = "";
    }

    protected void ddlFindUserById_SelectedIndexChanged(object sender, EventArgs e)
    {
        i = ClassUser.FindUserById(ddlFindUserById.Text);
        FillData();
    }

}