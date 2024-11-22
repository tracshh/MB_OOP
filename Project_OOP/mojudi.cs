using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP
{
    public partial class mojudi : Form
    {
        public int number = 0;
        public int Balance_1;
        public mojudi(int Balance)
        {
            InitializeComponent();
            Balance_1 = Balance;
        }

        private void btn_ramze2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cvv2.Text))
                MessageBox.Show("لطفا فیلدها را پر کنید",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            else
            {
                Random r1 = new Random();
                number = r1.Next(1000, 9999);
                btn_ramze2.Enabled = false;
                txt_cvv2.Enabled = false;
                txt_ramze2.Enabled = true;
                txt_ramze2.Text = number.ToString();
                btn_daryaft_mojudi.Enabled = true;

            }

        }

        private void btn_daryaft_mojudi_Click(object sender, EventArgs e)
        {
            string num = number.ToString();
            if (txt_cvv2.Text == "709" && txt_ramze2.Text == num)
            {
                btn_daryaft_mojudi.Enabled = false;
                Balance_1 -= 1000;
                string res = Balance_1.ToString();
                MessageBox.Show("موجودی : " + res);
                this.Hide();
                new main(Balance_1).Show();
            }
            else
            {
                MessageBox.Show("ورودی اشتباه است",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Hide();
                new main(Balance_1).Show();
            }
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main(Balance_1).Show();
        }
    }
}
