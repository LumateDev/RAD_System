namespace project_2_RAD
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
            countTextBox = new TextBox();
            butttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // formButtonAdd
            // 
            formButtonAdd.BackColor = Color.LimeGreen;
            formButtonAdd.Location = new Point(136, 341);
            formButtonAdd.Name = "formButtonAdd";
            formButtonAdd.Size = new Size(250, 63);
            formButtonAdd.TabIndex = 0;
            formButtonAdd.Text = "Добавить товар";
            formButtonAdd.UseVisualStyleBackColor = false;
            formButtonAdd.Click += formButtonAdd_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(280, 94);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 47);
            nameTextBox.TabIndex = 1;
            // 
            // countTextBox
            // 
            countTextBox.Location = new Point(280, 237);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(250, 47);
            countTextBox.TabIndex = 2;
            // 
            // butttonCancel
            // 
            butttonCancel.BackColor = Color.IndianRed;
            butttonCancel.Location = new Point(414, 343);
            butttonCancel.Name = "butttonCancel";
            butttonCancel.Size = new Size(250, 58);
            butttonCancel.TabIndex = 3;
            butttonCancel.Text = "Отмена";
            butttonCancel.UseVisualStyleBackColor = false;
            butttonCancel.Click += butttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 35);
            label1.Name = "label1";
            label1.Size = new Size(326, 41);
            label1.TabIndex = 4;
            label1.Text = "Наименование товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 181);
            label2.Name = "label2";
            label2.Size = new Size(281, 41);
            label2.TabIndex = 5;
            label2.Text = "Количество товара";
            // 
            // Products_Actions
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
            Name = "Products_Actions";
            Text = "Products_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button formButtonAdd;
        private TextBox nameTextBox;
        private TextBox countTextBox;
        private Button butttonCancel;
        private Label label1;
        private Label label2;
    }
}