using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class ProductManagment : System.Web.UI.Page
{
    static int i;
    static DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = ClassProduct.GetAll();
            i = 0;
            FillData();
        }
        lblError.Text = "";

    }
    public void FillData()
    {
        if (dt.Rows.Count > 0)
        {
            lblpNum.Text = dt.Rows[i]["sNum"].ToString();
            txtpName.Text = dt.Rows[i]["sName"].ToString();
            txtContent.Text = dt.Rows[i]["sdiscreption"].ToString();
            txtwirtername.Text = dt.Rows[i]["swriter"].ToString();
            Label3.Text = dt.Rows[i]["snumofcomments"].ToString();
            txtwriterid.Text = dt.Rows[i]["suserid"].ToString();

            // fill image
            if (dt.Rows[i]["image"].ToString() != "")
                Image1.ImageUrl = dt.Rows[i]["image"].ToString();
            else
                Image1.ImageUrl = null;

            // fill th dropDownList ddlFindUserById;


           // fillDdlFindUserById();
        }
        else
        {
            ClearData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        // fill GridView
        gdvs.DataSource = dt;
        gdvs.DataBind();
    }//FillData
    /*public void fillDdlFindUserById()
    {
        ddlFindUserById.Items.Clear();

        for (int i = 0; i < dt.Rows.Count; i++)
            ddlFindUserById.Items.Add(dt.Rows[i]["userId"].ToString());

    }*/
    public bool IsRightDate(string dateString)
    {
        DateTime dob;

        return DateTime.TryParse(dateString, out dob);

    }//IsRightDate

    public bool CheckData()
    {
        // check uploadfile... isValid ?
        if (FileUpload1.HasFile)
        {
            string ext = Path.GetExtension(FileUpload1.FileName);
            ext.ToLower();
            if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" && ext != ".gif")
            {
                lblError.Text = "You Have to upload jpg/jpeg/gif/png file only!";
                return false;
            }
            int fileSize = FileUpload1.PostedFile.ContentLength;
            if (fileSize > 2097152)
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
        txtpName.Text = "";
        txtContent.Text = "";
        txtwriterid.Text = "";
        Label3.Text = "";
        txtwriterid.Text = "";
        Image1.ImageUrl = null;
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
        {    
            //get name of image & save it in folder OR empty string
            // after check uploadFile in check data = valid image
            string ImageName = "";
            if (FileUpload1.HasFile)
            {   //save the image name
                ImageName = "images\\" + FileUpload1.FileName;
                //save the file in folder images
                string path = Server.MapPath("images/");
                FileUpload1.SaveAs(path + FileUpload1.FileName);
                // show the image in image tool
                Image1.ImageUrl = ImageName;
            }





            ClassProduct u = new ClassProduct(txtpName.Text,Label3.Text,txtContent.Text,txtwriterid.Text,txtwirtername.Text, ImageName);
            u.Insert();
            dt = ClassProduct.GetAll();
            ClearData();
            gdvs.DataSource = dt;
            gdvs.DataBind();
            //fillDdlFindUserById();

        }
    } //btnAdd_Click

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        ClassProduct u = new ClassProduct();
        u.SNum= lblpNum.Text;
        u.Delete();
        // update i
        // work with old dt
        if (i == dt.Rows.Count - 1 && i > 0) i--;


        // new dt after delete
        dt = ClassProduct.GetAll();
        FillData(); // under construction
       gdvs.DataSource = dt;
        gdvs.DataBind();
    }//btnDelete_Click

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string ImageName = "";
        if (FileUpload1.HasFile)
        {   //save the image name
            ImageName = "images\\" + FileUpload1.FileName;
            //save the file in folder images
            string path = Server.MapPath("images/");
            FileUpload1.SaveAs(path + FileUpload1.FileName);
            // show the image in image tool
            Image1.ImageUrl = ImageName;
        }
        ClassProduct u = new ClassProduct(txtpName.Text, Label3.Text, txtContent.Text, txtwriterid.Text, txtwirtername.Text, ImageName);
        u.SNum = lblpNum.Text;
        u.Update();
        dt = ClassProduct.GetAll();
        FillData();
        gdvs.DataSource = dt;
        gdvs.DataBind();
    }//btnUpdate_Click

    protected void btnFindUserByUserName_Click(object sender, EventArgs e)
     {
         if (txtpName.Text == "")
         {
             lblError.Text = "no data for search !!";
             return;
         }
         int x = ClassProduct.FindProductByName(txtpName.Text);
         if (x == -1)
         {
             lblError.Text = "User not found !!";
             return;
         }

         i = x;
         FillData();
         txtpName.Text = "";
     }

     protected void ddlFindUserById_SelectedIndexChanged(object sender, EventArgs e)
     {
         i = ClassUser.FindUserById(lblpNum.Text);
         FillData();
     }

}