namespace project_RAD
{
    partial class Producers
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
            dataGridViewProducers = new DataGridView();
            buttonAddProducer = new Button();
            buttonEditProducer = new Button();
            buttonDeleteProducer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducers
            // 
            dataGridViewProducers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducers.Location = new Point(25, 27);
            dataGridViewProducers.Name = "dataGridViewProducers";
            dataGridViewProducers.RowHeadersWidth = 51;
            dataGridViewProducers.RowTemplate.Height = 29;
            dataGridViewProducers.Size = new Size(1136, 618);
            dataGridViewProducers.TabIndex = 0;
            // 
            // buttonAddProducer
            // 
            buttonAddProducer.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProducer.Location = new Point(25, 665);
            buttonAddProducer.Name = "buttonAddProducer";
            buttonAddProducer.Size = new Size(138, 45);
            buttonAddProducer.TabIndex = 1;
            buttonAddProducer.Text = "Добавить";
            buttonAddProducer.UseVisualStyleBackColor = false;
            buttonAddProducer.Click += buttonAddProducer_Click;
            // 
            // buttonEditProducer
            // 
            buttonEditProducer.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProducer.Location = new Point(205, 665);
            buttonEditProducer.Name = "buttonEditProducer";
            buttonEditProducer.Size = new Size(144, 45);
            buttonEditProducer.TabIndex = 2;
            buttonEditProducer.Text = "Изменить";
            buttonEditProducer.UseVisualStyleBackColor = false;
            buttonEditProducer.Click += buttonEditProducer_Click;
            // 
            // buttonDeleteProducer
            // 
            buttonDeleteProducer.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteProducer.Location = new Point(389, 665);
            buttonDeleteProducer.Name = "buttonDeleteProducer";
            buttonDeleteProducer.Size = new Size(150, 45);
            buttonDeleteProducer.TabIndex = 3;
            buttonDeleteProducer.Text = "Удалить";
            buttonDeleteProducer.UseVisualStyleBackColor = false;
            buttonDeleteProducer.Click += buttonDeleteProducer_Click;
            // 
            // Producers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(buttonDeleteProducer);
            Controls.Add(buttonEditProducer);
            Controls.Add(buttonAddProducer);
            Controls.Add(dataGridViewProducers);
            Name = "Producers";
            Text = "Producers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducers;
        private Button buttonAddProducer;
        private Button buttonEditProducer;
        private Button buttonDeleteProducer;
    }
}