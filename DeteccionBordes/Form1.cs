using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace DeteccionBordes
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = imgInput;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                this.Close();


            }
        }

        private void caniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyCanny();
            
        }

        public void ApplyCanny(double thresh = 50.0, double threshlink = 20.0)
        {
            if (imgInput == null)
            {

                return;
            }
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray());
            imgCanny = imgInput.Canny(thresh, threshlink);
            imageBox1.Image = imgCanny;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplySobel();
        }

        public void ApplySobel(int xorder = 3, int yorder = 3, int apertureSize = 1)
        {
            Image<Gray, byte> _imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            _imgSobel = _imgGray.Sobel(xorder, yorder, apertureSize);
            imageBox1.Image = _imgSobel;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyLaplacian();
        }

        public void ApplyLaplacian (int apertureSize = 1)
        {
            Image<Gray, byte> _imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgLapla = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));
            _imgLapla = _imgGray.Laplace(apertureSize);
            imageBox1.Image = _imgLapla;

        }

        private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyParameters cp = new DeteccionBordes.CannyParameters(this);
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.Show();
        }

        private void sobelParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobel_Parameters sp = new DeteccionBordes.Sobel_Parameters(this);
            sp.StartPosition = FormStartPosition.CenterParent;
            sp.Show();
        }

        private void laplacianParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Laplacian_Parameters lp = new DeteccionBordes.Laplacian_Parameters(this);
            lp.StartPosition = FormStartPosition.CenterParent;
            lp.Show();
        }
    }
}
