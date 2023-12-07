using System.Data;
using System.Data.SqlClient;

namespace Nemam_Pojma_vise
{


    public partial class Form2 : Form
    {

        List<Racuni> racun = new List<Racuni>();
        List<Proizvodi> proizvodi = new List<Proizvodi>();
        List<Stavke> stavke = new List<Stavke>();
        List<StatusRacuna> Status = new List<StatusRacuna>();

        bool newRowNeeded;
        int promenjiva;
        //bool test = true;
        public int brojac = 0; 
        DateTime datum;
        int Promena = 0;
        //int pamti;
        string status = "";
        int stavkeProizvodId = 0;
        public Form2(int promenjiva,string status,DateTime datum)
        {
            this.promenjiva = promenjiva;
            this.status = status;
            this.datum = datum;
            InitializeComponent();
            StatusRacuna();
            update();
            if (promenjiva > 0 && status != "Izradi")
            {
                textBox1.Text = calculatePrice().ToString();
            }
            if (promenjiva > 0 && status == "Izradi")
            {
                textBox1.Text = calculatePriceForRacuni().ToString();
                dateTimePicker1.Value = datum;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
               
        }
        private void update()
        {
            if (promenjiva > 0 && status != "Izradi")
            {          
                StavkeRacuna();
                this.dataGridView1.Columns[1].Visible = false;
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].Visible = false;
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].Visible = false;
            }
            else if(promenjiva > 0 && status == "Izradi")
            {
                OnLoad();
                dataGridView1.CellContentClick += DataGridView1_CellContentClick;
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
                dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
            }
            else if (promenjiva == 0)
            {
                HelloSir();
                dataGridView1.CellContentClick += DataGridView1_CellContentClick;
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
                dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;   
            }
            
        }
        int redniBroj = 0;
        int kolicinaProizvoda = 0;
        private void OnLoad()
        {
            DataAcess db = new DataAcess();
            //DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells[0];
            DataTable dataTable = new DataTable();
            proizvodi = db.GetProizvod();
            stavke = db.GetStavkeRacun(promenjiva);
            Naziv_Proizvoda.DataSource = proizvodi;
            Naziv_Proizvoda.DisplayMember = "NazivProizvoda";
            Naziv_Proizvoda.ValueMember = "ProizvodiId";
            int promenii = 0;
            int proizvoidId = 0;
            
            for (int i = 0; i < stavke.Count; i++)
            {
                redniBroj = i;
                promenii = stavke[i].ProizvodId;
                stavkeProizvodId = stavke[i].StavkeId;
                if (dataGridView1.Rows.Count == 1)
                {
                    dataGridView1.Rows.Add(stavke.Count);
                }
                if (promenjiva != 0 && i != stavke.Count)
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[0];
                    proizvoidId = promenii - 1;
                    stavkeProizvodId = proizvoidId;
                    cell.Value = proizvodi[proizvoidId].ProizvodiId;
                    dataGridView1.Rows[redniBroj].Cells[1].Value = proizvodi[stavkeProizvodId].CenaProizvoda;
                    dataGridView1.Rows[redniBroj].Cells[2].Value = stavke[redniBroj].Kolicina;

                }
            }

            dataGridView1.Refresh();
            //dataGridView1.Rows[redniBroj].Cells[1].Value = proizvodi[redniBroj].CenaProizvoda;

         
        }
        private void StavkeRacuna()
        {
           
         DataAcess db = new DataAcess();
         stavke = db.GetStavkeRacun(promenjiva);
         proizvodi = db.GetProizvod();
             if (status == "Overen")
            {
                dataGridView1.DataSource = stavke;
                this.dataGridView1.Columns[0].Visible = false;
                dataGridView1.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dataGridView1.DataSource = stavke;
                this.dataGridView1.Columns[0].Visible = false;
                dataGridView1.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }
      
        private void dataGridView1_NewRowNeeded(object sender,
            DataGridViewRowEventArgs e)
        {
            newRowNeeded = true;
        }
        private void HelloSir()
        {
            DataAcess db = new DataAcess();
            proizvodi = db.GetProizvod();  ;
            Naziv_Proizvoda.DataSource = proizvodi;
            Naziv_Proizvoda.DisplayMember = "NazivProizvoda";
            Naziv_Proizvoda.ValueMember = "ProizvodiId";
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (status == "Izradi")
            {
                List<Proizvodi> proba = new List<Proizvodi>();
                DataAcess db = new DataAcess();
                proba = db.GetProizvod();
                if (e.ColumnIndex != 0)
                    return;
                var comboCell = (dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewComboBoxCell);
                var currId = (int)dataGridView1.CurrentRow.Cells["Naziv_Proizvoda"].Value - 1;
                var value = proizvodi[currId].CenaProizvoda;
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = value;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = 1;
            }
            else 
            { 
            List<Proizvodi> proba = new List<Proizvodi>();
            DataAcess db = new DataAcess();
            proba = db.GetProizvod();
            if (e.ColumnIndex != 0)
            return;
            var comboCell = (dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewComboBoxCell);
            var currId = (int)dataGridView1.CurrentRow.Cells["Naziv_Proizvoda"].Value - 1;
            var value = proizvodi[currId].CenaProizvoda;
            dataGridView1.Rows[e.RowIndex].Cells["Cena_Proizvoda"].Value = value;
            dataGridView1.Rows[e.RowIndex].Cells["Kolicina_Proizvoda"].Value = 1;
            }
        }
        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            var currentCell = (sender as DataGridView).CurrentCell;
            if (currentCell.ColumnIndex == 0)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
           
        }
        private void StatusRacuna()
        {
            DataAcess db = new DataAcess();
            Status = db.GetStatus();
            comboBox1.DataSource = Status;
            comboBox1.ValueMember = "StatusRacunaId";
            comboBox1.DisplayMember = "NazivStatusa";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (status != "") { 
            if (status == "Izradi")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (status == "Storniran")
            {
                comboBox1.SelectedIndex = 2;
                    this.comboBox1.Enabled = false;
                    ObrisiStavku.Enabled = false;
                    Sacuvaj.Enabled = false;
                }
            else if (status == "Overen")
            {
                comboBox1.SelectedIndex = 1;
                this.comboBox1.Enabled = false;
                    ObrisiStavku.Enabled = false;
                    Sacuvaj.Enabled = false;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (status == "Izradi")
            {
                int test = Convert.ToInt32(dataGridView1.Rows.Count);
                int test2 = Convert.ToInt32(dataGridView1.CurrentRow.Index) + 1;
                if (test != test2)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
            }   
        }
            
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //List<Proizvodi> proba = new List<Proizvodi>();
            //DataAcess db = new DataAcess();
            //proba = db.GetProizvod();
            //brojac++;
            kolicinaProizvoda = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            if (kolicinaProizvoda <= 0)
            {
                dataGridView1.CurrentRow.Cells[2].Value = 1;
            }
            if (kolicinaProizvoda >= 999)
            {
                dataGridView1.CurrentRow.Cells[2].Value = 999;
            }
            if (status != "Izradi")
            {
                //textBox1.Text = calculatePrice().ToString();
                textBox1.Text = calculatePriceForRacuni().ToString();
            }
            if (promenjiva > 0)
            {
                textBox1.Text = calculatePriceForRacuni().ToString();
            }
        }
        private double calculatePrice()
        {
                double ITWORKS = 0;
                int currentcell = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int WorkPlease = Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                    currentcell = Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value) * WorkPlease;
                    ITWORKS += currentcell;
                }
                return ITWORKS;
        }
        private double calculatePriceForRacuni()
        {
            double ITWORKS = 0;
            int currentcell = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value != null)
                {
                    int WorkPlease = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    currentcell = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * WorkPlease;
                    ITWORKS += currentcell;
                }
                else
                {
                    break;
                }

            }
            return ITWORKS;
        }     
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        const int initialSize = 5000000;
        int numberOfRows = initialSize;
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (newRowNeeded)
            {
                newRowNeeded = false;
                numberOfRows = numberOfRows + 1;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
        List<Stavke> StavkeNovogRacuna = new List<Stavke>();
        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            DataAcess db = new DataAcess();
            proizvodi = db.GetProizvod();
            stavke = db.GetStavke();
            racun = db.getRacun();
            int proizvoidId = 0;
            int broj = promenjiva;
            int UkupnaCena = Convert.ToInt32(textBox1.Text);
            DataTable userStavkeTable = new DataTable("UserStavke");
            userStavkeTable.Columns.Add("StavkeId", typeof(int));
            userStavkeTable.Columns.Add("ProizvodId", typeof(int));
            userStavkeTable.Columns.Add("RacunId", typeof(int));
            userStavkeTable.Columns.Add("Naziv", typeof(string));
            userStavkeTable.Columns.Add("CenaStavke", typeof(decimal));
            userStavkeTable.Columns.Add("Kolicina", typeof(int));
            if (promenjiva > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    proizvoidId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) - 1;
                    if (promenjiva > 0)
                    {
                        DataRow row = userStavkeTable.NewRow();
                        row["StavkeId"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        row["ProizvodId"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        row["RacunId"] = promenjiva;
                        row["Naziv"] = proizvodi[proizvoidId].NazivProizvoda;
                        row["CenaStavke"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        row["Kolicina"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        userStavkeTable.Rows.Add(row);
                    }
                }

                using (SqlConnection connection = new SqlConnection(HelpMePlease.CnnRac("Racuni")))
                using (SqlCommand command = new SqlCommand("InsertUpdateDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@UserStavke", userStavkeTable);
                    command.Parameters.AddWithValue("@RacunId", promenjiva);
                    command.Parameters.AddWithValue("@Datum", DateTime.Now);
                    command.Parameters.AddWithValue("@UkupnaCena", UkupnaCena);
                    // open the connection and execute the stored procedure
                    connection.Open();
                    command.ExecuteNonQuery();
                    dataGridView1.Refresh();
                }
            }
            else if (promenjiva == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    proizvoidId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) - 1;
                        DataRow row = userStavkeTable.NewRow();
                        row["StavkeId"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        row["ProizvodId"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        row["RacunId"] = racun.Count + 1;
                        row["Naziv"] = proizvodi[proizvoidId].NazivProizvoda;
                        row["CenaStavke"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        row["Kolicina"] = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                        userStavkeTable.Rows.Add(row);
                }
                using (SqlConnection connection = new SqlConnection(HelpMePlease.CnnRac("Racuni")))
                using (SqlCommand command = new SqlCommand("InsertUpdateDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@UserStavke", userStavkeTable);
                    command.Parameters.AddWithValue("@RacunId", promenjiva);
                    command.Parameters.AddWithValue("@Datum", DateTime.Now);
                    command.Parameters.AddWithValue("@UkupnaCena", UkupnaCena);
                    // open the connection and execute the stored procedure
                    connection.Open();
                    command.ExecuteNonQuery();
                    dataGridView1.Refresh();
                }
            }
        }
        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form1 forma1 = new Form1();
            DataGridView dgv1 = forma1.Controls.Find("dataGridView1", true).FirstOrDefault() as DataGridView;
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.update();
        }
        
    }

}
