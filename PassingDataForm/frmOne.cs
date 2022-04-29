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
    public partial class frmOne: Form
    {
        public frmOne()
        {
            InitializeComponent();
        }
        public Bitmap _bmp;
        private void btOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter =
            "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
            "All files (*.*)|*.*";

            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Select Photos";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                _bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = _bmp;
            }
        }

        private void btCloseForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
