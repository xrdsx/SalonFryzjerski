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
            this.fryzjerDataGridView.Location = new System.Drawing.Point(34, 28);
            this.fryzjerDataGridView.Name = "fryzjerDataGridView";
            this.fryzjerDataGridView.RowHeadersWidth = 51;
            this.fryzjerDataGridView.RowTemplate.Height = 29;
            this.fryzjerDataGridView.Size = new System.Drawing.Size(511, 281);
            this.fryzjerDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(653, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 29);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(790, 263);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 29);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(451, 353);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 29);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usun";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(759, 28);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(125, 27);
            this.imieTextBox.TabIndex = 4;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(759, 87);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(125, 27);
            this.nazwiskoTextBox.TabIndex = 5;
            // 
            // stawkanNmericUpDown
            // 
            this.stawkaNumericUpDown.Location = new System.Drawing.Point(759, 138);
            this.stawkaNumericUpDown.Name = "stawkanNmericUpDown";
            this.stawkaNumericUpDown.Size = new System.Drawing.Size(125, 27);
            this.stawkaNumericUpDown.TabIndex = 6;
            // 
            // iloscGodzinNumericUpDown
            // 
            this.iloscGodzinNumericUpDown.Location = new System.Drawing.Point(759, 179);
            this.iloscGodzinNumericUpDown.Name = "iloscGodzinNumericUpDown";
            this.iloscGodzinNumericUpDown.Size = new System.Drawing.Size(125, 27);
            this.iloscGodzinNumericUpDown.TabIndex = 7;
            // 
            // FryzjerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.iloscGodzinNumericUpDown);
            this.Controls.Add(this.stawkaNumericUpDown);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fryzjerDataGridView);
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