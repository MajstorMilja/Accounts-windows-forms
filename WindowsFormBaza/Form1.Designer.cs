namespace WindowsFormBaza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Dugme1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WPol = new System.Windows.Forms.ComboBox();
            this.Boja = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Hello";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dugme1
            // 
            this.Dugme1.Location = new System.Drawing.Point(254, 308);
            this.Dugme1.Name = "Dugme1";
            this.Dugme1.Size = new System.Drawing.Size(75, 23);
            this.Dugme1.TabIndex = 1;
            this.Dugme1.Text = "Dugme";
            this.Dugme1.UseVisualStyleBackColor = true;
            this.Dugme1.Click += new System.EventHandler(this.Dugme1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(169, 84);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(160, 23);
            this.Ime.TabIndex = 3;
            this.Ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unesite Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Prezime
            // 
            this.Prezime.Location = new System.Drawing.Point(169, 139);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(160, 23);
            this.Prezime.TabIndex = 5;
            this.Prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prezime.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sacuvaj i ispisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Izaberite Pol:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Izaberite boju:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WPol
            // 
            this.WPol.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.WPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WPol.FormattingEnabled = true;
            this.WPol.Location = new System.Drawing.Point(169, 192);
            this.WPol.Name = "WPol";
            this.WPol.Size = new System.Drawing.Size(160, 23);
            this.WPol.TabIndex = 10;
            this.WPol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Boja
            // 
            this.Boja.FormattingEnabled = true;
            this.Boja.Location = new System.Drawing.Point(169, 238);
            this.Boja.Name = "Boja";
            this.Boja.Size = new System.Drawing.Size(160, 23);
            this.Boja.TabIndex = 11;
            this.Boja.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Forma2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Forma2?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "d-M-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(452, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 184);
            this.listBox1.TabIndex = 19;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(772, 436);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Boja);
            this.Controls.Add(this.WPol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dugme1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button Dugme1;
        private Label label1;
        private TextBox Ime;
        private Label label2;
        private TextBox Prezime;
        private Button button1;
        private Label label3;
        private Label label4;
        private ComboBox WPol;
        private ComboBox Boja;
        private Button button2;
        private Label label5;
        private Button button3;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
    }
}