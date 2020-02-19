using System.Windows.Forms;

namespace MySAT
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }
    }
}
