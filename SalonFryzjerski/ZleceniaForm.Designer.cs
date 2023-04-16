namespace SalonFryzjerski
{
    partial class ZleceniaForm
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
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.klientFkCcomboBox = new System.Windows.Forms.ComboBox();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usługaFkComboBox = new System.Windows.Forms.ComboBox();
            this.czasTrwanianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasTrwanianumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Location = new System.Drawing.Point(128, 30);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dataDateTimePicker.TabIndex = 0;
            // 
            // klientFkCcomboBox
            // 
            this.klientFkCcomboBox.DataSource = this.klientBindingSource;
            this.klientFkCcomboBox.FormattingEnabled = true;
            this.klientFkCcomboBox.Location = new System.Drawing.Point(130, 59);
            this.klientFkCcomboBox.Name = "klientFkCcomboBox";
            this.klientFkCcomboBox.Size = new System.Drawing.Size(198, 23);
            this.klientFkCcomboBox.TabIndex = 1;
            this.klientFkCcomboBox.SelectedIndexChanged += new System.EventHandler(this.klientFkCcomboBox_SelectedIndexChanged);
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataSource = typeof(SalonFryzjerski.models.Klient);
            this.klientBindingSource.CurrentChanged += new System.EventHandler(this.klientBindingSource_CurrentChanged);
            // 
            // usługaFkComboBox
            // 
            this.usługaFkComboBox.FormattingEnabled = true;
            this.usługaFkComboBox.Location = new System.Drawing.Point(130, 97);
            this.usługaFkComboBox.Name = "usługaFkComboBox";
            this.usługaFkComboBox.Size = new System.Drawing.Size(198, 23);
            this.usługaFkComboBox.TabIndex = 3;
            this.usługaFkComboBox.SelectedIndexChanged += new System.EventHandler(this.usługaFkComboBox_SelectedIndexChanged);
            // 
            // czasTrwanianumericUpDown
            // 
            this.czasTrwanianumericUpDown.Location = new System.Drawing.Point(130, 136);
            this.czasTrwanianumericUpDown.Name = "czasTrwanianumericUpDown";
            this.czasTrwanianumericUpDown.Size = new System.Drawing.Size(198, 23);
            this.czasTrwanianumericUpDown.TabIndex = 4;
            this.czasTrwanianumericUpDown.ValueChanged += new System.EventHandler(this.czasTrwanianumericUpDown_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "DODAJ WIZYTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data usługi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Klient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fryzjer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usługa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Czas trwania";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(220, 417);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 44);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "COFNIJ";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kwota do zapłaty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 58);
            this.button2.TabIndex = 15;
            this.button2.Text = "WYŚWIETL RACHUNEK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ZleceniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.czasTrwanianumericUpDown);
            this.Controls.Add(this.usługaFkComboBox);
            this.Controls.Add(this.klientFkCcomboBox);
            this.Controls.Add(this.dataDateTimePicker);
            this.Name = "ZleceniaForm";
            this.Text = "ZleceniaForm";
            this.Load += new System.EventHandler(this.ZleceniaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasTrwanianumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dataDateTimePicker;
        private ComboBox klientFkCcomboBox;
        private ComboBox usługaFkComboBox;
        private NumericUpDown czasTrwanianumericUpDown;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private BindingSource klientBindingSource;
        private Button backButton;
        private Label label6;
        private Label label7;
        private Button button2;
    }
}