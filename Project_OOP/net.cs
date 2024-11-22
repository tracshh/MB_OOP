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
    public partial class net : Form
    {
        public int number = 0;
        public int Balance_1;
        public net(int Balance)
        {
            InitializeComponent();
            Balance_1 = Balance;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phone.Text) || string.IsNullOrEmpty(comboBox_operator.Text) || string.IsNullOrEmpty(comboBox_sim.Text))
                MessageBox.Show("لطفا فیلدها را پر کنید",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            else if(txt_phone.Text.Length!=11)
            {
                MessageBox.Show("شماره همراه به درستی وارد نشده است",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                label5.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                btn_taeed.Enabled = true;
                txt_phone.Enabled = false;
                comboBox_operator.Enabled = false;
                comboBox_sim.Enabled = false;
                btn_continue.Enabled = false;
            }

        }

        private void btn_taeed_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            btn_taeed.Enabled = false;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            txt_mabda.Enabled = true;
            txt_cvv2.Enabled = true;
            btn_ramze2.Enabled = true;
            txt_mabda.Text = "0012 3456 7890 9870";
        }

        private void btn_ramze2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cvv2.Text) && string.IsNullOrEmpty(txt_mabda.Text))
                MessageBox.Show("لطفا فیلدها را پر کنید",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            else
            {
                Random r1 = new Random();
                number = r1.Next(1000, 9999);
                btn_ramze2.Enabled = false;
                txt_mabda.Enabled=false;
                txt_cvv2.Enabled=false;
                txt_ramze2.Enabled = true;
                txt_ramze2.Text = number.ToString();
                btn_pardakht.Enabled = true;
            }

        }

        private void btn_pardakht_Click(object sender, EventArgs e)
        {
            string num = number.ToString();
            if (txt_cvv2.Text == "709" && txt_ramze2.Text == num)
            {
                int mablagh = 0;
                string str = "";
                if (radioButton1.Checked)
                { mablagh = 35000; str = " یک ماهه ۴ گیگ "; }
                else if (radioButton2.Checked)
                { mablagh = 48000; str = " یک ماهه ۸ گیگ "; }
                else if (radioButton3.Checked)
                { mablagh = 29000; str = " نیم ماهه ۵ گیگ "; }
                btn_pardakht.Enabled = false;
                if(Balance_1>mablagh)
                {
                    Balance_1 -= mablagh;
                    string res = Balance_1.ToString();
                    MessageBox.Show("موجودی : " + res + "\nبرداشت وجه از حساب به مبلغ : "
                        + Convert.ToString(mablagh) + "\nخرید اینترنت" + str);
                    
                }
                else
                {
                    MessageBox.Show("موجودی کافی نیست ! لغو عملیات ",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                this.Hide();
                new main(Balance_1).Show();

            }
            else
                MessageBox.Show("ورودی اشتباه است",
                                "Error",
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);

        }
        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main(Balance_1).Show();
        }
    }
}
