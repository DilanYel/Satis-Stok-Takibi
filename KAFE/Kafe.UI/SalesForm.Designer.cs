namespace KAFE
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            adetTxb = new TextBox();
            adetLbl = new Label();
            ürünCb = new ComboBox();
            müşteriLbl = new Label();
            fiyatTxb = new TextBox();
            müşteriCb = new ComboBox();
            fiyatLbl = new Label();
            sipariştamamBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            dgvsatış = new DataGridView();
            ekleBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvsatış).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 763);
            panel1.TabIndex = 23;
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
            label1.Size = new Size(92, 38);
            label1.TabIndex = 7;
            label1.Text = "SATIŞ";
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
            // adetTxb
            // 
            adetTxb.Location = new Point(994, 147);
            adetTxb.Name = "adetTxb";
            adetTxb.Size = new Size(58, 27);
            adetTxb.TabIndex = 47;
            // 
            // adetLbl
            // 
            adetLbl.AutoSize = true;
            adetLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            adetLbl.Location = new Point(936, 147);
            adetLbl.Name = "adetLbl";
            adetLbl.Size = new Size(50, 23);
            adetLbl.TabIndex = 48;
            adetLbl.Text = "Adet:";
            // 
            // ürünCb
            // 
            ürünCb.FormattingEnabled = true;
            ürünCb.Location = new Point(712, 146);
            ürünCb.Name = "ürünCb";
            ürünCb.Size = new Size(92, 28);
            ürünCb.TabIndex = 49;
            ürünCb.SelectedIndexChanged += ürünCb_SelectedIndexChanged;
            // 
            // müşteriLbl
            // 
            müşteriLbl.AutoSize = true;
            müşteriLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            müşteriLbl.Location = new Point(376, 151);
            müşteriLbl.Name = "müşteriLbl";
            müşteriLbl.Size = new Size(120, 23);
            müşteriLbl.TabIndex = 42;
            müşteriLbl.Text = "MüşteriSeçimi:";
            // 
            // fiyatTxb
            // 
            fiyatTxb.Location = new Point(865, 145);
            fiyatTxb.Name = "fiyatTxb";
            fiyatTxb.Size = new Size(65, 27);
            fiyatTxb.TabIndex = 46;
            // 
            // müşteriCb
            // 
            müşteriCb.FormattingEnabled = true;
            müşteriCb.Location = new Point(502, 148);
            müşteriCb.Name = "müşteriCb";
            müşteriCb.Size = new Size(92, 28);
            müşteriCb.TabIndex = 44;
            // 
            // fiyatLbl
            // 
            fiyatLbl.AutoSize = true;
            fiyatLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fiyatLbl.Location = new Point(810, 149);
            fiyatLbl.Name = "fiyatLbl";
            fiyatLbl.Size = new Size(49, 23);
            fiyatLbl.TabIndex = 45;
            fiyatLbl.Text = "Fiyat:";
            // 
            // sipariştamamBtn
            // 
            sipariştamamBtn.BackColor = Color.Maroon;
            sipariştamamBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sipariştamamBtn.ForeColor = SystemColors.ButtonHighlight;
            sipariştamamBtn.Location = new Point(884, 558);
            sipariştamamBtn.Name = "sipariştamamBtn";
            sipariştamamBtn.Size = new Size(154, 42);
            sipariştamamBtn.TabIndex = 53;
            sipariştamamBtn.Text = "Siparişi Tamamla";
            sipariştamamBtn.UseVisualStyleBackColor = false;
            sipariştamamBtn.Click += sipariştamamBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(600, 151);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 43;
            label2.Text = "Ürün Seçimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 273);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 52;
            label3.Text = "Adisyon";
            // 
            // dgvsatış
            // 
            dgvsatış.BackgroundColor = Color.WhiteSmoke;
            dgvsatış.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsatış.Location = new Point(392, 308);
            dgvsatış.Name = "dgvsatış";
            dgvsatış.RowHeadersWidth = 51;
            dgvsatış.Size = new Size(646, 233);
            dgvsatış.TabIndex = 51;
            // 
            // ekleBtn
            // 
            ekleBtn.BackColor = Color.Maroon;
            ekleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekleBtn.ForeColor = SystemColors.ButtonHighlight;
            ekleBtn.Location = new Point(952, 192);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(100, 45);
            ekleBtn.TabIndex = 50;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = false;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1062, 738);
            Controls.Add(adetTxb);
            Controls.Add(adetLbl);
            Controls.Add(ürünCb);
            Controls.Add(müşteriLbl);
            Controls.Add(fiyatTxb);
            Controls.Add(müşteriCb);
            Controls.Add(fiyatLbl);
            Controls.Add(sipariştamamBtn);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dgvsatış);
            Controls.Add(ekleBtn);
            Controls.Add(panel1);
            Name = "SalesForm";
            Text = "Satış";
            Load += SalesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvsatış).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox adetTxb;
        private Label adetLbl;
        private ComboBox ürünCb;
        private Label müşteriLbl;
        private TextBox fiyatTxb;
        private ComboBox müşteriCb;
        private Label fiyatLbl;
        private Button sipariştamamBtn;
        private Label label2;
        private Label label3;
        private DataGridView dgvsatış;
        private Button ekleBtn;
    }
}