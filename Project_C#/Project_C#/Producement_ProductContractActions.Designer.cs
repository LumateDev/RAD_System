namespace project_RAD
{
    partial class Producement_ProductContractActions
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
            comboBoxContractId = new ComboBox();
            comboBoxProduct = new ComboBox();
            textBoxProductCount = new TextBox();
            labelContractId = new Label();
            labelProducts = new Label();
            labelContractCount = new Label();
            buttonPA_Add = new Button();
            buttonPA_Cancel = new Button();
            SuspendLayout();
            // 
            // comboBoxContractId
            // 
            comboBoxContractId.FormattingEnabled = true;
            comboBoxContractId.Location = new Point(156, 63);
            comboBoxContractId.Margin = new Padding(1);
            comboBoxContractId.Name = "comboBoxContractId";
            comboBoxContractId.Size = new Size(144, 28);
            comboBoxContractId.TabIndex = 0;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(156, 147);
            comboBoxProduct.Margin = new Padding(1);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(144, 28);
            comboBoxProduct.TabIndex = 1;
            // 
            // textBoxProductCount
            // 
            textBoxProductCount.Location = new Point(158, 232);
            textBoxProductCount.Margin = new Padding(1);
            textBoxProductCount.Name = "textBoxProductCount";
            textBoxProductCount.Size = new Size(144, 27);
            textBoxProductCount.TabIndex = 2;
            // 
            // labelContractId
            // 
            labelContractId.AutoSize = true;
            labelContractId.Location = new Point(158, 26);
            labelContractId.Margin = new Padding(1, 0, 1, 0);
            labelContractId.Name = "labelContractId";
            labelContractId.Size = new Size(132, 20);
            labelContractId.TabIndex = 3;
            labelContractId.Text = "Укажите контракт";
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Location = new Point(158, 112);
            labelProducts.Margin = new Padding(1, 0, 1, 0);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(126, 20);
            labelProducts.TabIndex = 4;
            labelProducts.Text = "Укажите продукт";
            // 
            // labelContractCount
            // 
            labelContractCount.AutoSize = true;
            labelContractCount.Location = new Point(156, 192);
            labelContractCount.Margin = new Padding(1, 0, 1, 0);
            labelContractCount.Name = "labelContractCount";
            labelContractCount.Size = new Size(150, 20);
            labelContractCount.TabIndex = 5;
            labelContractCount.Text = "Укажите количество";
            // 
            // buttonPA_Add
            // 
            buttonPA_Add.BackColor = Color.LimeGreen;
            buttonPA_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPA_Add.Location = new Point(106, 284);
            buttonPA_Add.Margin = new Padding(1);
            buttonPA_Add.Name = "buttonPA_Add";
            buttonPA_Add.Size = new Size(112, 50);
            buttonPA_Add.TabIndex = 6;
            buttonPA_Add.Text = "Добавить";
            buttonPA_Add.UseVisualStyleBackColor = false;
            buttonPA_Add.Click += buttonPA_Add_Click;
            // 
            // buttonPA_Cancel
            // 
            buttonPA_Cancel.BackColor = Color.IndianRed;
            buttonPA_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPA_Cancel.Location = new Point(249, 284);
            buttonPA_Cancel.Margin = new Padding(1);
            buttonPA_Cancel.Name = "buttonPA_Cancel";
            buttonPA_Cancel.Size = new Size(103, 50);
            buttonPA_Cancel.TabIndex = 7;
            buttonPA_Cancel.Text = "Отмена";
            buttonPA_Cancel.UseVisualStyleBackColor = false;
            buttonPA_Cancel.Click += buttonPA_Cancel_Click;
            // 
            // Producement_ProductContractActions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 344);
            Controls.Add(buttonPA_Cancel);
            Controls.Add(buttonPA_Add);
            Controls.Add(labelContractCount);
            Controls.Add(labelProducts);
            Controls.Add(labelContractId);
            Controls.Add(textBoxProductCount);
            Controls.Add(comboBoxProduct);
            Controls.Add(comboBoxContractId);
            Margin = new Padding(1);
            Name = "Producement_ProductContractActions";
            Text = "Producement_ProductContractActions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxContractId;
        private ComboBox comboBoxProduct;
        private TextBox textBoxProductCount;
        private Label labelContractId;
        private Label labelProducts;
        private Label labelContractCount;
        private Button buttonPA_Add;
        private Button buttonPA_Cancel;
    }
}