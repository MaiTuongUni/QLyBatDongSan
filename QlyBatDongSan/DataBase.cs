using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBatDongSan
{
    class DataBase
    {
        string ConnStr = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=QuanLyBatDongSan;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        DataTable dt;

        public DataBase()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        public bool CheckLogin(string sql, CommandType ct)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = sql;
            comm.CommandType = ct;
            try
            {
                int k =Int32.Parse(comm.ExecuteScalar().ToString());
                if (k > 0)
                {
                    f = true;
                }
            }
            catch (System.NullReferenceException ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        //Thực thi nhanh nếu chỉ cần lấy dữ liệu trả ra
        //Lấy giá trị trả ra cho Combobox
        public bool LoadCombobox(ComboBox cbb, string display, string value, string sql)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            dt = new DataTable();
            dt = ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
            cbb.DataSource = dt;
            cbb.DisplayMember = display;
            cbb.ValueMember = value;
            return true;
        }
    }
}
