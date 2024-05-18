namespace project_RAD
{
    partial class Producers_Actions
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
            labelProducerName = new Label();
            labelProducerPhone = new Label();
            textBoxProducerName = new TextBox();
            textBoxProducerPhone = new TextBox();
            buttonProducerAdd = new Button();
            buttonProducerCancel = new Button();
            SuspendLayout();
            // 
            // labelProducerName
            // 
            labelProducerName.AutoSize = true;
            labelProducerName.Location = new Point(135, 40);
            labelProducerName.Name = "labelProducerName";
            labelProducerName.Size = new Size(203, 20);
            labelProducerName.TabIndex = 0;
            labelProducerName.Text = "Наименование поставщика";
            // 
            // labelProducerPhone
            // 
            labelProducerPhone.AutoSize = true;
            labelProducerPhone.Location = new Point(151, 147);
            labelProducerPhone.Name = "labelProducerPhone";
            labelProducerPhone.Size = new Size(156, 20);
            labelProducerPhone.TabIndex = 1;
            labelProducerPhone.Text = "Телефон поставщика";
            // 
            // textBoxProducerName
            // 
            textBoxProducerName.Location = new Point(182, 91);
            textBoxProducerName.Name = "textBoxProducerName";
            textBoxProducerName.Size = new Size(125, 27);
            textBoxProducerName.TabIndex = 2;
            // 
            // textBoxProducerPhone
            // 
            textBoxProducerPhone.Location = new Point(182, 194);
            textBoxProducerPhone.Name = "textBoxProducerPhone";
            textBoxProducerPhone.Size = new Size(125, 27);
            textBoxProducerPhone.TabIndex = 3;
            // 
            // buttonProducerAdd
            // 
            buttonProducerAdd.BackColor = Color.LimeGreen;
            buttonProducerAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProducerAdd.Location = new Point(97, 267);
            buttonProducerAdd.Name = "buttonProducerAdd";
            buttonProducerAdd.Size = new Size(135, 38);
            buttonProducerAdd.TabIndex = 4;
            buttonProducerAdd.Text = "Добавить";
            buttonProducerAdd.UseVisualStyleBackColor = false;
            buttonProducerAdd.Click += buttonProducerAdd_Click;
            // 
            // buttonProducerCancel
            // 
            buttonProducerCancel.BackColor = Color.IndianRed;
            buttonProducerCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProducerCancel.Location = new Point(256, 267);
            buttonProducerCancel.Name = "buttonProducerCancel";
            buttonProducerCancel.Size = new Size(129, 40);
            buttonProducerCancel.TabIndex = 5;
            buttonProducerCancel.Text = "Отмена";
            buttonProducerCancel.UseVisualStyleBackColor = false;
            buttonProducerCancel.Click += buttonProducerCancel_Click;
            // 
            // Producers_Actions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 355);
            Controls.Add(buttonProducerCancel);
            Controls.Add(buttonProducerAdd);
            Controls.Add(textBoxProducerPhone);
            Controls.Add(textBoxProducerName);
            Controls.Add(labelProducerPhone);
            Controls.Add(labelProducerName);
            Name = "Producers_Actions";
            Text = "Producers_Actions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProducerName;
        private Label labelProducerPhone;
        private TextBox textBoxProducerName;
        private TextBox textBoxProducerPhone;
        private Button buttonProducerAdd;
        private Button buttonProducerCancel;
    }
}