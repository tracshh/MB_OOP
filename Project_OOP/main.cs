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
    public partial class main : Form
    {
        public int Balance;
        public main(int Balance_1)
        {
            InitializeComponent();
            Balance = Balance_1;
        }
        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("شما از حساب کاربری خود خارج شدید",
                            "info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Application.Exit();
        }
        private void btn_mojudi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mojudi(Balance).Show();
        }
        private void btn_cardbcard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new cardbcard(Balance).Show();
        }
        private void btn_net_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new net(Balance).Show();
        }
        private void btn_charge_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new charge(Balance).Show();
        }

    }

}
