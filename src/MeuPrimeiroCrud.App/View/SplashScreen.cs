using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeuPrimeiroCrud.View.View
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        PictureBox[] pictureBox;
        int count = 0;
        int count2 = 0;

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Enabled = true;
            pictureBox = new PictureBox[8] { P1, P2, P3, P4, P5, P6, P7, P8 };
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (count < 8)
            {
                pictureBox[count].Visible = true;
                if (count2 == 1)
                {
                    timerSplash.Interval = 300;
                    pictureBox[count].BackgroundImage = Properties.Resources.Image2;
                    pictureBox[count].Size = new Size(13, 13);
                }
                count++;
            }
            else if (count2 < 1)
            {
                count = 0;
                count2++;
            }
            else
            {
                timerSplash.Enabled = false;
                Hide();
                var pesquisaClientes = new PesquisaClientes();
                pesquisaClientes.Show();
            }
        }
    }
}
