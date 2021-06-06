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
    public partial class Property : Form
    {
        DataBase dataBase;
        UtilsFunction utils = new UtilsFunction();

        public Property()
        {
            InitializeComponent();

            dataBase = new DataBase();
            dataBase.LoadCombobox(cbbType, "name", "id", "select * from property_type");
            txtPrice.Text = "0";
        }

        private void Property_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                string sql = "select * from property where id = " + txtId.Text;
                DataTable dataTable = dataBase.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    txtId.Text = dataTable.Rows[0]["id"].ToString();
                    txtQuareFeet.Text = dataTable.Rows[0]["squarefeet"].ToString();
                    txtOwnerId.Text = dataTable.Rows[0]["ownerId"].ToString();
                    txtPrice.Text = dataTable.Rows[0]["price"].ToString();
                    txtAddress.Text = dataTable.Rows[0]["address"].ToString();
                    numBedroom.Value = decimal.Parse(dataTable.Rows[0]["bedroom"].ToString());
                    numBathroom.Value = decimal.Parse(dataTable.Rows[0]["bathroom"].ToString());
                    numAge.Value = decimal.Parse(dataTable.Rows[0]["age"].ToString());
                    txtDescription.Text = dataTable.Rows[0]["description"].ToString();
                    int backyard = int.Parse(dataTable.Rows[0]["backyard"].ToString());
                    if(backyard == 1)
                    {
                        cbBackyard.Checked = true;
                    }
                    else
                    {
                        cbBackyard.Checked = false;
                    }

                    txtId.ReadOnly = true;
                    return;
                }
                else
                {
                    MessageBox.Show("The infomation user searching is not match");
                }
            }
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(txtPrice.Text == "")
            {
                txtPrice.Text = "0";
            }
            else
            {
                utils.ConvertCurrency(txtPrice);
            }
        }
    }
}
