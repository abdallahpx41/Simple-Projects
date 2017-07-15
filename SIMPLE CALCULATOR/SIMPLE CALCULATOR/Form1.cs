using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMPLE_CALCULATOR
{
    public partial class Form1 : Form
    {
        double n1, n2, result;
        char op;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// button 1 will type the number '1'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }
        /// <summary>
        /// this button will type the number '2'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        /// <summary>
        /// this button will type the number '3';
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        /// <summary>
        /// this button will type the number '4'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        /// <summary>
        /// this button will type the number '5'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        /// <summary>
        /// this button will type the number '6'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        /// <summary>
        /// this button will type the number '7'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        /// <summary>
        /// this button will type the number '8'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        /// <summary>
        /// this button will type the number '9'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        /// <summary>
        /// this button will active the following operation 'n1 / n2 '
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            op = '/';
            textBox1.Clear();
        }
        /// <summary>
        /// this button will active or do the following operation 'n1 + n2' 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            op = '+';
            textBox1.Clear();
        }
        /// <summary>
        /// this button will subtracte n1 from n2 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            op = '-';
            textBox1.Clear();
        }
        /// <summary>
        /// this button will clear the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        /// <summary>
        /// this button will show the result of the operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(textBox1.Text);
            switch (op)
            {
                case 'x':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
            }
            textBox1.Text = Convert.ToString(result);
        }
        /// <summary>
        /// to change the app color into black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        /// <summary>
        /// to change font color into red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        /// <summary>
        /// to change font color into yellow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        /// <summary>
        /// to change font color into green
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a simple calculator you can use it in simple operations even you can change the font color","about the app",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /// <summary>
        /// to get the defult color 'white'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
        /// <summary>
        /// to exit from the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// this button will type the number '0'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        /// <summary>
        /// this button will type and actvite the multiblay action between n1 & n2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            op = 'x';
            textBox1.Clear();
        }
        //by ABDALLAH .F. AFANDY
    }
}
