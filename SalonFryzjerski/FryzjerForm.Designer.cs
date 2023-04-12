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
            ((System.ComponentModel.ISupportInitialize)(this.fryzjerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stawkaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloscGodzinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fryzjerDataGridView
            // 
            this.fryzjerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fryzjerDataGridView.Location = new System.Drawing.Point(30, 21);
            this.fryzjerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fryzjerDataGridView.Name = "fryzjerDataGridView";
            this.fryzjerDataGridView.RowHeadersWidth = 51;
            this.fryzjerDataGridView.RowTemplate.Height = 29;
            this.fryzjerDataGridView.Size = new System.Drawing.Size(447, 211);
            this.fryzjerDataGridView.TabIndex = 0;
            this.fryzjerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fryzjerDataGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(571, 197);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 22);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(691, 197);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 22);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(395, 265);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 22);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usun";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(664, 21);
            this.imieTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(110, 23);
            this.imieTextBox.TabIndex = 4;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(664, 65);
            this.nazwiskoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(110, 23);
            this.nazwiskoTextBox.TabIndex = 5;
            // 
            // stawkaNumericUpDown
            // 
            this.stawkaNumericUpDown.Location = new System.Drawing.Point(664, 104);
            this.stawkaNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stawkaNumericUpDown.Name = "stawkaNumericUpDown";
            this.stawkaNumericUpDown.Size = new System.Drawing.Size(109, 23);
            this.stawkaNumericUpDown.TabIndex = 6;
            // 
            // iloscGodzinNumericUpDown
            // 
            this.iloscGodzinNumericUpDown.Location = new System.Drawing.Point(664, 134);
            this.iloscGodzinNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iloscGodzinNumericUpDown.Name = "iloscGodzinNumericUpDown";
            this.iloscGodzinNumericUpDown.Size = new System.Drawing.Size(109, 23);
            this.iloscGodzinNumericUpDown.TabIndex = 7;
            // 
            // FryzjerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 338);
            this.Controls.Add(this.iloscGodzinNumericUpDown);
            this.Controls.Add(this.stawkaNumericUpDown);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fryzjerDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FryzjerForm";
            this.Text = "FryzjerForm";
            this.Load += new System.EventHandler(this.FryzjerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fryzjerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stawkaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloscGodzinNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}