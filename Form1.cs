using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Nemam_Pojma_vise
{
    public partial class Form1 : Form
    {
        List<Racuni> racun = new List<Racuni>();
        List<Proizvodi> proizvodi = new List<Proizvodi>();
        List<Stavke> stavke = new List<Stavke>();
        public int promenjiva;
        public string status;
        public DateTime datum;

        public Form1()
        {
            InitializeComponent();
            update();
        }
        

        public void update()
        {
            DataAcess db = new DataAcess();
            racun = db.getRacun();
            dataGridView1.DataSource = racun;
            this.dataGridView1.Columns[1].Visible = false;
        }

        private void StavkeForm()
        {
            DataAcess db = new DataAcess();
            promenjiva = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            status = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            datum = Convert.ToDateTime((dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value));
            Form2 forma2 = new Form2(promenjiva, status, datum);

            forma2.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StavkeForm();
        }

        private void dataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            StavkeForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            
            Form2 Forma2 = new Form2(0, "", DateTime.Now);
            Forma2.ShowDialog();
         

        }

   
    }
}