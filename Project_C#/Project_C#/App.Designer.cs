namespace Project_C_
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            invoiceShowBtn = new Button();
            buyShowBtn = new Button();
            producersShowBtn = new Button();
            productShowBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaptionText;
            panel1.Controls.Add(invoiceShowBtn);
            panel1.Controls.Add(buyShowBtn);
            panel1.Controls.Add(producersShowBtn);
            panel1.Controls.Add(productShowBtn);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 84);
            panel1.TabIndex = 0;
            // 
            // invoiceShowBtn
            // 
            invoiceShowBtn.BackColor = SystemColors.Info;
            invoiceShowBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            invoiceShowBtn.Location = new Point(924, 21);
            invoiceShowBtn.Margin = new Padding(1, 1, 1, 1);
            invoiceShowBtn.Name = "invoiceShowBtn";
            invoiceShowBtn.Size = new Size(247, 44);
            invoiceShowBtn.TabIndex = 3;
            invoiceShowBtn.Text = "Накладная";
            invoiceShowBtn.UseVisualStyleBackColor = false;
            invoiceShowBtn.Click += invoiceShowBtn_Click;
            // 
            // buyShowBtn
            // 
            buyShowBtn.BackColor = SystemColors.Info;
            buyShowBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buyShowBtn.Location = new Point(622, 21);
            buyShowBtn.Margin = new Padding(1, 1, 1, 1);
            buyShowBtn.Name = "buyShowBtn";
            buyShowBtn.Size = new Size(247, 44);
            buyShowBtn.TabIndex = 2;
            buyShowBtn.Text = "Закупки";
            buyShowBtn.UseVisualStyleBackColor = false;
            buyShowBtn.Click += buyShowBtn_Click;
            // 
            // producersShowBtn
            // 
            producersShowBtn.BackColor = SystemColors.Info;
            producersShowBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            producersShowBtn.Location = new Point(302, 21);
            producersShowBtn.Margin = new Padding(1, 1, 1, 1);
            producersShowBtn.Name = "producersShowBtn";
            producersShowBtn.Size = new Size(247, 44);
            producersShowBtn.TabIndex = 1;
            producersShowBtn.Text = "Поставщики";
            producersShowBtn.UseVisualStyleBackColor = false;
            producersShowBtn.Click += producersShowBtn_Click;
            // 
            // productShowBtn
            // 
            productShowBtn.BackColor = SystemColors.Info;
            productShowBtn.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            productShowBtn.Location = new Point(14, 21);
            productShowBtn.Margin = new Padding(1, 1, 1, 1);
            productShowBtn.Name = "productShowBtn";
            productShowBtn.Size = new Size(234, 44);
            productShowBtn.TabIndex = 0;
            productShowBtn.Text = "Товары";
            productShowBtn.UseVisualStyleBackColor = false;
            productShowBtn.Click += productShowBtn_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "App";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button producersShowBtn;
        private Button productShowBtn;
        private Button buyShowBtn;
        private Button invoiceShowBtn;
    }
}