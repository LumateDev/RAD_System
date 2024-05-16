namespace project_2_RAD
{
    partial class Clients
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
            dataGridViewClient = new DataGridView();
            buttonClientAdd = new Button();
            buttonClientEdit = new Button();
            buttonClientDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(50, 58);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.RowHeadersWidth = 102;
            dataGridViewClient.RowTemplate.Height = 49;
            dataGridViewClient.Size = new Size(1146, 413);
            dataGridViewClient.TabIndex = 0;
            // 
            // buttonClientAdd
            // 
            buttonClientAdd.Location = new Point(50, 561);
            buttonClientAdd.Name = "buttonClientAdd";
            buttonClientAdd.Size = new Size(188, 58);
            buttonClientAdd.TabIndex = 1;
            buttonClientAdd.Text = "Добавить";
            buttonClientAdd.UseVisualStyleBackColor = true;
            buttonClientAdd.Click += buttonClientAdd_Click;
            // 
            // buttonClientEdit
            // 
            buttonClientEdit.Location = new Point(290, 561);
            buttonClientEdit.Name = "buttonClientEdit";
            buttonClientEdit.Size = new Size(188, 58);
            buttonClientEdit.TabIndex = 2;
            buttonClientEdit.Text = "Изменить";
            buttonClientEdit.UseVisualStyleBackColor = true;
            buttonClientEdit.Click += buttonClientEdit_Click;
            // 
            // buttonClientDelete
            // 
            buttonClientDelete.Location = new Point(528, 561);
            buttonClientDelete.Name = "buttonClientDelete";
            buttonClientDelete.Size = new Size(188, 58);
            buttonClientDelete.TabIndex = 3;
            buttonClientDelete.Text = "Удалить";
            buttonClientDelete.UseVisualStyleBackColor = true;
            buttonClientDelete.Click += buttonClientDelete_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 729);
            Controls.Add(buttonClientDelete);
            Controls.Add(buttonClientEdit);
            Controls.Add(buttonClientAdd);
            Controls.Add(dataGridViewClient);
            Name = "Clients";
            Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClient;
        private Button buttonClientAdd;
        private Button buttonClientEdit;
        private Button buttonClientDelete;
    }
}