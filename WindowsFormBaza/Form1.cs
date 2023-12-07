using System;

namespace WindowsFormBaza
{
    public partial class Form1 : Form
    {
        List<ljudi> WOW = new List<ljudi>(); 
        public string empty { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Pol> nova = new List<Pol>();
            nova.Add(new Pol() { ID = 0, pol = "" });
            nova.Add(new Pol() { ID = 1, pol = "musko" });
            nova.Add(new Pol() { ID = 1, pol = "zensko" });
            WPol.DataSource = nova;
            WPol.ValueMember = "ID";
            WPol.DisplayMember = "pol";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dugme1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"hello {Ime.Text} {Prezime.Text}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 forma2 = new Form1();
            forma2.Show();          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 nov = new Form2();
            nov.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = empty;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime nesto = DateTime.Now;
           
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}