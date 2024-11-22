namespace Project_OOP
{
    partial class cardbcard
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
            txt_mabda = new TextBox();
            label3 = new Label();
            txt_maghsad = new TextBox();
            txt_mablagh = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_cvv2 = new TextBox();
            label6 = new Label();
            txt_ramze2 = new TextBox();
            btn_ramze2 = new Button();
            btn_enteghal = new Button();
            btn_back1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(224, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "کارت به کارت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 92);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "کارت مبدا :";
            // 
            // txt_mabda
            // 
            txt_mabda.Location = new Point(58, 84);
            txt_mabda.Name = "txt_mabda";
            txt_mabda.Size = new Size(117, 23);
            txt_mabda.TabIndex = 2;
            txt_mabda.Text = "0012 3456 7890 9870";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 121);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(71, 15);
            label3.TabIndex = 3;
            label3.Text = "کارت مقصد :";
            // 
            // txt_maghsad
            // 
            txt_maghsad.Location = new Point(58, 113);
            txt_maghsad.Name = "txt_maghsad";
            txt_maghsad.Size = new Size(117, 23);
            txt_maghsad.TabIndex = 4;
            // 
            // txt_mablagh
            // 
            txt_mablagh.Location = new Point(58, 142);
            txt_mablagh.Name = "txt_mablagh";
            txt_mablagh.Size = new Size(117, 23);
            txt_mablagh.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 150);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "مبلغ (ریال) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 225);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "CVV2 :";
            // 
            // txt_cvv2
            // 
            txt_cvv2.Location = new Point(58, 217);
            txt_cvv2.Name = "txt_cvv2";
            txt_cvv2.Size = new Size(117, 23);
            txt_cvv2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 254);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "رمز دوم :";
            // 
            // txt_ramze2
            // 
            txt_ramze2.Enabled = false;
            txt_ramze2.Location = new Point(58, 246);
            txt_ramze2.Name = "txt_ramze2";
            txt_ramze2.Size = new Size(117, 23);
            txt_ramze2.TabIndex = 10;
            // 
            // btn_ramze2
            // 
            btn_ramze2.BackColor = Color.PeachPuff;
            btn_ramze2.Location = new Point(58, 275);
            btn_ramze2.Name = "btn_ramze2";
            btn_ramze2.Size = new Size(117, 26);
            btn_ramze2.TabIndex = 11;
            btn_ramze2.Text = "درخواست رمز پویا";
            btn_ramze2.UseVisualStyleBackColor = false;
            btn_ramze2.Click += btn_ramze2_Click;
            // 
            // btn_enteghal
            // 
            btn_enteghal.BackColor = Color.PeachPuff;
            btn_enteghal.Enabled = false;
            btn_enteghal.Location = new Point(111, 346);
            btn_enteghal.Name = "btn_enteghal";
            btn_enteghal.Size = new Size(158, 33);
            btn_enteghal.TabIndex = 12;
            btn_enteghal.Text = "انتقال";
            btn_enteghal.UseVisualStyleBackColor = false;
            btn_enteghal.Click += btn_enteghal_Click;
            // 
            // btn_back1
            // 
            btn_back1.BackColor = Color.PeachPuff;
            btn_back1.Location = new Point(124, 385);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(132, 33);
            btn_back1.TabIndex = 13;
            btn_back1.Text = "بازگشت به صفحه اصلی";
            btn_back1.UseVisualStyleBackColor = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // cardbcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(383, 450);
            Controls.Add(btn_back1);
            Controls.Add(btn_enteghal);
            Controls.Add(btn_ramze2);
            Controls.Add(txt_ramze2);
            Controls.Add(label6);
            Controls.Add(txt_cvv2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_mablagh);
            Controls.Add(txt_maghsad);
            Controls.Add(label3);
            Controls.Add(txt_mabda);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cardbcard";
            Text = "cardbcard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_mabda;
        private Label label3;
        private TextBox txt_maghsad;
        private TextBox txt_mablagh;
        private Label label4;
        private Label label5;
        private TextBox txt_cvv2;
        private Label label6;
        private TextBox txt_ramze2;
        private Button btn_ramze2;
        private Button btn_enteghal;
        private Button btn_back1;
    }
}