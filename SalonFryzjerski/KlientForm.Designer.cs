namespace SalonFryzjerski
{
    partial class KlientForm
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
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.numerTelefonuNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numerTelefonuNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(151, 24);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(250, 23);
            this.imieTextBox.TabIndex = 0;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(151, 72);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(250, 23);
            this.nazwiskoTextBox.TabIndex = 1;
            // 
            // numerTelefonuNumericUpDown
            // 
            this.numerTelefonuNumericUpDown.Location = new System.Drawing.Point(151, 119);
            this.numerTelefonuNumericUpDown.Name = "numerTelefonuNumericUpDown";
            this.numerTelefonuNumericUpDown.Size = new System.Drawing.Size(250, 23);
            this.numerTelefonuNumericUpDown.TabIndex = 2;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(151, 187);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(250, 164);
            this.opisTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numer Telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Krótki opis włosów";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 431);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 70);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "DODAJ ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "COFNIJ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.numerTelefonuNumericUpDown);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Name = "KlientForm";
            this.Text = "KlientForm";
            this.Load += new System.EventHandler(this.KlientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerTelefonuNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox imieTextBox;
        private TextBox nazwiskoTextBox;
        private NumericUpDown numerTelefonuNumericUpDown;
        private TextBox opisTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addButton;
        private Button button2;
    }
}