using KAFE.Kafe.BLL;
using KAFE.Kafe.DOMAÝN;

namespace KAFE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Giriþbutton_Click(object sender, EventArgs e)
        {
            try
            {
                kullanýcýgiriþBLL bll = new kullanýcýgiriþBLL();
                kullanýcý aktifkullanýcý = bll.giriþYapankullanýcý(kullanýcýadýTB.Text, kullanýcýþifreTB.Text);
                MainForm anaform = new MainForm(aktifkullanýcý,this);
                anaform.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
