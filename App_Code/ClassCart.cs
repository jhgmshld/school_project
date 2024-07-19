using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ClassCart
{
    private string sName, swriter, snumofcomments, sdiscreption, suserid, image;
    private string sNum;

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

    public ClassCart()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public ClassCart(string sNum, string sName,string swriter,string snumofcomments,string sdiscreption,string suserid, string image)
    {
        this.SName = sName;
        this.Swriter = swriter;
        this.Snumofcomments = snumofcomments;
        this.Sdiscreption = sdiscreption;
        this.Suserid = suserid;
        this.Image = image;
        this.sNum = sNum;
    }

    

    public static DataTable GetAll()
    {
        string strSql = "SELECT * FROM [carttb]";
        DataTable dt = Dbase.SelectFromTable(strSql, "DBU.accdb");
        return dt;
    }
    public void Insert()
    {
        string strSql = "INSERT INTO [carttb]";
        strSql += "([sNum],[sName],[swriter],[snumofcomments],[sdiscreption],[suserid],[image])";
        strSql += "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
        strSql = string.Format(strSql, this.sNum, this.sName, this.swriter, this.snumofcomments, this.sdiscreption, this.suserid, this.image);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }

    public void Delete()
    {
        string strSql = "DELETE * FROM [carttb] WHERE [sNum]={0}";

        strSql = string.Format(strSql, this.sNum);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }

    public static void DeleteAll()
    {
        string strSql = "DELETE * FROM [carttb] ";

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }
    // return index in dataTable or -1
    public static int FindCartBySnum(string sNum)
    {
        DataTable dt = GetAll();
        for (int i = 0; i < dt.Rows.Count; i++)
            if (dt.Rows[i]["sNum"].ToString() == sNum)
                return i;
        return -1;
    }
}