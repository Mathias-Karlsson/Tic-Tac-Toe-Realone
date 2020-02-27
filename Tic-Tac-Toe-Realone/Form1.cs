using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Realone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (O.Visible)
                {
                    button.Text = "O";
                    button.Enabled = false;
                    O.Visible = false;
                    X.Visible = true;
                }
                else
                {
                    button.Text = "X";
                    button.Enabled = false;
                    X.Visible = false;
                    O.Visible = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            click(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            click(sender);
        }
    }
}
