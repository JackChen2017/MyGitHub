using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //add change for an example.
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SB db = new SB();
        string strusername = this.textusername.Text.Trim();//获取输入的用户名和密码
        string strpassword = this.textpassword.Text.Trim();
        SqlDataReader dr = db.reDr("select * from Test2 where Topic='" + strusername + "'and Sender='" + strpassword + "'");//在数据库中select
        dr.Read();
        //dr对象读取数据集
        if (dr.HasRows)
        {
            Session["Topic"] = dr.GetValue(1);
            Session["Sender"] = dr.GetValue(2);
            Response.Write("<script>alert('登录成功！')</script>");
        }
        else
        {
            //Response.Write("<script>alert('登录失败！');location='Login.aspx'</script>");
        }
        dr.Close();
    }
}