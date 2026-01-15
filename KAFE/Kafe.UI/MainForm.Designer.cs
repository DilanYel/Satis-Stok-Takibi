
namespace KAFE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            çıkışbutton = new Button();
            pictureBox1 = new PictureBox();
            raporbtn = new Button();
            satışbtn = new Button();
            müşteribtn = new Button();
            Ürünbtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            tarihLbl = new Label();
            rolLbl = new Label();
            hoşgeldinlBL = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // çıkışbutton
            // 
            çıkışbutton.BackColor = Color.DarkGray;
            çıkışbutton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            çıkışbutton.ForeColor = Color.Maroon;
            çıkışbutton.Location = new Point(42, 648);
            çıkışbutton.Name = "çıkışbutton";
            çıkışbutton.Size = new Size(335, 90);
            çıkışbutton.TabIndex = 32;
            çıkışbutton.Text = "ÇIKIŞ";
            çıkışbutton.UseVisualStyleBackColor = false;
            çıkışbutton.Click += çıkışbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // raporbtn
            // 
            raporbtn.BackColor = Color.DarkGray;
            raporbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            raporbtn.ForeColor = Color.Maroon;
            raporbtn.Location = new Point(42, 552);
            raporbtn.Name = "raporbtn";
            raporbtn.Size = new Size(335, 90);
            raporbtn.TabIndex = 31;
            raporbtn.Text = "RAPORLAMALAR\r\n";
            raporbtn.UseVisualStyleBackColor = false;
            raporbtn.Click += raporbtn_Click;
            // 
            // satışbtn
            // 
            satışbtn.BackColor = Color.DarkGray;
            satışbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            satışbtn.ForeColor = Color.Maroon;
            satışbtn.Location = new Point(42, 360);
            satışbtn.Name = "satışbtn";
            satışbtn.Size = new Size(335, 90);
            satışbtn.TabIndex = 30;
            satışbtn.Text = "SATIŞ";
            satışbtn.UseVisualStyleBackColor = false;
            satışbtn.Click += satışbtn_Click;
            // 
            // müşteribtn
            // 
            müşteribtn.BackColor = Color.DarkGray;
            müşteribtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            müşteribtn.ForeColor = Color.Maroon;
            müşteribtn.Location = new Point(42, 456);
            müşteribtn.Name = "müşteribtn";
            müşteribtn.Size = new Size(335, 90);
            müşteribtn.TabIndex = 29;
            müşteribtn.Text = "MÜŞTERİ";
            müşteribtn.UseVisualStyleBackColor = false;
            müşteribtn.Click += müşteribtn_Click;
            // 
            // Ürünbtn
            // 
            Ürünbtn.BackColor = Color.DarkGray;
            Ürünbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Ürünbtn.ForeColor = Color.Maroon;
            Ürünbtn.Location = new Point(42, 264);
            Ürünbtn.Name = "Ürünbtn";
            Ürünbtn.Size = new Size(335, 90);
            Ürünbtn.TabIndex = 28;
            Ürünbtn.Text = "ÜRÜN";
            Ürünbtn.UseVisualStyleBackColor = false;
            Ürünbtn.Click += Ürünbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(çıkışbutton);
            panel1.Controls.Add(Ürünbtn);
            panel1.Controls.Add(müşteribtn);
            panel1.Controls.Add(raporbtn);
            panel1.Controls.Add(satışbtn);
            panel1.Location = new Point(-7, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 763);
            panel1.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(tarihLbl);
            panel2.Controls.Add(rolLbl);
            panel2.Controls.Add(hoşgeldinlBL);
            panel2.Location = new Point(474, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 139);
            panel2.TabIndex = 34;
            // 
            // tarihLbl
            // 
            tarihLbl.AutoSize = true;
            tarihLbl.BackColor = Color.DarkGray;
            tarihLbl.Location = new Point(69, 98);
            tarihLbl.Name = "tarihLbl";
            tarihLbl.Size = new Size(50, 20);
            tarihLbl.TabIndex = 25;
            tarihLbl.Text = "label2";
            // 
            // rolLbl
            // 
            rolLbl.AutoSize = true;
            rolLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            rolLbl.ForeColor = Color.Maroon;
            rolLbl.Location = new Point(69, 58);
            rolLbl.Name = "rolLbl";
            rolLbl.Size = new Size(48, 28);
            rolLbl.TabIndex = 24;
            rolLbl.Text = "Rol:";
            // 
            // hoşgeldinlBL
            // 
            hoşgeldinlBL.AutoSize = true;
            hoşgeldinlBL.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            hoşgeldinlBL.ForeColor = Color.Maroon;
            hoşgeldinlBL.Location = new Point(53, 20);
            hoşgeldinlBL.Name = "hoşgeldinlBL";
            hoşgeldinlBL.Size = new Size(158, 38);
            hoşgeldinlBL.TabIndex = 23;
            hoşgeldinlBL.Text = "Hoşgeldin,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(409, 75);
            label1.Name = "label1";
            label1.Size = new Size(662, 64);
            label1.TabIndex = 36;
            label1.Text = "Birlikte düzen, birlikte başarı.\nBurası hepimizin — Rıhtım’da ufak bir mola.";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Silver;
            richTextBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Location = new Point(486, 392);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(442, 223);
            richTextBox1.TabIndex = 37;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1062, 738);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Ana Menü";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void raporbtn_Click(object sender, EventArgs e)
        {
            var frm = new RaportForm();
            frm.Show();
        }
        private void çıkışbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private Button çıkışbutton;
        private PictureBox pictureBox1;
        private Button raporbtn;
        private Button satışbtn;
        private Button müşteribtn;
        private Button Ürünbtn;
        private Panel panel1;
        private Panel panel2;
        private Label tarihLbl;
        private Label rolLbl;
        private Label hoşgeldinlBL;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}