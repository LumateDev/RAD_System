namespace Project_C_
{
    partial class ProductsGrid
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
            label2 = new Label();
            label1 = new Label();
            butttonCancel = new Button();
            countTextBox = new TextBox();
            nameTextBox = new TextBox();
            formButtonAdd = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 187);
            label2.Name = "label2";
            label2.Size = new Size(281, 41);
            label2.TabIndex = 11;
            label2.Text = "Количество товара";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 41);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 10;
            label1.Text = "Наименование товара";
            // 
            // butttonCancel
            // 
            butttonCancel.BackColor = Color.IndianRed;
            butttonCancel.Location = new Point(414, 349);
            butttonCancel.Name = "butttonCancel";
            butttonCancel.Size = new Size(250, 58);
            butttonCancel.TabIndex = 9;
            butttonCancel.Text = "Отмена";
            butttonCancel.UseVisualStyleBackColor = false;
            // 
            // countTextBox
            // 
            countTextBox.Location = new Point(280, 243);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(250, 47);
            countTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(280, 100);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 47);
            nameTextBox.TabIndex = 7;
            // 
            // formButtonAdd
            // 
            formButtonAdd.BackColor = Color.LimeGreen;
            formButtonAdd.Location = new Point(136, 347);
            formButtonAdd.Name = "formButtonAdd";
            formButtonAdd.Size = new Size(250, 63);
            formButtonAdd.TabIndex = 6;
            formButtonAdd.Text = "Добавить товар";
            formButtonAdd.UseVisualStyleBackColor = false;
            // 
            // ProductsGrid
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butttonCancel);
            Controls.Add(countTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(formButtonAdd);
            Name = "ProductsGrid";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button butttonCancel;
        private TextBox countTextBox;
        private TextBox nameTextBox;
        private Button formButtonAdd;
    }
}