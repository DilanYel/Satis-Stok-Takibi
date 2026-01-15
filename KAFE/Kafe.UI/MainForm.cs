using KAFE.Kafe.DOMAİN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAFE
{
    public partial class MainForm : Form
    {
        private kullanıcı _aktifkullanıcı;
        private LoginForm _login;
        private LoginForm? login;

        public MainForm(KAFE.Kafe.DOMAİN.kullanıcı aktifkullanıcı, LoginForm loginForm)
        {
            InitializeComponent();
            _aktifkullanıcı = aktifkullanıcı;
            _login = login;
            hoşgeldinlBL.Text = "Hoş geldin, " + _aktifkullanıcı.kullanıcıAdı + "!";
            rolLbl.Text = "Rol: " + _aktifkullanıcı.Rol;
            tarihLbl.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd HH:mm");
            Yetkilendir();
        }   

        private void Yetkilendir()
        {
            Ürünbtn.Enabled = false;
            müşteribtn.Enabled = false;
            satışbtn.Enabled = false;
            raporbtn.Enabled = false;
            çıkışbutton.Enabled = true;
            if (_aktifkullanıcı.Rol == kullanıcıRol.yönetici)
            {
                Ürünbtn.Enabled = true;
                müşteribtn.Enabled = true;
                satışbtn.Enabled = true;
                raporbtn.Enabled = true;
            }
            else if (_aktifkullanıcı.Rol == kullanıcıRol.satışpersoneli)
            {
                Ürünbtn.Enabled= true;
                müşteribtn.Enabled = true;
                satışbtn.Enabled = true;
            }
            else if (_aktifkullanıcı.Rol == kullanıcıRol.depopersoneli)
            {
                Ürünbtn.Enabled = true;
            }
        }
        private void müşteribtn_Click(object sender, EventArgs e)
        {
            CustomerForm müşteriform = new CustomerForm();
            müşteriform.Show();
        }


        private void Ürünbtn_Click(object sender, EventArgs e)
        {

            ProductForm ürünform = new ProductForm();
            ürünform.Show();
        }

        private void satışbtn_Click(object sender, EventArgs e)
        {
            SalesForm satışform = new SalesForm();
            satışform.Show();
        }

        private void raporbtn_Click_1(object sender, EventArgs e)
        {
            RaportForm raporform = new RaportForm();
            raporform.Show();
        }
      
        private void çıkışbutton_Click_1(object sender, EventArgs e)
        {
           _login.Show();
            this.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tarihLbl.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd HH:mm");
        }

       
    }


}

