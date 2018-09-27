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
    public partial class Sobel_Parameters : Form
    {
        Form1 _form2;
        public Sobel_Parameters()
        {
            InitializeComponent();

        }

        public Sobel_Parameters(Form1 fm2)
        {

            InitializeComponent();
            _form2 = fm2;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _form2.ApplySobel((int)numericXOrder.Value, (int)numericYOrder.Value, (int)numericApertureSize.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void numericXOrder_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
