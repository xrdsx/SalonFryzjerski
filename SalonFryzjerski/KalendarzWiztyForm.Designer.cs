namespace SalonFryzjerski.models
{
    partial class KalendarzWiztyForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.deltetButton = new System.Windows.Forms.Button();
            this.buttonCofnij = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonWyszukuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(418, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // deltetButton
            // 
            this.deltetButton.Location = new System.Drawing.Point(1062, 632);
            this.deltetButton.Name = "deltetButton";
            this.deltetButton.Size = new System.Drawing.Size(106, 42);
            this.deltetButton.TabIndex = 4;
            this.deltetButton.Text = "USUN";
            this.deltetButton.UseVisualStyleBackColor = true;
            this.deltetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCofnij
            // 
            this.buttonCofnij.Location = new System.Drawing.Point(12, 642);
            this.buttonCofnij.Name = "buttonCofnij";
            this.buttonCofnij.Size = new System.Drawing.Size(91, 23);
            this.buttonCofnij.TabIndex = 5;
            this.buttonCofnij.Text = "COFNIJ";
            this.buttonCofnij.UseVisualStyleBackColor = true;
            this.buttonCofnij.Click += new System.EventHandler(this.buttonCofnij_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(840, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonWyszukuj
            // 
            this.buttonWyszukuj.Location = new System.Drawing.Point(1039, 20);
            this.buttonWyszukuj.Name = "buttonWyszukuj";
            this.buttonWyszukuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWyszukuj.TabIndex = 7;
            this.buttonWyszukuj.Text = "Wyszukuj";
            this.buttonWyszukuj.UseVisualStyleBackColor = true;
            this.buttonWyszukuj.Click += new System.EventHandler(this.buttonWyszukuj_Click);
            // 
            // KalendarzWiztyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 780);
            this.Controls.Add(this.buttonWyszukuj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCofnij);
            this.Controls.Add(this.deltetButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KalendarzWiztyForm";
            this.Text = "KalendarzWiztyForm";
            this.Load += new System.EventHandler(this.KalendarzWiztyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button deltetButton;
        private Button buttonCofnij;
        private ComboBox comboBox1;
        private Button buttonWyszukuj;
    }
}