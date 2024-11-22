namespace Project_OOP
{
    partial class mojudi
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
            label3 = new Label();
            label4 = new Label();
            txt_cvv2 = new TextBox();
            txt_ramze2 = new TextBox();
            btn_ramze2 = new Button();
            btn_daryaft_mojudi = new Button();
            btn_back1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(222, 47);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "دریافت موجودی";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 152);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "CVV2 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 203);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "رمز دوم :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 82);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(268, 15);
            label4.TabIndex = 3;
            label4.Text = "مبلغ ۱۰۰۰ ریال بابت کارمزد توسط بانک کسر خواهد شد.";
            // 
            // txt_cvv2
            // 
            txt_cvv2.Location = new Point(69, 144);
            txt_cvv2.Name = "txt_cvv2";
            txt_cvv2.Size = new Size(109, 23);
            txt_cvv2.TabIndex = 4;
            // 
            // txt_ramze2
            // 
            txt_ramze2.Enabled = false;
            txt_ramze2.Location = new Point(69, 195);
            txt_ramze2.Name = "txt_ramze2";
            txt_ramze2.Size = new Size(109, 23);
            txt_ramze2.TabIndex = 5;
            // 
            // btn_ramze2
            // 
            btn_ramze2.BackColor = Color.PeachPuff;
            btn_ramze2.Location = new Point(69, 224);
            btn_ramze2.Name = "btn_ramze2";
            btn_ramze2.Size = new Size(109, 23);
            btn_ramze2.TabIndex = 6;
            btn_ramze2.Text = "درخواست رمز پویا";
            btn_ramze2.UseVisualStyleBackColor = false;
            btn_ramze2.Click += btn_ramze2_Click;
            // 
            // btn_daryaft_mojudi
            // 
            btn_daryaft_mojudi.BackColor = Color.PeachPuff;
            btn_daryaft_mojudi.Enabled = false;
            btn_daryaft_mojudi.Location = new Point(112, 322);
            btn_daryaft_mojudi.Name = "btn_daryaft_mojudi";
            btn_daryaft_mojudi.Size = new Size(185, 33);
            btn_daryaft_mojudi.TabIndex = 7;
            btn_daryaft_mojudi.Text = "دریافت موجودی";
            btn_daryaft_mojudi.UseVisualStyleBackColor = false;
            btn_daryaft_mojudi.Click += btn_daryaft_mojudi_Click;
            // 
            // btn_back1
            // 
            btn_back1.BackColor = Color.PeachPuff;
            btn_back1.Location = new Point(128, 361);
            btn_back1.Name = "btn_back1";
            btn_back1.Size = new Size(152, 33);
            btn_back1.TabIndex = 9;
            btn_back1.Text = "بازگشت به صفحه اصلی";
            btn_back1.UseVisualStyleBackColor = false;
            btn_back1.Click += btn_back1_Click;
            // 
            // mojudi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(392, 450);
            Controls.Add(btn_back1);
            Controls.Add(btn_daryaft_mojudi);
            Controls.Add(btn_ramze2);
            Controls.Add(txt_ramze2);
            Controls.Add(txt_cvv2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "mojudi";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_cvv2;
        private TextBox txt_ramze2;
        private Button btn_ramze2;
        private Button btn_daryaft_mojudi;
        private Button btn_back1;
    }
}