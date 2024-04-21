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
    public partial class InterFace : Form
    {
        public InterFace()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_convert, "Click here to Convert the Number System!");
        }

        private void btn_Arithmetic_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_Arithmetic, "Click here to Do the \n Arithmetic Operations!");

        }

        private void btn_complement_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_complement, "Click here to see the Complements!");

        }

        private void btn_shift_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_shift, "Click here to Do the \n Shift Operations!");

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new NumberConverter();
            frm.ShowDialog();
            
        }

        private void btn_Arithmetic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Arithmetic();
            frm.ShowDialog();
        }

        private void btn_complement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Complement();
            frm.ShowDialog();
        }

        private void btn_shift_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Shifts();
            frm.ShowDialog();
        }
    }
}
