namespace project_2_RAD
{
    partial class Clients_Actions
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
            phoneTextBox = new TextBox();
            nameTextBox = new TextBox();
            formButtonAdd = new Button();
            label3 = new Label();
            adressTextBox1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 332);
            label2.Name = "label2";
            label2.Size = new Size(254, 41);
            label2.TabIndex = 11;
            label2.Text = "Телефон клиента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 58);
            label1.Name = "label1";
            label1.Size = new Size(192, 41);
            label1.TabIndex = 10;
            label1.Text = "Имя клиента";
            label1.Click += label1_Click;
            // 
            // butttonCancel
            // 
            butttonCancel.BackColor = Color.IndianRed;
            butttonCancel.Location = new Point(360, 480);
            butttonCancel.Name = "butttonCancel";
            butttonCancel.Size = new Size(250, 58);
            butttonCancel.TabIndex = 9;
            butttonCancel.Text = "Отмена";
            butttonCancel.UseVisualStyleBackColor = false;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(241, 396);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(250, 47);
            phoneTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(241, 121);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 47);
            nameTextBox.TabIndex = 7;
            // 
            // formButtonAdd
            // 
            formButtonAdd.BackColor = Color.LimeGreen;
            formButtonAdd.Location = new Point(88, 475);
            formButtonAdd.Name = "formButtonAdd";
            formButtonAdd.Size = new Size(250, 63);
            formButtonAdd.TabIndex = 6;
            formButtonAdd.Text = "Добавить товар";
            formButtonAdd.UseVisualStyleBackColor = false;
            formButtonAdd.Click += formButtonAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 194);
            label3.Name = "label3";
            label3.Size = new Size(231, 41);
            label3.TabIndex = 13;
            label3.Text = "Адресс клиента";
            // 
            // adressTextBox1
            // 
            adressTextBox1.Location = new Point(241, 263);
            adressTextBox1.Name = "adressTextBox1";
            adressTextBox1.Size = new Size(250, 47);
            adressTextBox1.TabIndex = 12;
            // 
            // Clients_Actions
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 626);
            Controls.Add(label3);
            Controls.Add(adressTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butttonCancel);
            Controls.Add(phoneTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(formButtonAdd);
            Name = "Clients_Actions";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button butttonCancel;
        private TextBox phoneTextBox;
        private TextBox nameTextBox;
        private Button formButtonAdd;
        private Label label3;
        private TextBox adressTextBox1;
    }
}