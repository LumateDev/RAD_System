namespace project_RAD
{
    partial class Products
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
            dataGridViewProduct = new DataGridView();
            buttonAddProduct = new Button();
            buttonDeleteProduct = new Button();
            buttonEditProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(18, 46);
            dataGridViewProduct.Margin = new Padding(1, 1, 1, 1);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 102;
            dataGridViewProduct.RowTemplate.Height = 49;
            dataGridViewProduct.Size = new Size(1154, 601);
            dataGridViewProduct.TabIndex = 0;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(18, 684);
            buttonAddProduct.Margin = new Padding(1, 1, 1, 1);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(141, 47);
            buttonAddProduct.TabIndex = 1;
            buttonAddProduct.Text = "Добавить";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(297, 684);
            buttonDeleteProduct.Margin = new Padding(1, 1, 1, 1);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(131, 47);
            buttonDeleteProduct.TabIndex = 2;
            buttonDeleteProduct.Text = "Удалить";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Location = new Point(166, 684);
            buttonEditProduct.Margin = new Padding(1, 1, 1, 1);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(119, 47);
            buttonEditProduct.TabIndex = 3;
            buttonEditProduct.Text = "Изменить";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(buttonEditProduct);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonAddProduct);
            Controls.Add(dataGridViewProduct);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProduct;
        private Button buttonAddProduct;
        private Button buttonDeleteProduct;
        private Label labelInfo;
        private Button buttonEditProduct;
    }
}