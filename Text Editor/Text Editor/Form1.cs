using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this will edit the text cars 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// this will change the backgroung color
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
        /// this will change the text font 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eDITTEXTSIZEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        // by ABDALLAH .F. AFANDY
    }
}
