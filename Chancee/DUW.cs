using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeManagement
{
    
    public partial class DUW : Form
    {
        public DUW()
        {
            InitializeComponent();
            

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int QuestionTicks = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = QuestionTicks.ToString();
            QuestionTicks--;
            if (QuestionTicks == 0)
            {

                Form1 secondform = new Form1();
                secondform.ShowDialog();
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
