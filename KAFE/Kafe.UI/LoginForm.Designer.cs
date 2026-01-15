namespace KAFE
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            kullanıcışifreLabel = new Label();
            Girişbutton = new Button();
            kullanıcıadıTB = new TextBox();
            kullanıcışifreTB = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 757);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(49, 492);
            label4.Name = "label4";
            label4.Size = new Size(209, 38);
            label4.TabIndex = 13;
            label4.Text = "HOŞ GELDİNİZ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(279, 312);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(387, 425);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 20;
            label3.Text = "Kullanıcı Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(398, 351);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 19;
            label2.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(455, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // kullanıcışifreLabel
            // 
            kullanıcışifreLabel.AutoSize = true;
            kullanıcışifreLabel.BackColor = Color.Gray;
            kullanıcışifreLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kullanıcışifreLabel.ForeColor = SystemColors.ButtonHighlight;
            kullanıcışifreLabel.Location = new Point(378, 513);
            kullanıcışifreLabel.Name = "kullanıcışifreLabel";
            kullanıcışifreLabel.Size = new Size(0, 23);
            kullanıcışifreLabel.TabIndex = 14;
            // 
            // Girişbutton
            // 
            Girişbutton.BackColor = Color.Gray;
            Girişbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Girişbutton.ForeColor = SystemColors.ButtonHighlight;
            Girişbutton.Location = new Point(496, 477);
            Girişbutton.Name = "Girişbutton";
            Girişbutton.Size = new Size(167, 59);
            Girişbutton.TabIndex = 17;
            Girişbutton.Text = "Giriş";
            Girişbutton.UseVisualStyleBackColor = false;
            Girişbutton.Click += Girişbutton_Click;
            // 
            // kullanıcıadıTB
            // 
            kullanıcıadıTB.BackColor = SystemColors.ButtonFace;
            kullanıcıadıTB.Location = new Point(542, 351);
            kullanıcıadıTB.Name = "kullanıcıadıTB";
            kullanıcıadıTB.Size = new Size(195, 27);
            kullanıcıadıTB.TabIndex = 15;
            // 
            // kullanıcışifreTB
            // 
            kullanıcışifreTB.BackColor = SystemColors.ButtonFace;
            kullanıcışifreTB.Location = new Point(542, 425);
            kullanıcışifreTB.Name = "kullanıcışifreTB";
            kullanıcışifreTB.PasswordChar = '*';
            kullanıcışifreTB.Size = new Size(195, 27);
            kullanıcışifreTB.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(826, 755);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(kullanıcışifreTB);
            Controls.Add(kullanıcışifreLabel);
            Controls.Add(kullanıcıadıTB);
            Controls.Add(Girişbutton);
            Name = "LoginForm";
            Text = "Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label kullanıcışifreLabel;
        private Button Girişbutton;
        private TextBox kullanıcıadıTB;
        private TextBox kullanıcışifreTB;
    }
}
