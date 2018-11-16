using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guru99
{
    public partial class Add : Form
    {
        //Tell this class that Run exists
        Run run = new Run();

        public Add()
        {
            InitializeComponent();

        }


    private void button1_Click(object sender, EventArgs e)
        {
            //When button is clicked, run printStuff() from the class Run
            run.printStuff();

            //Get string array named output from the class "Run"
            string[] output = run.output;

            //Clear TextBox
            TexBox.Clear();

            //Print every string inside output
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != null)
                {
                    TexBox.AppendText(output[i]);
                }
                
                TexBox.AppendText(Environment.NewLine);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Set run.linesOfText to numericUpDown
            run.linesOfText = Convert.ToInt32(NumberHandler.Value);
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }

}
