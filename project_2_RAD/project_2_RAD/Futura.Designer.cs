namespace project_2_RAD
{
    partial class Futura
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
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            futuraInfoToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewFutura = new DataGridView();
            dataGridViewFuturaInfo = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFutura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuturaInfo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2229, 86);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productToolStripMenuItem, futuraInfoToolStripMenuItem });
            addToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(345, 82);
            addToolStripMenuItem.Text = "Добавить";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(534, 86);
            productToolStripMenuItem.Text = "Товар";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // futuraInfoToolStripMenuItem
            // 
            futuraInfoToolStripMenuItem.Name = "futuraInfoToolStripMenuItem";
            futuraInfoToolStripMenuItem.Size = new Size(534, 86);
            futuraInfoToolStripMenuItem.Text = "Накладная";
            futuraInfoToolStripMenuItem.Click += futuraInfoToolStripMenuItem_Click;
            // 
            // dataGridViewFutura
            // 
            dataGridViewFutura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFutura.Location = new Point(31, 192);
            dataGridViewFutura.Name = "dataGridViewFutura";
            dataGridViewFutura.RowHeadersWidth = 102;
            dataGridViewFutura.RowTemplate.Height = 49;
            dataGridViewFutura.Size = new Size(2159, 508);
            dataGridViewFutura.TabIndex = 3;
            // 
            // dataGridViewFuturaInfo
            // 
            dataGridViewFuturaInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuturaInfo.Location = new Point(31, 802);
            dataGridViewFuturaInfo.Name = "dataGridViewFuturaInfo";
            dataGridViewFuturaInfo.RowHeadersWidth = 102;
            dataGridViewFuturaInfo.RowTemplate.Height = 49;
            dataGridViewFuturaInfo.Size = new Size(2167, 467);
            dataGridViewFuturaInfo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 137);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 5;
            label1.Text = "Futura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 755);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 6;
            label2.Text = "Futura info";
            // 
            // Futura
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2229, 1329);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewFuturaInfo);
            Controls.Add(dataGridViewFutura);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Futura";
            Text = "Futura";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFutura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuturaInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem futuraInfoToolStripMenuItem;
        private DataGridView dataGridViewFutura;
        private DataGridView dataGridViewFuturaInfo;
        private Label label1;
        private Label label2;
    }
}