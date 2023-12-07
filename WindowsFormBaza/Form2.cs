using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormBaza
{
   
    public partial class Form2 : Form
    {
        public string yes { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Vau = new Form1();
            Vau.empty = textBox1.Text;
            MessageBox.Show(textBox1.Text);
            MessageBox.Show(Vau.empty);
        }
    }
}
