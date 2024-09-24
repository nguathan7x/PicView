using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_Thi_Anh_Nguyen
{
    public partial class frmForm2 : Form
    {
        public frmForm2()
        {
            InitializeComponent();
          
        }
        public frmForm2(string imageFile)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imageFile);
            //Text = imageFile.Substring(imageFile.LastIndexOf() + 1);
            this.Text = imageFile;
        }
        private void frmForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
