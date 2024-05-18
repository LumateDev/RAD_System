namespace Project_C_
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
            comboBoxProducerId = new ComboBox();
            textBoxProductCount = new TextBox();
            labelContractId = new Label();
            labelProducerId = new Label();
            labelContractCount = new Label();
            buttonPA_Add = new Button();
            buttonPA_Cancel = new Button();
            SuspendLayout();
            // 
            // comboBoxContractId
            // 
            comboBoxContractId.FormattingEnabled = true;
            comboBoxContractId.Location = new Point(332, 129);
            comboBoxContractId.Name = "comboBoxContractId";
            comboBoxContractId.Size = new Size(302, 49);
            comboBoxContractId.TabIndex = 0;
            // 
            // comboBoxProducerId
            // 
            comboBoxProducerId.FormattingEnabled = true;
            comboBoxProducerId.Location = new Point(332, 302);
            comboBoxProducerId.Name = "comboBoxProducerId";
            comboBoxProducerId.Size = new Size(302, 49);
            comboBoxProducerId.TabIndex = 1;
            // 
            // textBoxProductCount
            // 
            textBoxProductCount.Location = new Point(335, 475);
            textBoxProductCount.Name = "textBoxProductCount";
            textBoxProductCount.Size = new Size(302, 47);
            textBoxProductCount.TabIndex = 2;
            // 
            // labelContractId
            // 
            labelContractId.AutoSize = true;
            labelContractId.Location = new Point(335, 53);
            labelContractId.Name = "labelContractId";
            labelContractId.Size = new Size(262, 41);
            labelContractId.TabIndex = 3;
            labelContractId.Text = "Укажите контракт";
            // 
            // labelProducerId
            // 
            labelProducerId.AutoSize = true;
            labelProducerId.Location = new Point(335, 229);
            labelProducerId.Name = "labelProducerId";
            labelProducerId.Size = new Size(349, 41);
            labelProducerId.TabIndex = 4;
            labelProducerId.Text = "Укажите производителя";
            // 
            // labelContractCount
            // 
            labelContractCount.AutoSize = true;
            labelContractCount.Location = new Point(332, 394);
            labelContractCount.Name = "labelContractCount";
            labelContractCount.Size = new Size(299, 41);
            labelContractCount.TabIndex = 5;
            labelContractCount.Text = "Укажите количество";
            // 
            // buttonPA_Add
            // 
            buttonPA_Add.Location = new Point(268, 583);
            buttonPA_Add.Name = "buttonPA_Add";
            buttonPA_Add.Size = new Size(188, 58);
            buttonPA_Add.TabIndex = 6;
            buttonPA_Add.Text = "Добавить";
            buttonPA_Add.UseVisualStyleBackColor = true;
            // 
            // buttonPA_Cancel
            // 
            buttonPA_Cancel.Location = new Point(511, 583);
            buttonPA_Cancel.Name = "buttonPA_Cancel";
            buttonPA_Cancel.Size = new Size(188, 58);
            buttonPA_Cancel.TabIndex = 7;
            buttonPA_Cancel.Text = "Отмена";
            buttonPA_Cancel.UseVisualStyleBackColor = true;
            // 
            // Producement_ProductContractActions
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 706);
            Controls.Add(buttonPA_Cancel);
            Controls.Add(buttonPA_Add);
            Controls.Add(labelContractCount);
            Controls.Add(labelProducerId);
            Controls.Add(labelContractId);
            Controls.Add(textBoxProductCount);
            Controls.Add(comboBoxProducerId);
            Controls.Add(comboBoxContractId);
            Name = "Producement_ProductContractActions";
            Text = "Producement_ProductContractActions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxContractId;
        private ComboBox comboBoxProducerId;
        private TextBox textBoxProductCount;
        private Label labelContractId;
        private Label labelProducerId;
        private Label labelContractCount;
        private Button buttonPA_Add;
        private Button buttonPA_Cancel;
    }
}