namespace Project_OOP
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            label1 = new Label();
            label2 = new Label();
            btn_exit = new Button();
            label3 = new Label();
            btn_mojudi = new Button();
            btn_cardbcard = new Button();
            btn_net = new Button();
            btn_charge = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 57);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(174, 17);
            label1.TabIndex = 0;
            label1.Text = "به پنل کاربری خود خوش آمدید!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(252, 21);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "همراه بانک";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.PeachPuff;
            btn_exit.Location = new Point(47, 21);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(58, 25);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "خروج ";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 297);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 6;
            label3.Text = "خدمات";
            // 
            // btn_mojudi
            // 
            btn_mojudi.BackColor = Color.PeachPuff;
            btn_mojudi.Location = new Point(203, 341);
            btn_mojudi.Name = "btn_mojudi";
            btn_mojudi.Size = new Size(117, 40);
            btn_mojudi.TabIndex = 7;
            btn_mojudi.Text = "موجودی";
            btn_mojudi.UseVisualStyleBackColor = false;
            btn_mojudi.Click += btn_mojudi_Click;
            // 
            // btn_cardbcard
            // 
            btn_cardbcard.BackColor = Color.PeachPuff;
            btn_cardbcard.Location = new Point(47, 341);
            btn_cardbcard.Name = "btn_cardbcard";
            btn_cardbcard.Size = new Size(117, 40);
            btn_cardbcard.TabIndex = 8;
            btn_cardbcard.Text = "کارت به کارت";
            btn_cardbcard.UseVisualStyleBackColor = false;
            btn_cardbcard.Click += btn_cardbcard_Click;
            // 
            // btn_net
            // 
            btn_net.BackColor = Color.PeachPuff;
            btn_net.Location = new Point(203, 387);
            btn_net.Name = "btn_net";
            btn_net.Size = new Size(117, 40);
            btn_net.TabIndex = 9;
            btn_net.Text = "بسته اینترنت";
            btn_net.UseVisualStyleBackColor = false;
            btn_net.Click += btn_net_Click_1;
            // 
            // btn_charge
            // 
            btn_charge.BackColor = Color.PeachPuff;
            btn_charge.Location = new Point(47, 387);
            btn_charge.Name = "btn_charge";
            btn_charge.Size = new Size(117, 40);
            btn_charge.TabIndex = 10;
            btn_charge.Text = "شارژ";
            btn_charge.UseVisualStyleBackColor = false;
            btn_charge.Click += btn_charge_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(80, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 135);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(382, 495);
            Controls.Add(pictureBox2);
            Controls.Add(btn_charge);
            Controls.Add(btn_net);
            Controls.Add(btn_cardbcard);
            Controls.Add(btn_mojudi);
            Controls.Add(label3);
            Controls.Add(btn_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "main";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_exit;
        private Label label3;
        private Button btn_mojudi;
        private Button btn_cardbcard;
        private Button btn_net;
        private Button btn_charge;
        private PictureBox pictureBox2;
    }
}