using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Magazin
{
    public partial class MesajForm : Form
    {
        public MesajForm (string mesaj, string imagine)
        {
            InitializeComponent();
            lblMesaj.Text = mesaj;
            lblMesaj.Left = (this.Width - lblMesaj.Width) / 2;

            string caleImagine = Path.Combine(Application.StartupPath, "produse", imagine);
            pbImagine.Image = Image.FromFile(caleImagine);
            pbImagine.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagine.Left = (this.Width - pbImagine.Width) / 2;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panelIncarca.Width += 45;
            if (panelIncarca.Width >= 555)
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
