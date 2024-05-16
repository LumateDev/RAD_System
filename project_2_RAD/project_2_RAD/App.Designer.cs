namespace project_2_RAD
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
            buttonShow = new Button();
            panel1 = new Panel();
            button_Check = new Button();
            buttonClientShow = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonShow
            // 
            buttonShow.BackColor = SystemColors.ActiveCaptionText;
            buttonShow.FlatAppearance.BorderSize = 0;
            buttonShow.FlatStyle = FlatStyle.Flat;
            buttonShow.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShow.ForeColor = SystemColors.Info;
            buttonShow.Location = new Point(32, 35);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(234, 80);
            buttonShow.TabIndex = 0;
            buttonShow.Text = "Товары";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += button_show;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button_Check);
            panel1.Controls.Add(buttonClientShow);
            panel1.Controls.Add(buttonShow);
            panel1.Location = new Point(-4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 159);
            panel1.TabIndex = 1;
            // 
            // button_Check
            // 
            button_Check.BackColor = SystemColors.ActiveCaptionText;
            button_Check.FlatAppearance.BorderSize = 0;
            button_Check.FlatStyle = FlatStyle.Flat;
            button_Check.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Check.ForeColor = SystemColors.Info;
            button_Check.Location = new Point(512, 35);
            button_Check.Name = "button_Check";
            button_Check.Size = new Size(234, 80);
            button_Check.TabIndex = 2;
            button_Check.Text = "Чеки";
            button_Check.UseVisualStyleBackColor = false;
            button_Check.Click += button_Check_Click;
            // 
            // buttonClientShow
            // 
            buttonClientShow.BackColor = SystemColors.ActiveCaptionText;
            buttonClientShow.FlatAppearance.BorderSize = 0;
            buttonClientShow.FlatStyle = FlatStyle.Flat;
            buttonClientShow.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClientShow.ForeColor = SystemColors.Info;
            buttonClientShow.Location = new Point(272, 35);
            buttonClientShow.Name = "buttonClientShow";
            buttonClientShow.Size = new Size(234, 80);
            buttonClientShow.TabIndex = 1;
            buttonClientShow.Text = "Клиенты";
            buttonClientShow.UseVisualStyleBackColor = false;
            buttonClientShow.Click += buttonClientShow_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 945);
            Controls.Add(panel1);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonShow;
        private Panel panel1;
        private Button buttonClientShow;
        private Button button_Check;
    }
}