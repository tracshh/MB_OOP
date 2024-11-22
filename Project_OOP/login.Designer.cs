namespace Project_OOP
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_input_username = new TextBox();
            txt_input_pass = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "همراه بانک";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(238, 114);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "نام کاربری :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(241, 158);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(60, 17);
            label3.TabIndex = 2;
            label3.Text = "رمز عبور :";
            // 
            // txt_input_username
            // 
            txt_input_username.Location = new Point(67, 109);
            txt_input_username.Name = "txt_input_username";
            txt_input_username.Size = new Size(100, 23);
            txt_input_username.TabIndex = 3;
            // 
            // txt_input_pass
            // 
            txt_input_pass.Location = new Point(67, 153);
            txt_input_pass.Name = "txt_input_pass";
            txt_input_pass.Size = new Size(100, 23);
            txt_input_pass.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.PeachPuff;
            btn_login.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(108, 220);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(148, 30);
            btn_login.TabIndex = 5;
            btn_login.Text = "ورود";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(374, 353);
            Controls.Add(btn_login);
            Controls.Add(txt_input_pass);
            Controls.Add(txt_input_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_input_username;
        private TextBox txt_input_pass;
        private Button btn_login;
    }
}