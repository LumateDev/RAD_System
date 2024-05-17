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
            dataGridViewProducers.Size = new Size(749, 252);
            dataGridViewProducers.TabIndex = 0;
            // 
            // buttonAddProducer
            // 
            buttonAddProducer.Location = new Point(25, 317);
            buttonAddProducer.Name = "buttonAddProducer";
            buttonAddProducer.Size = new Size(138, 45);
            buttonAddProducer.TabIndex = 1;
            buttonAddProducer.Text = "Добавить";
            buttonAddProducer.UseVisualStyleBackColor = true;
            buttonAddProducer.Click += buttonAddProducer_Click;
            // 
            // buttonEditProducer
            // 
            buttonEditProducer.Location = new Point(192, 317);
            buttonEditProducer.Name = "buttonEditProducer";
            buttonEditProducer.Size = new Size(126, 45);
            buttonEditProducer.TabIndex = 2;
            buttonEditProducer.Text = "Изменить";
            buttonEditProducer.UseVisualStyleBackColor = true;
            buttonEditProducer.Click += buttonEditProducer_Click;
            // 
            // buttonDeleteProducer
            // 
            buttonDeleteProducer.Location = new Point(352, 317);
            buttonDeleteProducer.Name = "buttonDeleteProducer";
            buttonDeleteProducer.Size = new Size(122, 45);
            buttonDeleteProducer.TabIndex = 3;
            buttonDeleteProducer.Text = "Удалить";
            buttonDeleteProducer.UseVisualStyleBackColor = true;
            buttonDeleteProducer.Click += buttonDeleteProducer_Click;
            // 
            // Producers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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