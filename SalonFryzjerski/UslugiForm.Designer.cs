﻿namespace SalonFryzjerski
{
    partial class UslugiForm
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
            this.idUslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaUslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUslugiDataGridViewTextBoxColumn,
            this.nazwaUslugiDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uslugiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(137, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(471, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idUslugiDataGridViewTextBoxColumn
            // 
            this.idUslugiDataGridViewTextBoxColumn.DataPropertyName = "idUslugi";
            this.idUslugiDataGridViewTextBoxColumn.HeaderText = "idUslugi";
            this.idUslugiDataGridViewTextBoxColumn.Name = "idUslugiDataGridViewTextBoxColumn";
            // 
            // nazwaUslugiDataGridViewTextBoxColumn
            // 
            this.nazwaUslugiDataGridViewTextBoxColumn.DataPropertyName = "nazwaUslugi";
            this.nazwaUslugiDataGridViewTextBoxColumn.HeaderText = "nazwaUslugi";
            this.nazwaUslugiDataGridViewTextBoxColumn.Name = "nazwaUslugiDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // uslugiBindingSource
            // 
            this.uslugiBindingSource.DataSource = typeof(SalonFryzjerski.models.Uslugi);
            // 
            // UslugiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UslugiForm";
            this.Text = "UslugiForm";
            this.Load += new System.EventHandler(this.UslugiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idUslugiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazwaUslugiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private BindingSource uslugiBindingSource;
    }
}