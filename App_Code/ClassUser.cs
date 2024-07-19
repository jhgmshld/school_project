using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; // for use datatable

/// <summary>
/// Summary description for ClassUser
/// </summary>
public class ClassUser
{
    private string userId;
    private string fullName;
    private string birthDate;
    private string gender;
    private string userName;
    private string password;
    private string userType;
    private string userImage;


    public ClassUser()
    {
        //
        // TODO: Add constructor logic here
        //
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

    public string FullName
    {
        get
        {
            return fullName;
        }

        set
        {
            fullName = value;
        }
    }

    public string BirthDate
    {
        get
        {
            return birthDate;
        }

        set
        {
            birthDate = value;
        }
    }

    public string Gender
    {
        get
        {
            return gender;
        }

        set
        {
            gender = value;
        }
    }

    public string UserName
    {
        get
        {
            return userName;
        }

        set
        {
            userName = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
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

    public string UserImage
    {
        get
        {
            return userImage;
        }

        set
        {
            userImage = value;
        }
    }
    public ClassUser(string fullName, string birthDate, string gender, string userName, string password, string userType, string userImage)
    {

        this.fullName = fullName;
        this.birthDate = birthDate;
        this.gender = gender;
        this.userName = userName;
        this.password = password;
        this.UserType = userType;
        this.UserImage = userImage;
    }

    public void Insert()
    {
        string strSql = "INSERT INTO [usertb]";
        strSql += "([fullName],[birthDate],[gender],[userName],[password],[userType],[userImage])";
        strSql += "VALUES ('{0}',#{1}#,'{2}','{3}','{4}','{5}','{6}')";
        strSql = string.Format(strSql,this.fullName,this.birthDate,this.gender,this.userName,this.password,this.userType,this.userImage);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }
    public void Delete()
    {
        string strSql = "DELETE * FROM [usertb] WHERE [userId]={0}";
        
        strSql = string.Format(strSql, this.userId);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }
    public void Update()
    {
        string strSql = "UPDATE [usertb] SET [fullName]='{0}' , [birthDate]=#{1}#, [gender]='{2}', [userName]='{3}',[password]='{4}',[userType]='{5}',[userImage]='{6}' WHERE [userId]={7}" ;
        strSql = string.Format(strSql, this.fullName, this.birthDate, this.gender, this.userName, this.password,this.userType,this.userImage,this.userId);

        Dbase.ChangeTable(strSql, "DBU.accdb");
    }

    public static DataTable GetAll()
    {
        string strSql = "SELECT * FROM [usertb]";
        DataTable dt = Dbase.SelectFromTable(strSql, "DBU.accdb");
        return dt;
    }
    // return index in dataTable or -1
    public static int FindUserById(string userId)
    {
        DataTable dt = GetAll();
        for (int i = 0; i < dt.Rows.Count; i++)
            if (dt.Rows[i]["userId"].ToString() == userId)
                return i;
        return -1;
    }
    // return index in dataTable or -1
    public static int FindUserByUserName(string userName)
    {
        DataTable dt = GetAll();
        for (int i = 0; i < dt.Rows.Count; i++)
            if (dt.Rows[i]["userName"].ToString() == userName)
                return i;
        return -1;
    }

}