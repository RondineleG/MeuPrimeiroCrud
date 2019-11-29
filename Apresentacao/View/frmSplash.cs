using System;
using System.Drawing;
using System.Windows.Forms;

namespace Apresentacao.View
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        //Declaração da matriz
        PictureBox[] pictureBox; 
        int count = 0;
        int count2 = 0;

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Enabled = true;
            pictureBox = new PictureBox[8] { P1, P2, P3, P4, P5, P6, P7, P8 };
        }

        private void timerSplash_Tick (object sender, EventArgs e)
        {
         
            if (count < 8)
            {
                pictureBox[count].Visible = true;
                if (count2 == 1)
                {
                   timerSplash.Interval = 500;
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
                this.Hide();
                frmPesquisaClientes frmMenu = new frmPesquisaClientes();
                frmMenu.Show();
             }
 }

} 
    
}
