using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }

        private void Tombolproses_Click(object sender, EventArgs e)
        {
            if (BoxInput.Text == "restart")
            {
                LabelKosong.Text = "[EMPTY]";
                LabelKosong.ForeColor = Color.Black;
            }
            else if (BoxInput.Text == "shown")
            {
                LabelKosong.Visible = true;
            }
            else if (BoxInput.Text == "hide")
            {
                LabelKosong.Visible = false;
            }
            else if (BoxInput.Text.Substring(0, 4) == "isi:")
            {
                LabelKosong.Text = BoxInput.Text.Substring(4);
            }
            else if (BoxInput.Text.Substring(0, 6) == "warna:")
            {
                if (BoxInput.Text.Substring(6) == "merah")
                {
                    LabelKosong.ForeColor = Color.Red;
                }
                else if (BoxInput.Text.Substring(6) == "hijau")
                {
                    LabelKosong.ForeColor = Color.Green;
                }
                else if (BoxInput.Text.Substring(6) == "biru")
                {
                    LabelKosong.ForeColor = Color.Blue;
                }
                else if (BoxInput.Text.Substring(6) == "default")
                {
                    LabelKosong.ForeColor = Color.Black;
                }
            }
           
        }

        private void BoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelKosong_Click(object sender, EventArgs e)
        {

        }
    }
}
