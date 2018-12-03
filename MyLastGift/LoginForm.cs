using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace MyLastGift
{
    public partial class LoginForm : Form
    {
        NhanVienBUS nvBus;
        public LoginForm()
        {
            InitializeComponent();
            nvBus = new NhanVienBUS();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = textBox1.Text;
            string pass = textBox2.Text;
            Console.Write(acc + "  " + pass);
            NhanVien nv = nvBus.checkLogin(acc, pass);
            if (nv != null)
            {
                Form3 f = new Form3(nv);
                this.Hide();

                f.Nv = nv;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("wrong account or password");
            }

        }
        
    }
}
