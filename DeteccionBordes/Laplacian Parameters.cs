using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeteccionBordes
{
    public partial class Laplacian_Parameters : Form
    {
        Form1 _form3;

        public Laplacian_Parameters()
        {
            InitializeComponent(); 
        }  

        public Laplacian_Parameters(Form1 fm3)
        {
            InitializeComponent();
            _form3 = fm3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form3.ApplyLaplacian((int)numericAppertureSize.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
