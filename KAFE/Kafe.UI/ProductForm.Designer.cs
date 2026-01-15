namespace KAFE
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ürünbilgilerigrb = new GroupBox();
            maliyetTxb = new TextBox();
            maliyetLbl = new Label();
            kategoriTxb = new TextBox();
            stokTxb = new TextBox();
            label2 = new Label();
            minstokTxb = new TextBox();
            minstokLbl = new Label();
            fiyatTxb = new TextBox();
            fiyatLbl = new Label();
            kategoriLbl = new Label();
            ürünadıTxb = new TextBox();
            ürünadıLbl = new Label();
            güncelleBtn = new Button();
            çıkarBtn = new Button();
            ekleBtn = new Button();
            dgvürünler = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ürünbilgilerigrb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvürünler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 763);
            panel1.TabIndex = 21;
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
            label1.Size = new Size(97, 38);
            label1.TabIndex = 7;
            label1.Text = "ÜRÜN";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Location = new Point(414, 24);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 27;
            label3.Text = "Ürün Yönetimi";
            // 
            // ürünbilgilerigrb
            // 
            ürünbilgilerigrb.Controls.Add(maliyetTxb);
            ürünbilgilerigrb.Controls.Add(maliyetLbl);
            ürünbilgilerigrb.Controls.Add(kategoriTxb);
            ürünbilgilerigrb.Controls.Add(stokTxb);
            ürünbilgilerigrb.Controls.Add(label2);
            ürünbilgilerigrb.Controls.Add(minstokTxb);
            ürünbilgilerigrb.Controls.Add(minstokLbl);
            ürünbilgilerigrb.Controls.Add(fiyatTxb);
            ürünbilgilerigrb.Controls.Add(fiyatLbl);
            ürünbilgilerigrb.Controls.Add(kategoriLbl);
            ürünbilgilerigrb.Controls.Add(ürünadıTxb);
            ürünbilgilerigrb.Controls.Add(ürünadıLbl);
            ürünbilgilerigrb.Location = new Point(436, 387);
            ürünbilgilerigrb.Name = "ürünbilgilerigrb";
            ürünbilgilerigrb.Size = new Size(350, 279);
            ürünbilgilerigrb.TabIndex = 23;
            ürünbilgilerigrb.TabStop = false;
            ürünbilgilerigrb.Text = "Ürün Bilgileri";
            // 
            // maliyetTxb
            // 
            maliyetTxb.Location = new Point(90, 234);
            maliyetTxb.Name = "maliyetTxb";
            maliyetTxb.Size = new Size(152, 27);
            maliyetTxb.TabIndex = 14;
            // 
            // maliyetLbl
            // 
            maliyetLbl.AutoSize = true;
            maliyetLbl.BackColor = Color.DarkGray;
            maliyetLbl.Location = new Point(11, 241);
            maliyetLbl.Name = "maliyetLbl";
            maliyetLbl.Size = new Size(61, 20);
            maliyetLbl.TabIndex = 13;
            maliyetLbl.Text = "Maliyet:";
            // 
            // kategoriTxb
            // 
            kategoriTxb.Location = new Point(90, 78);
            kategoriTxb.Name = "kategoriTxb";
            kategoriTxb.Size = new Size(151, 27);
            kategoriTxb.TabIndex = 10;
            // 
            // stokTxb
            // 
            stokTxb.Location = new Point(89, 151);
            stokTxb.Name = "stokTxb";
            stokTxb.Size = new Size(152, 27);
            stokTxb.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(36, 158);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 8;
            label2.Text = "Stok";
            // 
            // minstokTxb
            // 
            minstokTxb.Location = new Point(89, 187);
            minstokTxb.Name = "minstokTxb";
            minstokTxb.Size = new Size(152, 27);
            minstokTxb.TabIndex = 7;
            // 
            // minstokLbl
            // 
            minstokLbl.AutoSize = true;
            minstokLbl.BackColor = Color.DarkGray;
            minstokLbl.Location = new Point(4, 194);
            minstokLbl.Name = "minstokLbl";
            minstokLbl.Size = new Size(70, 20);
            minstokLbl.TabIndex = 6;
            minstokLbl.Text = "Min Stok:";
            // 
            // fiyatTxb
            // 
            fiyatTxb.Location = new Point(89, 112);
            fiyatTxb.Name = "fiyatTxb";
            fiyatTxb.Size = new Size(152, 27);
            fiyatTxb.TabIndex = 5;
            // 
            // fiyatLbl
            // 
            fiyatLbl.AutoSize = true;
            fiyatLbl.BackColor = Color.DarkGray;
            fiyatLbl.Location = new Point(31, 119);
            fiyatLbl.Name = "fiyatLbl";
            fiyatLbl.Size = new Size(43, 20);
            fiyatLbl.TabIndex = 4;
            fiyatLbl.Text = "Fiyat:";
            // 
            // kategoriLbl
            // 
            kategoriLbl.AutoSize = true;
            kategoriLbl.BackColor = Color.DarkGray;
            kategoriLbl.Location = new Point(4, 80);
            kategoriLbl.Name = "kategoriLbl";
            kategoriLbl.Size = new Size(69, 20);
            kategoriLbl.TabIndex = 2;
            kategoriLbl.Text = "Kategori:";
            // 
            // ürünadıTxb
            // 
            ürünadıTxb.Location = new Point(89, 33);
            ürünadıTxb.Name = "ürünadıTxb";
            ürünadıTxb.Size = new Size(152, 27);
            ürünadıTxb.TabIndex = 1;
            // 
            // ürünadıLbl
            // 
            ürünadıLbl.AutoSize = true;
            ürünadıLbl.BackColor = Color.DarkGray;
            ürünadıLbl.Location = new Point(6, 40);
            ürünadıLbl.Name = "ürünadıLbl";
            ürünadıLbl.Size = new Size(68, 20);
            ürünadıLbl.TabIndex = 0;
            ürünadıLbl.Text = "Ürün adı:";
            // 
            // güncelleBtn
            // 
            güncelleBtn.BackColor = Color.Maroon;
            güncelleBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            güncelleBtn.ForeColor = SystemColors.ButtonHighlight;
            güncelleBtn.Location = new Point(814, 506);
            güncelleBtn.Name = "güncelleBtn";
            güncelleBtn.Size = new Size(94, 29);
            güncelleBtn.TabIndex = 26;
            güncelleBtn.Text = "Güncelle";
            güncelleBtn.UseVisualStyleBackColor = false;
            güncelleBtn.Click += güncelleBtn_Click;
            // 
            // çıkarBtn
            // 
            çıkarBtn.BackColor = Color.Maroon;
            çıkarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            çıkarBtn.ForeColor = SystemColors.ButtonHighlight;
            çıkarBtn.Location = new Point(814, 467);
            çıkarBtn.Name = "çıkarBtn";
            çıkarBtn.Size = new Size(94, 29);
            çıkarBtn.TabIndex = 25;
            çıkarBtn.Text = "Çıkar";
            çıkarBtn.UseVisualStyleBackColor = false;
            çıkarBtn.Click += çıkarBtn_Click;
            // 
            // ekleBtn
            // 
            ekleBtn.BackColor = Color.Maroon;
            ekleBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ekleBtn.ForeColor = SystemColors.ButtonHighlight;
            ekleBtn.Location = new Point(814, 427);
            ekleBtn.Name = "ekleBtn";
            ekleBtn.Size = new Size(94, 29);
            ekleBtn.TabIndex = 24;
            ekleBtn.Text = "Ekle";
            ekleBtn.UseVisualStyleBackColor = false;
            ekleBtn.Click += ekleBtn_Click;
            // 
            // dgvürünler
            // 
            dgvürünler.AllowUserToAddRows = false;
            dgvürünler.BackgroundColor = Color.WhiteSmoke;
            dgvürünler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvürünler.Location = new Point(408, 51);
            dgvürünler.Name = "dgvürünler";
            dgvürünler.RowHeadersWidth = 51;
            dgvürünler.Size = new Size(588, 291);
            dgvürünler.TabIndex = 22;
            dgvürünler.CellClick += dgvürünler_CellClick;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1062, 738);
            Controls.Add(label3);
            Controls.Add(ürünbilgilerigrb);
            Controls.Add(güncelleBtn);
            Controls.Add(çıkarBtn);
            Controls.Add(ekleBtn);
            Controls.Add(dgvürünler);
            Controls.Add(panel1);
            Name = "ProductForm";
            Text = "Ürün";
            Load += ProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ürünbilgilerigrb.ResumeLayout(false);
            ürünbilgilerigrb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvürünler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private GroupBox ürünbilgilerigrb;
        private TextBox kategoriTxb;
        private TextBox stokTxb;
        private Label label2;
        private TextBox minstokTxb;
        private Label minstokLbl;
        private TextBox fiyatTxb;
        private Label fiyatLbl;
        private Label kategoriLbl;
        private TextBox ürünadıTxb;
        private Label ürünadıLbl;
        private Button güncelleBtn;
        private Button çıkarBtn;
        private Button ekleBtn;
        private DataGridView dgvürünler;
        private TextBox maliyetTxb;
        private Label maliyetLbl;
    }
}