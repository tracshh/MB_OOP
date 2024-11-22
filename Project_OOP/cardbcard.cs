using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP
{
    public partial class cardbcard : Form
    {
        public int number = 0;
        public int Balance_1;
        public cardbcard(int Balance)
        {
            InitializeComponent();
            Balance_1 = Balance;
        }

        private void btn_ramze2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cvv2.Text) || string.IsNullOrEmpty(txt_mabda.Text) || string.IsNullOrEmpty(txt_maghsad.Text) || string.IsNullOrEmpty(txt_mablagh.Text))
                MessageBox.Show("لطفا فیلدها را پر کنید",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            else if (txt_mabda.Text.Length != 19 || txt_maghsad.Text.Length != 19)
            {
                MessageBox.Show("شماره کارت به درستی وارد نشده است",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else if (txt_mablagh.Text.Length < 5)
            {
                MessageBox.Show("مبلغ وارد شده کمتر از حد مجاز است",
                                "Warning", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else if (txt_mablagh.Text.Length > 8)
            {
                MessageBox.Show("مبلغ وارد شده بیشتر از سقف مجاز است",
                                "Warning", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                Random r1 = new Random();
                number = r1.Next(1000, 9999);
                btn_ramze2.Enabled = false;
                txt_mabda.Enabled = false;
                txt_maghsad.Enabled = false;
                txt_mablagh.Enabled = false;
                txt_cvv2.Enabled = false;
                txt_ramze2.Enabled = true;
                txt_ramze2.Text = number.ToString();
                btn_enteghal.Enabled = true;
            }

        }

        private void btn_enteghal_Click(object sender, EventArgs e)
        {
            int mablagh = Convert.ToInt32(txt_mablagh.Text);
            string num = number.ToString();
            if (Balance_1 > mablagh)
            {
                if (txt_cvv2.Text == "709" && txt_ramze2.Text == num)
                {

                    btn_enteghal.Enabled = false;
                    Balance_1 -= mablagh;
                    string res = Balance_1.ToString();
                    MessageBox.Show("موجودی : " + res + "\nبرداشت وجه از حساب به مبلغ : " + txt_mablagh.Text);
                    this.Hide();
                    new main(Balance_1).Show();
                }
                else
                    MessageBox.Show("ورودی اشتباه است",
                                    "Error",
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("موجودی کافی نیست ! لغو عملیات ",
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
