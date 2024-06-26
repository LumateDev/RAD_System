﻿namespace project_RAD
{
    partial class Producement
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
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridViewContract = new DataGridView();
            dataGridViewProductContract = new DataGridView();
            buttonConstractAdd = new Button();
            buttonContractEdit = new Button();
            buttonContractDelete = new Button();
            buttonProductContractAdd = new Button();
            buttonProductContractEdit = new Button();
            buttonProductContractDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContract).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductContract).BeginInit();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridViewContract
            // 
            dataGridViewContract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContract.Location = new Point(11, 16);
            dataGridViewContract.Margin = new Padding(1);
            dataGridViewContract.Name = "dataGridViewContract";
            dataGridViewContract.RowHeadersWidth = 102;
            dataGridViewContract.RowTemplate.Height = 49;
            dataGridViewContract.Size = new Size(1161, 284);
            dataGridViewContract.TabIndex = 0;
            // 
            // dataGridViewProductContract
            // 
            dataGridViewProductContract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductContract.Location = new Point(17, 397);
            dataGridViewProductContract.Margin = new Padding(1);
            dataGridViewProductContract.Name = "dataGridViewProductContract";
            dataGridViewProductContract.RowHeadersWidth = 102;
            dataGridViewProductContract.RowTemplate.Height = 49;
            dataGridViewProductContract.Size = new Size(1155, 286);
            dataGridViewProductContract.TabIndex = 1;
            // 
            // buttonConstractAdd
            // 
            buttonConstractAdd.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConstractAdd.Location = new Point(17, 318);
            buttonConstractAdd.Margin = new Padding(1);
            buttonConstractAdd.Name = "buttonConstractAdd";
            buttonConstractAdd.Size = new Size(154, 46);
            buttonConstractAdd.TabIndex = 2;
            buttonConstractAdd.Text = "Добавить";
            buttonConstractAdd.UseVisualStyleBackColor = true;
            buttonConstractAdd.Click += buttonConstractAdd_Click;
            // 
            // buttonContractEdit
            // 
            buttonContractEdit.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContractEdit.Location = new Point(204, 318);
            buttonContractEdit.Margin = new Padding(1);
            buttonContractEdit.Name = "buttonContractEdit";
            buttonContractEdit.Size = new Size(153, 45);
            buttonContractEdit.TabIndex = 3;
            buttonContractEdit.Text = "Изменить";
            buttonContractEdit.UseVisualStyleBackColor = true;
            buttonContractEdit.Click += buttonContractEdit_Click;
            // 
            // buttonContractDelete
            // 
            buttonContractDelete.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContractDelete.Location = new Point(384, 317);
            buttonContractDelete.Margin = new Padding(1);
            buttonContractDelete.Name = "buttonContractDelete";
            buttonContractDelete.Size = new Size(150, 46);
            buttonContractDelete.TabIndex = 4;
            buttonContractDelete.Text = "Удалить";
            buttonContractDelete.UseVisualStyleBackColor = true;
            buttonContractDelete.Click += buttonContractDelete_Click;
            // 
            // buttonProductContractAdd
            // 
            buttonProductContractAdd.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProductContractAdd.Location = new Point(17, 696);
            buttonProductContractAdd.Margin = new Padding(1);
            buttonProductContractAdd.Name = "buttonProductContractAdd";
            buttonProductContractAdd.Size = new Size(154, 47);
            buttonProductContractAdd.TabIndex = 5;
            buttonProductContractAdd.Text = "Добавить";
            buttonProductContractAdd.UseVisualStyleBackColor = true;
            buttonProductContractAdd.Click += buttonProductContractAdd_Click;
            // 
            // buttonProductContractEdit
            // 
            buttonProductContractEdit.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProductContractEdit.Location = new Point(204, 696);
            buttonProductContractEdit.Margin = new Padding(1);
            buttonProductContractEdit.Name = "buttonProductContractEdit";
            buttonProductContractEdit.Size = new Size(153, 47);
            buttonProductContractEdit.TabIndex = 6;
            buttonProductContractEdit.Text = "Изменить";
            buttonProductContractEdit.UseVisualStyleBackColor = true;
            buttonProductContractEdit.Click += buttonProductContractEdit_Click;
            // 
            // buttonProductContractDelete
            // 
            buttonProductContractDelete.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProductContractDelete.Location = new Point(404, 696);
            buttonProductContractDelete.Margin = new Padding(1);
            buttonProductContractDelete.Name = "buttonProductContractDelete";
            buttonProductContractDelete.Size = new Size(148, 47);
            buttonProductContractDelete.TabIndex = 7;
            buttonProductContractDelete.Text = "Удалить";
            buttonProductContractDelete.UseVisualStyleBackColor = true;
            buttonProductContractDelete.Click += buttonProductContractDelete_Click;
            // 
            // Producement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(buttonProductContractDelete);
            Controls.Add(buttonProductContractEdit);
            Controls.Add(buttonProductContractAdd);
            Controls.Add(buttonContractDelete);
            Controls.Add(buttonContractEdit);
            Controls.Add(buttonConstractAdd);
            Controls.Add(dataGridViewProductContract);
            Controls.Add(dataGridViewContract);
            Margin = new Padding(1);
            Name = "Producement";
            Text = "Producement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewContract).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductContract).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridViewContract;
        private DataGridView dataGridViewProductContract;
        private Button buttonConstractAdd;
        private Button buttonContractEdit;
        private Button buttonContractDelete;
        private Button buttonProductContractAdd;
        private Button buttonProductContractEdit;
        private Button buttonProductContractDelete;
    }
}