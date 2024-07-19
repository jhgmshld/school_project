using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; // for use datatable
/// <summary>
/// Summary description for ClassMessage
/// </summary>
public class ClassMessage
{
    private string mNum,mSubject,mContent,userType,userId;
    

    public ClassMessage()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public ClassMessage( string mSubject, string mContent, string userType, string userId)
    {
      
        this.mSubject = mSubject;
        this.mContent = mContent;
        this.userType = userType;
        this.userId = userId;
    }

    public string MNum
    {
        get
        {
            return mNum;
        }

        set
        {
            mNum = value;
        }
    }

    public string MSubject
    {
        get
        {
            return mSubject;
        }

        set
        {
            mSubject = value;
        }
    }

    public string MContent
    {
        get
        {
            return mContent;
        }

        set
        {
            mContent = value;
        }
    }

    public string UserType
    {
        get
        {
            return userType;
        }

        set
        {
            userType = value;
        }
    }

    public string UserId
    {
        get
        {
            return userId;
        }

        set
        {
            userId = value;
        }
    }

    public void Insert()
    {
        string strSql = "INSERT INTO [messagestb]";
        strSql += "([mSubject],[mContent],[userType],[userId])";
        strSql += "VALUES ('{0}','{1}','{2}','{3}')";
        strSql = string.Format(strSql,this.mSubject, this.mContent, this.userType, this.userId);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }

    public static DataTable GetAll()
    {
        string strSql = "SELECT * FROM [messagestb]";
        DataTable dt = Dbase.SelectFromTable(strSql, "DBU.accdb");
        return dt;
    }
}//class