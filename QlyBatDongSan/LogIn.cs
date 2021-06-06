using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBatDongSan
{
    public partial class LogIn : Form
    {
        DataBase dataBase;
        public LogIn()
        {
            dataBase = new DataBase();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                string sql = "select * from users where username= '"+txtUsername.Text+ "' and password= '" + txtPassword.Text + "'";
                DataTable user  = dataBase.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
                if (user.Rows.Count > 0)
                {
                    Form home = new HomePage();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác");
                }
            }
        }
    }
}
