namespace project_RAD
{
    partial class Products_Actions
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
            formButtonAdd = new Button();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            butttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // formButtonAdd
            // 
            formButtonAdd.BackColor = Color.LimeGreen;
            formButtonAdd.Location = new Point(64, 166);
            formButtonAdd.Margin = new Padding(1);
            formButtonAdd.Name = "formButtonAdd";
            formButtonAdd.Size = new Size(118, 31);
            formButtonAdd.TabIndex = 0;
            formButtonAdd.Text = "Добавить товар";
            formButtonAdd.UseVisualStyleBackColor = false;
            formButtonAdd.Click += formButtonAdd_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(132, 46);
            nameTextBox.Margin = new Padding(1);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(120, 27);
            nameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(132, 116);
            priceTextBox.Margin = new Padding(1);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(120, 27);
            priceTextBox.TabIndex = 2;
            // 
            // butttonCancel
            // 
            butttonCancel.BackColor = Color.IndianRed;
            butttonCancel.Location = new Point(195, 167);
            butttonCancel.Margin = new Padding(1);
            butttonCancel.Name = "butttonCancel";
            butttonCancel.Size = new Size(118, 28);
            butttonCancel.TabIndex = 3;
            butttonCancel.Text = "Отмена";
            butttonCancel.UseVisualStyleBackColor = false;
            butttonCancel.Click += butttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 17);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 4;
            label1.Text = "Наименование товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 88);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Цена товара";
            label2.Click += label2_Click;
            // 
            // Products_Actions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 220);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butttonCancel);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(formButtonAdd);
            Margin = new Padding(1);
            Name = "Products_Actions";
            Text = "Products_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button formButtonAdd;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private Button butttonCancel;
        private Label label1;
        private Label label2;
    }
}