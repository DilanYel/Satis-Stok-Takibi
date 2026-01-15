namespace KAFE
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            Btnsil = new Button();
            Btnekle = new Button();
            müşteribilgiGb = new GroupBox();
            türCb = new ComboBox();
            label3 = new Label();
            müşteriadıTxb = new TextBox();
            label2 = new Label();
            dgvmüşteriler = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            müşteribilgiGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmüşteriler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 763);
            panel1.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(121, 479);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 7;
            label1.Text = "MÜŞTERİ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 60);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 32;
            label4.Text = "Müşteri Listesi";
            // 
            // Btnsil
            // 
            Btnsil.BackColor = Color.Maroon;
            Btnsil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Btnsil.ForeColor = SystemColors.ButtonHighlight;
            Btnsil.Location = new Point(929, 362);
            Btnsil.Name = "Btnsil";
            Btnsil.Size = new Size(94, 29);
            Btnsil.TabIndex = 31;
            Btnsil.Text = "Sil";
            Btnsil.UseVisualStyleBackColor = false;
            Btnsil.Click += Btnsil_Click;
            // 
            // Btnekle
            // 
            Btnekle.BackColor = Color.Maroon;
            Btnekle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Btnekle.ForeColor = SystemColors.ButtonHighlight;
            Btnekle.Location = new Point(794, 362);
            Btnekle.Name = "Btnekle";
            Btnekle.Size = new Size(94, 29);
            Btnekle.TabIndex = 30;
            Btnekle.Text = "Ekle";
            Btnekle.UseVisualStyleBackColor = false;
            Btnekle.Click += Btnekle_Click;
            // 
            // müşteribilgiGb
            // 
            müşteribilgiGb.Controls.Add(türCb);
            müşteribilgiGb.Controls.Add(label3);
            müşteribilgiGb.Controls.Add(müşteriadıTxb);
            müşteribilgiGb.Controls.Add(label2);
            müşteribilgiGb.Location = new Point(734, 161);
            müşteribilgiGb.Name = "müşteribilgiGb";
            müşteribilgiGb.Size = new Size(311, 178);
            müşteribilgiGb.TabIndex = 29;
            müşteribilgiGb.TabStop = false;
            müşteribilgiGb.Text = "Müşteri Bilgileri";
            // 
            // türCb
            // 
            türCb.FormattingEnabled = true;
            türCb.Items.AddRange(new object[] { "Bireysel", "Gel-Al" });
            türCb.Location = new Point(105, 74);
            türCb.Name = "türCb";
            türCb.Size = new Size(151, 28);
            türCb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Location = new Point(5, 77);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Müşteri Türü:";
            // 
            // müşteriadıTxb
            // 
            müşteriadıTxb.Location = new Point(105, 31);
            müşteriadıTxb.Name = "müşteriadıTxb";
            müşteriadıTxb.Size = new Size(151, 27);
            müşteriadıTxb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(11, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Müşteri Adı:";
            // 
            // dgvmüşteriler
            // 
            dgvmüşteriler.AllowUserToAddRows = false;
            dgvmüşteriler.BackgroundColor = Color.WhiteSmoke;
            dgvmüşteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmüşteriler.Location = new Point(401, 98);
            dgvmüşteriler.MultiSelect = false;
            dgvmüşteriler.Name = "dgvmüşteriler";
            dgvmüşteriler.ReadOnly = true;
            dgvmüşteriler.RowHeadersWidth = 51;
            dgvmüşteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvmüşteriler.Size = new Size(308, 512);
            dgvmüşteriler.TabIndex = 28;
            dgvmüşteriler.CellContentClick += dgvmüşteriler_CellContentClick;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1062, 738);
            Controls.Add(label4);
            Controls.Add(Btnsil);
            Controls.Add(Btnekle);
            Controls.Add(müşteribilgiGb);
            Controls.Add(dgvmüşteriler);
            Controls.Add(panel1);
            Name = "CustomerForm";
            Text = "Müşteri";
            Load += CustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            müşteribilgiGb.ResumeLayout(false);
            müşteribilgiGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmüşteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button Btnsil;
        private Button Btnekle;
        private GroupBox müşteribilgiGb;
        private ComboBox türCb;
        private Label label3;
        private TextBox müşteriadıTxb;
        private Label label2;
        private DataGridView dgvmüşteriler;
    }
}