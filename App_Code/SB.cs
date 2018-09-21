using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// SB 的摘要说明
/// </summary>
public class SB
{
    public SB()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    ///<summary>连接数据库</summary>返回SqlConnection对象
    public SqlConnection GetCon()//连接数据库，ConfigurationManager对象的AppSettings属性值获取配置节中连接数据库的字符串实例化SqlConnection对象，并返回该对象
    {
        return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ToString());
    }

    ///<summary>执行SQL语句</summary>
    ///<param name="cmdstr">SQL语句</param>
    ///返回int类型，1：成功，0：失败
    public int sqlEx(string cmdstr)//通过 SqlCommand对象执行数据库操作
    {
        SqlConnection con = GetCon();//连接数据库
        con.Open();//打开连接

        try
        {
            SqlCommand cmd = new SqlCommand(cmdstr, con);
            cmd.ExecuteNonQuery();//执行SQL语句并返回受影响的行数
            return 1;
        }
        catch (Exception e)
        {
            return 0;
        }
        finally
        {
            con.Dispose();
        }
    }

    ///<summary>执行SQL查询语句</summary>
    ///返回DataTable数据表
    public DataTable reDt(string cmdstr)//通过SQL语句查询数据库中的数据，并将查询结果存储在DataSet数据集中，最终将该数据集中的查询结果的数据表返回
    {

        try
        {
            SqlConnection con = GetCon();
            SqlDataAdapter da = new SqlDataAdapter(cmdstr, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds.Tables[0]);//返回DataSet对象可以作为数据绑定控件的数据源，可以对其中的数据进行编辑操作
        }
        catch (Exception)
        {

            throw;
        }

    }

    ///<summary>执行SQL查询语句</summary>
    ///<param name="str">查询语句</param>
    ///返回SqlDataReader对象 dr
    public SqlDataReader reDr(string str)//将执行此语句的结果存放在一个SqlDataReader对象中，最后将这个SqlDataReader对象返回到调用处
    {
        try
        {
            SqlConnection conn = GetCon();
            conn.Open();
            SqlCommand com = new SqlCommand(str, conn);
            SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        catch (Exception)
        {

            throw;
        }
    }


}