namespace Project_OOP
{
    partial class charge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_phone = new TextBox();
            label3 = new Label();
            comboBox_operator = new ComboBox();
            label4 = new Label();
            comboBox_charge = new ComboBox();
            label5 = new Label();
            txt_mablagh = new TextBox();
            btn_continue = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_mabda = new TextBox();
            txt_cvv2 = new TextBox();
            txt_ramze2 = new TextBox();
            btn_ramze2 = new Button();
            btn_pardakht = new Button();
            btn_back1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(256, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "خرید شارژ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 75);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "شماره موبایل :";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(54, 67);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(121, 23);
            txt_phone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 104);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "اپراتور :";
            // 
            // comboBox_operator
            // 
            comboBox_operator.FormattingEnabled = true;
            comboBox_operator.Items.AddRange(new object[] { "ایرانسل", "همراه اول", "رایتل", "شاتل موبایل" });
            comboBox_operator.Location = new Point(54, 96);
            comboBox_operator.Name = "comboBox_operator";
            comboBox_operator.RightToLeft = RightToLeft.Yes;
            comboBox_operator.Size = new Size(121, 23);
            comboBox_operator.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 133);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "نوع شارژ :";
            // 
            // comboBox_charge
            // 
            comboBox_charge.FormattingEnabled = true;
            comboBox_charge.Items.AddRange(new object[] { "عادی", "شگفت انگیز", "پرداخت قبض سیم کارت دائمی" });
            comboBox_charge.Location = new Point(54, 125);
            comboBox_charge.Name = "comboBox_charge";
            comboBox_charge.RightToLeft = RightToLeft.Yes;
            comboBox_charge.Size = new Size(121, 23);
            comboBox_charge.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 162);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "مبلغ (ریال) :";
            // 
            // txt_mablagh
            // 
            txt_mablagh.Location = new Point(54, 154);
            txt_mablagh.Name = "txt_mablagh";
            txt_mablagh.Size = new Size(121, 23);
            txt_mablagh.TabIndex = 8;
            // 
            // btn_continue
            // 
            btn_continue.BackColor = Color.PeachPuff;
            btn_continue.Location = new Point(118, 197);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(142, 23);
            btn_continue.TabIndex = 9;
            btn_continue.Text = "ادامه";
            btn_continue.UseVisualStyleBackColor = false;
            btn_continue.Click += btn_continue_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(270, 274);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "کارت مبدا :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(289, 303);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(41, 15);
            label7.TabIndex = 11;
            label7.Text = "CVV2 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(279, 332);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(51, 15);
            label8.TabIndex = 12;
            label8.Text = "رمز دوم :";
            // 
            // txt_mabda
            // 
            txt_mabda.Enabled = false;
            txt_mabda.Location = new Point(54, 266);
            txt_mabda.Name = "txt_mabda";
            txt_mabda.Size = new Size(121, 23);
            txt_mabda.TabIndex = 13;
            // 
            // txt_cvv2
            // 
            txt_cvv2.Enabled = false;
            txt_cvv2.Location = new Point(54, 295);
            txt_cvv2.Name = "txt_cvv2";
            txt_cvv2.Size = new Size(121, 23);
            txt_cvv2.TabIndex = 14;
            // 
            // txt_ramze2
            // 
            txt_ramze2.Enabled = false;
            txt_ramze2.Location = new Point(54, 324);
            txt_ramze2.Name = "txt_ramze2";
            txt_ramze2.Size = new Size(121, 23);
            txt_ramze2.TabIndex = 15;
            // 
            // btn_ramze2
            // 
            btn_ramze2.BackColor = Color.PeachPuff;
            btn_ramze2.Enabled = false;
            btn_ramze2.Location = new Point(54, 353);
            btn_ramze2.Name = "btn_ramze2";
            btn_ramze2.Size = new Size(121, 23);
            btn_ramze2.TabIndex = 16;
            btn_ramze2.Text = "درخواست رمز پویا";
            btn_ramze2.UseVisualStyleBackColor = false;
            btn_ramze2.Click += btn_ramze2_Click;
            // 
            // btn_pardakht
            // 
            btn_pardakht.BackColor = Color.PeachPuff;
            btn_pardakht.Enabled = false;
            btn_pardakht.Location = new Point(103, 428);
            btn_pardakht.Name = "btn_pardakht";
            btn_pardakht.Size = new Size(172, 29);
            btn_pardakht.TabIndex = 17;
            btn_pardakht.Text = "پرداخت";
            btn_pardakht.UseVisualStyleBackColor = false;
            btn_pardakht.Click += btn_pardakht_Click;
            // 
            // btn_back1
            // 
            btn_back1.BackColor = Color.PeachPuff;
            btn_back1.Location = new Point(118, 463);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(142, 23);
            btn_back1.TabIndex = 18;
            btn_back1.Text = "بازگشت به صفحه اصلی";
            btn_back1.UseVisualStyleBackColor = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // charge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(373, 525);
            Controls.Add(btn_back1);
            Controls.Add(btn_pardakht);
            Controls.Add(btn_ramze2);
            Controls.Add(txt_ramze2);
            Controls.Add(txt_cvv2);
            Controls.Add(txt_mabda);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_continue);
            Controls.Add(txt_mablagh);
            Controls.Add(label5);
            Controls.Add(comboBox_charge);
            Controls.Add(label4);
            Controls.Add(comboBox_operator);
            Controls.Add(label3);
            Controls.Add(txt_phone);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "charge";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_phone;
        private Label label3;
        private ComboBox comboBox_operator;
        private Label label4;
        private ComboBox comboBox_charge;
        private Label label5;
        private TextBox txt_mablagh;
        private Button btn_continue;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_mabda;
        private TextBox txt_cvv2;
        private TextBox txt_ramze2;
        private Button btn_ramze2;
        private Button btn_pardakht;
        private Button btn_back1;
    }
}