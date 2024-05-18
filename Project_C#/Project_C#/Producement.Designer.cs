namespace project_RAD
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
            dataGridViewContract.Location = new Point(23, 32);
            dataGridViewContract.Name = "dataGridViewContract";
            dataGridViewContract.RowHeadersWidth = 102;
            dataGridViewContract.RowTemplate.Height = 49;
            dataGridViewContract.Size = new Size(2028, 483);
            dataGridViewContract.TabIndex = 0;
            // 
            // dataGridViewProductContract
            // 
            dataGridViewProductContract.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductContract.Location = new Point(23, 726);
            dataGridViewProductContract.Name = "dataGridViewProductContract";
            dataGridViewProductContract.RowHeadersWidth = 102;
            dataGridViewProductContract.RowTemplate.Height = 49;
            dataGridViewProductContract.Size = new Size(2012, 507);
            dataGridViewProductContract.TabIndex = 1;
            // 
            // buttonConstractAdd
            // 
            buttonConstractAdd.Location = new Point(36, 566);
            buttonConstractAdd.Name = "buttonConstractAdd";
            buttonConstractAdd.Size = new Size(227, 89);
            buttonConstractAdd.TabIndex = 2;
            buttonConstractAdd.Text = "Добавить";
            buttonConstractAdd.UseVisualStyleBackColor = true;
            // 
            // buttonContractEdit
            // 
            buttonContractEdit.Location = new Point(298, 563);
            buttonContractEdit.Name = "buttonContractEdit";
            buttonContractEdit.Size = new Size(213, 92);
            buttonContractEdit.TabIndex = 3;
            buttonContractEdit.Text = "Изменить";
            buttonContractEdit.UseVisualStyleBackColor = true;
            // 
            // buttonContractDelete
            // 
            buttonContractDelete.Location = new Point(560, 562);
            buttonContractDelete.Name = "buttonContractDelete";
            buttonContractDelete.Size = new Size(213, 94);
            buttonContractDelete.TabIndex = 4;
            buttonContractDelete.Text = "Удалить";
            buttonContractDelete.UseVisualStyleBackColor = true;
            // 
            // buttonProductContractAdd
            // 
            buttonProductContractAdd.Location = new Point(36, 1263);
            buttonProductContractAdd.Name = "buttonProductContractAdd";
            buttonProductContractAdd.Size = new Size(206, 84);
            buttonProductContractAdd.TabIndex = 5;
            buttonProductContractAdd.Text = "Добавить";
            buttonProductContractAdd.UseVisualStyleBackColor = true;
            // 
            // buttonProductContractEdit
            // 
            buttonProductContractEdit.Location = new Point(298, 1263);
            buttonProductContractEdit.Name = "buttonProductContractEdit";
            buttonProductContractEdit.Size = new Size(213, 84);
            buttonProductContractEdit.TabIndex = 6;
            buttonProductContractEdit.Text = "Изменить";
            buttonProductContractEdit.UseVisualStyleBackColor = true;
            // 
            // buttonProductContractDelete
            // 
            buttonProductContractDelete.Location = new Point(575, 1263);
            buttonProductContractDelete.Name = "buttonProductContractDelete";
            buttonProductContractDelete.Size = new Size(198, 84);
            buttonProductContractDelete.TabIndex = 7;
            buttonProductContractDelete.Text = "Удалить";
            buttonProductContractDelete.UseVisualStyleBackColor = true;
            // 
            // Producement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2075, 1406);
            Controls.Add(buttonProductContractDelete);
            Controls.Add(buttonProductContractEdit);
            Controls.Add(buttonProductContractAdd);
            Controls.Add(buttonContractDelete);
            Controls.Add(buttonContractEdit);
            Controls.Add(buttonConstractAdd);
            Controls.Add(dataGridViewProductContract);
            Controls.Add(dataGridViewContract);
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