using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSystemOperator
{
    public partial class Shifts : Form
    {
        public Shifts()
        {
            InitializeComponent();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            string shiftType = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (shiftType == "Left Shift")
            {
                int decimalNumber = int.Parse(txt_input.Text);
                int shift = int.Parse(txt_input2.Text);

                // Convert decimal number to binary
                string binaryNumber = Convert.ToString(decimalNumber, 2);

                // Perform left shift
                string shiftedBinary = new string('0', shift) + binaryNumber.Substring(0, binaryNumber.Length - shift);
                string shiftedDecimal = Convert.ToInt32(shiftedBinary, 2).ToString();

                lbl_Output.Text = ($"Binary number: {shiftedBinary}" + $"\nDecimal number : {shiftedDecimal}");

            }
            else if (shiftType == "Right Shift")
            {

                int decimalNumber = int.Parse(txt_input.Text);

                int shift = int.Parse(txt_input2.Text);

                // Convert decimal number to binary
                string binaryNumber = Convert.ToString(decimalNumber, 2);

                // Perform right shift
                string shiftedBinary = binaryNumber.Substring(0, binaryNumber.Length - shift);
                string shiftedDecimal = Convert.ToInt32(shiftedBinary, 2).ToString();
                lbl_Output.Text = ($"Binary number : {shiftedBinary}" + $"\nDecimal number : {shiftedDecimal}");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_input.Text = string.Empty;
            txt_input2.Text = string.Empty;
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
