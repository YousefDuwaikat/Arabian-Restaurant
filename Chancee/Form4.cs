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
    public partial class form_4 : Form
    {
        public form_4()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int QuestionTicks = 5;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = QuestionTicks.ToString();
            QuestionTicks--;
            if (QuestionTicks == 0)
            {
                this.Hide();
                Order order = new Order();
                order.ShowDialog();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
