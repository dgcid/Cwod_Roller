using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class cWOD_Roller : Form
    {
        

        public cWOD_Roller()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Diff = Convert.ToInt32(Diff_Box.Text);
            int randomNumber = random.Next(1, Convert.ToInt32(Sides.Text) + 1);
            if (randomNumber >= Diff)
            {
                Number.Text = Convert.ToString("Success" + " " + randomNumber);
            }
            else
            {
                Number.Text = Convert.ToString("Fail");
            }


        }

        private void Str_Box_TextChanged(object sender, EventArgs e)
        {

        }

     




        }

        }
    }
}
