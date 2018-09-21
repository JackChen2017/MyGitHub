using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = "server=DJ11-FWQS\\KBMSSQL; Database=KBQMCS;uid=sa;pwd=qwe!234";
        //"User ID = sa; Initial Catalog = KBQMCS; Data Source = (local); Password = Mult2018@";
        //User ID = sa; Initial Catalog = KBQMCS; Data Source = (local); Password = Mult2018@
        SqlConnection con = new SqlConnection(constr);
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into QualityRepairRecord (RepairNum,Subject,UserName) values(" + Text_RepairNum.Text + ",'" + Text_Subject.Text + "','" + Text_UserName.Text + "'" + ")";
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('提交成功！')</script>");
            con.Close();
        }
        else
        {
            Response.Write("<script>alert('连接数据库服务器失败！')</script>");
            return;
        }

    }
}