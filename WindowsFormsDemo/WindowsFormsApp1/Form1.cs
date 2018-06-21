using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region "Code region"
        public string sentence;
        
        private void BtnCheck(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserInput.Text = comboBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UserInput.Text = "hello";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UserInput.Text = "gogo";
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            sentence = UserInput.Text;
        }
    }
    
}
