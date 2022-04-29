using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingDataForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Bitmap _bmpFormMain;
        private void button1_Click(object sender, EventArgs e)
        {
            frmOne frm = new frmOne();
            if(frm.ShowDialog()== DialogResult.OK)
            {
                _bmpFormMain = frm._bmp;
                pictureBox1.Image = _bmpFormMain;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTwo frm = new frmTwo();
            frm._bmpForm2 = _bmpFormMain;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
