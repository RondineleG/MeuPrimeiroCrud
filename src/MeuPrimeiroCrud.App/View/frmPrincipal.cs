using System;
using System.Windows.Forms;

namespace BurgerPDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFeichar_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMininizar_Click(Object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
