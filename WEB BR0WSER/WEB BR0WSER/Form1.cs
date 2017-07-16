using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEB_BR0WSER
{
    public partial class Form1 : Form
    {
        private void navgite()
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this will change the background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eDITBACKGROUNDCOLORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// this will go forward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        /// <summary>
        /// this will go back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        /// <summary>
        /// this will go back to the home page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        /// <summary>
        /// to go to the URL in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            navgite();
        }

        /// <summary>
        /// to enable ENTER button to start the search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                navgite();
            }
        }
    }
}

//by :: ABDALLAH .F. AFANDY
