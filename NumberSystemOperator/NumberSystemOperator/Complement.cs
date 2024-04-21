using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NumberSystemOperator
{

    public partial class Complement : Form
    {
  
        public Complement()
        {
            InitializeComponent();
        }

        public void btn_Find_Click(object sender, EventArgs e)
        {
            string complement = comboBox1.GetItemText(comboBox1.SelectedItem);
            if(complement == "One's Complement")
            {
                string binaryNumber = txt_input.Text;
                string onesComplement = "";
                foreach (char bit in binaryNumber)
                {
                    onesComplement += bit == '0' ? '1' : '0';
                }

                lbl_Output.Text = onesComplement;

            }
            else if(complement == "Two's Complement")
            {

                string binaryNumber = txt_input.Text;

                string onesComplement = "";
                foreach (char bit in binaryNumber)
                {
                    onesComplement += bit == '0' ? '1' : '0';
                }

                string twosComplement = Convert.ToString(Convert.ToInt32(onesComplement, 2) + 1, 2);
                lbl_Output.Text = twosComplement;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_input.Text = string.Empty;
            lbl_Output.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new InterFace();
            frm.ShowDialog();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Back");

        }
    }
}
