using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoSoXuLyAnhSo
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bitmap = new Bitmap(open.FileName);
                pbxLeft.Image = bitmap;
            }
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            pbxRight.Image = bitmap;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
