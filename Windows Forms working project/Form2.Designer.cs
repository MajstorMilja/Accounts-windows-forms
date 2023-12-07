namespace Nemam_Pojma_vise
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naziv_Proizvoda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cena_Proizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina_Proizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Sacuvaj = new System.Windows.Forms.Button();
            this.ObrisiStavku = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.proizvodiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.UkupnaCena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv_Proizvoda,
            this.Cena_Proizvoda,
            this.Kolicina_Proizvoda});
            this.dataGridView1.Location = new System.Drawing.Point(29, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(609, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged_1);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Naziv_Proizvoda
            // 
            this.Naziv_Proizvoda.DataSource = this.proizvodiBindingSource;
            this.Naziv_Proizvoda.DisplayMember = "NazivProizvoda";
            this.Naziv_Proizvoda.HeaderText = "Naziv_Proizvoda";
            this.Naziv_Proizvoda.Name = "Naziv_Proizvoda";
            this.Naziv_Proizvoda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Naziv_Proizvoda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Naziv_Proizvoda.ValueMember = "ProizvodiId";
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataSource = typeof(Nemam_Pojma_vise.Proizvodi);
            // 
            // Cena_Proizvoda
            // 
            this.Cena_Proizvoda.HeaderText = "Cena_Proizvoda";
            this.Cena_Proizvoda.Name = "Cena_Proizvoda";
            this.Cena_Proizvoda.ReadOnly = true;
            this.Cena_Proizvoda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Kolicina_Proizvoda
            // 
            this.Kolicina_Proizvoda.HeaderText = "Kolicina_Proizvoda";
            this.Kolicina_Proizvoda.Name = "Kolicina_Proizvoda";
            // 
            // stavkeBindingSource
            // 
            this.stavkeBindingSource.DataSource = typeof(Nemam_Pojma_vise.Stavke);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(667, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.Location = new System.Drawing.Point(667, 17);
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Size = new System.Drawing.Size(113, 71);
            this.Sacuvaj.TabIndex = 2;
            this.Sacuvaj.Text = "Sacuvaj";
            this.Sacuvaj.UseVisualStyleBackColor = true;
            this.Sacuvaj.Click += new System.EventHandler(this.Sacuvaj_Click);
            // 
            // ObrisiStavku
            // 
            this.ObrisiStavku.Location = new System.Drawing.Point(667, 128);
            this.ObrisiStavku.Name = "ObrisiStavku";
            this.ObrisiStavku.Size = new System.Drawing.Size(113, 79);
            this.ObrisiStavku.TabIndex = 3;
            this.ObrisiStavku.Text = "Obrisi Stavku";
            this.ObrisiStavku.UseVisualStyleBackColor = true;
            this.ObrisiStavku.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izaberite Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // proizvodiBindingSource1
            // 
            this.proizvodiBindingSource1.DataSource = typeof(Nemam_Pojma_vise.Proizvodi);
            // 
            // proizvodiBindingSource2
            // 
            this.proizvodiBindingSource2.DataSource = typeof(Nemam_Pojma_vise.Proizvodi);
            // 
            // UkupnaCena
            // 
            this.UkupnaCena.AutoSize = true;
            this.UkupnaCena.Location = new System.Drawing.Point(667, 336);
            this.UkupnaCena.Name = "UkupnaCena";
            this.UkupnaCena.Size = new System.Drawing.Size(78, 15);
            this.UkupnaCena.TabIndex = 6;
            this.UkupnaCena.Text = "UkupnaCena:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(113, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UkupnaCena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObrisiStavku);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "PrikazProizvoda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing_1);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button Sacuvaj;
        private Button ObrisiStavku;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private BindingSource proizvodiBindingSource;
        private BindingSource proizvodiBindingSource1;
        private BindingSource proizvodiBindingSource2;
        private Label UkupnaCena;
        private TextBox textBox1;
        private BindingSource stavkeBindingSource;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridViewComboBoxColumn Naziv_Proizvoda;
        private DataGridViewTextBoxColumn Cena_Proizvoda;
        private DataGridViewTextBoxColumn Kolicina_Proizvoda;
    }
}