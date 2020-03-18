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


    /// <summary>
    /// 1. Vad har jag lärt mig?: Jag har lärt mig hur man ska koda program med olika svar. 
    /// Button svar gällande om det är O eller X tur
    /// 2. Vad har varit svårt?: Button svar när det är O eller X tur var någ det svåraste.
    /// 3. Vad gick lätt?: Att lägga in reglerna var lättast.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender) /// Click kollar efter vems tur ar det och disablar en button nar nagon har klickat pa en button och lagger ett O eller X om det ar nagon av deras tur
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
            if (checkifwin())
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                O.Visible = false;
                X.Visible = false;
            }
        }

        public Boolean checkifwin() /// Den har koden kollar efter om O eller X har 3 i rad olika former
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text && (button1.Text == "X" || button1.Text == "O")) ||
                (button4.Text == button5.Text && button5.Text == button6.Text && (button4.Text == "X" || button4.Text == "O")) || 
                (button7.Text == button8.Text && button8.Text == button9.Text && (button7.Text == "X" || button7.Text == "O")) || 
                (button1.Text == button4.Text && button4.Text == button7.Text && (button1.Text == "X" || button1.Text == "O")) || 
                (button2.Text == button5.Text && button5.Text == button8.Text && (button2.Text == "X" || button2.Text == "O")) || 
                (button3.Text == button6.Text && button6.Text == button9.Text && (button3.Text == "X" || button3.Text == "O")) || 
                (button1.Text == button5.Text && button5.Text == button9.Text && (button1.Text == "X" || button1.Text == "O")) || 
                (button3.Text == button5.Text && button5.Text == button7.Text && (button3.Text == "X" || button3.Text == "O")))
            {
                if (O.Visible == false)
                {
                    Owin.Visible = true;
                }
                else
                {
                    Xwin.Visible = true;
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e) /// button1 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button2_Click(object sender, EventArgs e) /// button2 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button3_Click(object sender, EventArgs e) /// button3 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button4_Click(object sender, EventArgs e) /// button4 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button5_Click(object sender, EventArgs e) /// button5 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button6_Click(object sender, EventArgs e) /// button6 visar fram O eller X om det ar O eller X tur som klickar pa knappen       
        {
            click(sender);
        }

        private void button7_Click(object sender, EventArgs e) /// button7 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button8_Click(object sender, EventArgs e) /// button8 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void button9_Click(object sender, EventArgs e) /// button9 visar fram O eller X om det ar O eller X tur som klickar pa knappen
        {
            click(sender);
        }

        private void Rules_Click(object sender, EventArgs e) /// Rules visar upp en ny window som berattar vad reglerna galler i spelet
        {
            Rules window = new Rules();
            window.Show();
        }
    }
}
