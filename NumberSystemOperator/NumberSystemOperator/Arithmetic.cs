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
    public partial class Arithmetic : Form
    {
            int baseNumber;
             int Output;
        public Arithmetic()
        {
            InitializeComponent();

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_input1, "Enter the First number here! ");

        }

        private void txt_input2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txt_input2, "Enter the Second number here! ");

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {

            string num1String = txt_input1.Text;

            string num2String = txt_input2.Text;

            string cmbBaseInputtype = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (cmbBaseInputtype == "Binary")
            {
                baseNumber = 2;
            }
            else if (cmbBaseInputtype == "Decimal")
            {
                baseNumber = 10;
            }
            else if (cmbBaseInputtype == "Octal")
            {
                baseNumber = 8;
            }
            else if (cmbBaseInputtype == "Hexadecimal")
            {
                baseNumber = 16;
            }
            

            int num1 = Convert.ToInt32(num1String, baseNumber);
            int num2 = Convert.ToInt32(num2String, baseNumber);

           /*Console.WriteLine($"Number 1 (Base {baseNumber}): {num1String}");
            Console.WriteLine($"Number 2 (Base {baseNumber}): {num2String}");
           */
           string operation = comboBox2.GetItemText(comboBox2.SelectedItem);

            if(operation == "Addition")
            {
                Output = num1 + num2;
            }
            else if (operation == "Substraction")
            {
                Output = num1 - num2;
            }
            else if (operation == "Multiplication")
            {
                Output = num1 * num2;
            }
            else if (operation == "Division")
            {
                if (num2 != 0)
                {
                    float quotient = (float)num1 / num2;
                    lbl_Output.Text = ($"Division: {Convert.ToString((int)quotient, baseNumber)}");
                }
                else
                {
                   MessageBox.Show("Cannot divide by zero.");
                }
            }
            lbl_Output.Text = Convert.ToString(Output, baseNumber);

            // Addition
            /*int sum = num1 + num2;
            Console.WriteLine($"Addition: {Convert.ToString(sum, baseNumber)}");

            // Subtraction
            int diff = num1 - num2;
            Console.WriteLine($"Subtraction: {Convert.ToString(diff, baseNumber)}");

            // Multiplication
            int product = num1 * num2;
            Console.WriteLine($"Multiplication: {Convert.ToString(product, baseNumber)}");
            */
            // Division
           /* if (num2 != 0)
            {
                float quotient = (float)num1 / num2;
                Console.WriteLine($"Division: {Convert.ToString((int)quotient, baseNumber)}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_input1.Text = string.Empty;
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
