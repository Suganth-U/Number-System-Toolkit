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
    public partial class NumberConverter : Form
    {
        public NumberConverter()
        {
            InitializeComponent();
            txt_Decimal.TextChanged += TextBox_TextChanged;
            txt_Binary.TextChanged += TextBox_TextChanged;
            txt_Hexa.TextChanged += TextBox_TextChanged;
            txt_Octal.TextChanged += TextBox_TextChanged;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox sourceTextBox = (TextBox)sender;

            // Determine the base of the input
            int fromBase;
            if (sourceTextBox == txt_Decimal)
                fromBase = 10;
            else if (sourceTextBox == txt_Hexa)
                fromBase = 16;
            else if (sourceTextBox == txt_Binary)
                fromBase = 2;
            else if (sourceTextBox == txt_Octal)
                fromBase = 8;
            else
                throw new InvalidOperationException("Unknown textbox.");

            // Convert the number to other bases
            string number = sourceTextBox.Text;
            try
            {
                // Convert number from base 'fromBase' to other bases
                int decimalNumber = Convert.ToInt32(number, fromBase);
                txt_Decimal.Text = decimalNumber.ToString();
                txt_Hexa.Text = Convert.ToString(decimalNumber, 16).ToUpper();
                txt_Binary.Text = Convert.ToString(decimalNumber, 2);
                txt_Octal.Text = Convert.ToString(decimalNumber, 8);
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Decimal.Text = string.Empty;
            txt_Hexa.Text = string.Empty;
            txt_Binary.Text = string.Empty;
            txt_Octal.Text = string.Empty;
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
