namespace SalonFryzjerski
{
    partial class FryzjerForm
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
            this.fryzjerDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.stawkaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iloscGodzinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fryzjerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stawkaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloscGodzinNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fryzjerDataGridView
            // 
            this.fryzjerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fryzjerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fryzjerDataGridView.Location = new System.Drawing.Point(12, 11);
            this.fryzjerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fryzjerDataGridView.Name = "fryzjerDataGridView";
            this.fryzjerDataGridView.RowHeadersWidth = 51;
            this.fryzjerDataGridView.RowTemplate.Height = 29;
            this.fryzjerDataGridView.Size = new System.Drawing.Size(1069, 373);
            this.fryzjerDataGridView.TabIndex = 0;
            this.fryzjerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fryzjerDataGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(105, 215);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(162, 48);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(313, 215);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(170, 48);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(899, 402);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 94);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usun";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(105, 38);
            this.imieTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(378, 23);
            this.imieTextBox.TabIndex = 4;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(105, 82);
            this.nazwiskoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(378, 23);
            this.nazwiskoTextBox.TabIndex = 5;
            // 
            // stawkaNumericUpDown
            // 
            this.stawkaNumericUpDown.Location = new System.Drawing.Point(105, 121);
            this.stawkaNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stawkaNumericUpDown.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.stawkaNumericUpDown.Name = "stawkaNumericUpDown";
            this.stawkaNumericUpDown.Size = new System.Drawing.Size(377, 23);
            this.stawkaNumericUpDown.TabIndex = 6;
            this.stawkaNumericUpDown.ValueChanged += new System.EventHandler(this.stawkaNumericUpDown_ValueChanged);
            // 
            // iloscGodzinNumericUpDown
            // 
            this.iloscGodzinNumericUpDown.Location = new System.Drawing.Point(105, 151);
            this.iloscGodzinNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iloscGodzinNumericUpDown.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.iloscGodzinNumericUpDown.Name = "iloscGodzinNumericUpDown";
            this.iloscGodzinNumericUpDown.Size = new System.Drawing.Size(377, 23);
            this.iloscGodzinNumericUpDown.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stawka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ilość godzin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.imieTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nazwiskoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stawkaNumericUpDown);
            this.groupBox1.Controls.Add(this.iloscGodzinNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 326);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DODWANIE FRYZJERA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rola";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(654, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 23);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(313, 267);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(169, 48);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Zaktualizuj";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 74);
            this.button1.TabIndex = 13;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FryzjerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fryzjerDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FryzjerForm";
            this.Text = "FryzjerForm";
            this.Load += new System.EventHandler(this.FryzjerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fryzjerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stawkaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloscGodzinNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView fryzjerDataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox imieTextBox;
        private TextBox nazwiskoTextBox;
        private NumericUpDown stawkaNumericUpDown;
        private NumericUpDown iloscGodzinNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button updateButton;
        private Button button1;
        private Label label7;
        private ComboBox comboBox1;
    }
}