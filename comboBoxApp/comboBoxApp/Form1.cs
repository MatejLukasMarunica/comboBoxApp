using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBoxApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void posalji_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";

            textBox1.AppendText("Odabrali ste: " + "\r\n");

            if (rucak.Checked)
            {
                textBox1.AppendText("Ručak " + "\r\n");
            }


            if (dorucak.Checked)
            {
                textBox1.AppendText("Doručak " + "\r\n");
            }


            if (vecera.Checked)
            {
                textBox1.AppendText("Većera");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sakrij_CheckedChanged(object sender, EventArgs e)
        {
            if(sakrij.Checked)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;
            }
        }
    }
}
