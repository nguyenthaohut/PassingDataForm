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
    public partial class frmTwo : Form
    {
        public frmTwo()
        {
            InitializeComponent();
        }
        public Bitmap _bmpForm2;
        private void frmTwo_VisibleChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = _bmpForm2;
        }

        private void btCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
