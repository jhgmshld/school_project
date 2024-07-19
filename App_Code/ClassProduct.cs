using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for ClassProduct
/// </summary>
public class ClassProduct
{
   private string  sName, swriter, snumofcomments,sdiscreption,suserid,image;
    private string sNum;


    public ClassProduct()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public ClassProduct(string sName, string snumofcomments, string sdiscreption, string suserid, string swriter, string image)
    {
        this.image = "dark-gray-background-charcoal-paint-1965660.jpg";
        this.sName = sName;
        this.snumofcomments = snumofcomments;
        this.sdiscreption = sdiscreption;
        this.suserid = suserid;
        this.swriter = swriter;
        if (image != "")
            this.image = image;
    }

    public string SName
    {
        get
        {
            return sName;
        }

        set
        {
            sName = value;
        }
    }

    public string SNum
    {
        get
        {
            return sNum;
        }

        set
        {
            sNum = value;
        }
    }

    public string Swriter
    {
        get
        {
            return swriter;
        }

        set
        {
            swriter = value;
        }
    }

    public string Snumofcomments
    {
        get
        {
            return snumofcomments;
        }

        set
        {
            snumofcomments = value;
        }
    }

    public string Sdiscreption
    {
        get
        {
            return sdiscreption;
        }

        set
        {
            sdiscreption = value;
        }
    }

    public string Suserid
    {
        get
        {
            return suserid;
        }

        set
        {
            suserid = value;
        }
    }

    public string Image
    {
        get
        {
            return image;
        }

        set
        {
            image = value;
        }
    }
    

    public static DataTable GetAll()
    {
        string strSql = "SELECT * FROM [booktb]";
        DataTable dt = Dbase.SelectFromTable(strSql, "DBU.accdb");
        return dt;
    }
    public void Insert()
    {
        string strSql = "INSERT INTO [booktb]";
        strSql += "([sName],[swriter],[suserid],[snumofcomments],[sdiscreption],[image])";
        strSql += "VALUES ('{0}','{1}',{2},'{3}','{4}','{5}')";
        strSql = string.Format(strSql, this.sName, this.swriter,int.Parse( this.suserid), this.snumofcomments, this.sdiscreption,this.image);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }
    public void Delete()
    {
        string strSql = "DELETE * FROM [booktb] WHERE [sNum]={0}";

        strSql = string.Format(strSql, this.sNum);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }
    public void Update()
    {
        string strSql = "UPDATE [booktb] SET [sName]='{0}' , [swriter]='{1}', [suserid]='{2}', [snumofcomments]='{3}',[sdiscreption]='{4}',[image]='{5}' WHERE [sNum]={6}";
        strSql = string.Format(strSql, this.sName, this.swriter, this.suserid, this.snumofcomments, this.sdiscreption,this.image, this.sNum);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }
    // return index in dataTable or -1
    public static int FindProductById(string sNum)
    {
        DataTable dt = GetAll();
        for (int i = 0; i < dt.Rows.Count; i++)
            if (dt.Rows[i]["sNum"].ToString() == sNum)
                return i;
        return -1;
    }
    public static int FindProductByName(string sName)
    {
        DataTable dt = GetAll();
        for (int i = 0; i < dt.Rows.Count; i++)
            if (dt.Rows[i]["sName"].ToString() == sName)
                return i;
        return -1;
    }
}// class