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
    public partial class CannyParameters : Form
    {

        Form1 _form;
        public CannyParameters()
        {
            InitializeComponent();
        }

        public CannyParameters(Form1 fm)
        {
            InitializeComponent();
            _form = fm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form.ApplyCanny((double)numericThreshold.Value, (double)numericThresholdLink.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
