﻿namespace SalonFryzjerski
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
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.klientFkCcomboBox = new System.Windows.Forms.ComboBox();
            this.usługaFkComboBox = new System.Windows.Forms.ComboBox();
            this.czasTrwanianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.klientFkCcomboBox.FormattingEnabled = true;
            this.klientFkCcomboBox.Location = new System.Drawing.Point(130, 59);
            this.klientFkCcomboBox.Name = "klientFkCcomboBox";
            this.klientFkCcomboBox.Size = new System.Drawing.Size(198, 23);
            this.klientFkCcomboBox.TabIndex = 1;
            this.klientFkCcomboBox.SelectedIndexChanged += new System.EventHandler(this.klientFkCcomboBox_SelectedIndexChanged);
            // 
            // usługaFkComboBox
            // 
            this.usługaFkComboBox.FormattingEnabled = true;
            this.usługaFkComboBox.Location = new System.Drawing.Point(130, 97);
            this.usługaFkComboBox.Name = "usługaFkComboBox";
            this.usługaFkComboBox.Size = new System.Drawing.Size(198, 23);
            this.usługaFkComboBox.TabIndex = 3;
            // 
            // czasTrwanianumericUpDown
            // 
            this.czasTrwanianumericUpDown.Location = new System.Drawing.Point(130, 136);
            this.czasTrwanianumericUpDown.Name = "czasTrwanianumericUpDown";
            this.czasTrwanianumericUpDown.Size = new System.Drawing.Size(198, 23);
            this.czasTrwanianumericUpDown.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 223);
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
            // ZleceniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}