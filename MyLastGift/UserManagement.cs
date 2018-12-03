using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;

namespace MyLastGift
{
    public partial class UserManagement : UserControl
    {
        string connect = "Data Source=DESKTOP-HQT2KUE\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";

        public UserManagement()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || idTextBox.Text == "" || rolesCombobox.Text == null)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                ListViewItem item = new ListViewItem(idTextBox.Text);
                item.SubItems.Add(nameTextBox.Text);
                item.SubItems.Add(rolesCombobox.Text);
                item.SubItems.Add(dateStart.Text);
                listView1.Items.Add(item);
                idTextBox.Clear();
                nameTextBox.Clear();
                idTextBox.Focus();
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string sql = "select NHANVIENID, TENNV, STARTDATE, ROLES FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem(rd.GetInt32(0).ToString());
                lv.SubItems.Add(rd.GetString(1).ToString());
                lv.SubItems.Add(rd.GetDateTime(2).ToString());
                lv.SubItems.Add(rd.GetBoolean(3).ToString());

                listView1.Items.Add(lv);
            }

            rd.Close();
            cmd.Dispose();
            cnn.Close();
        }
    }
}
