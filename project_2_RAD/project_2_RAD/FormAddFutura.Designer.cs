namespace project_2_RAD
{
    partial class FormAddFutura
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
            checkDateTimePicker = new DateTimePicker();
            ChechComboBox = new ComboBox();
            buttonAddFutura = new Button();
            SuspendLayout();
            // 
            // checkDateTimePicker
            // 
            checkDateTimePicker.Font = new Font("Microsoft YaHei UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            checkDateTimePicker.Location = new Point(24, 159);
            checkDateTimePicker.Name = "checkDateTimePicker";
            checkDateTimePicker.Size = new Size(500, 67);
            checkDateTimePicker.TabIndex = 4;
            // 
            // ChechComboBox
            // 
            ChechComboBox.Font = new Font("Microsoft YaHei UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            ChechComboBox.FormattingEnabled = true;
            ChechComboBox.Location = new Point(24, 25);
            ChechComboBox.Name = "ChechComboBox";
            ChechComboBox.Size = new Size(500, 68);
            ChechComboBox.TabIndex = 3;
            // 
            // buttonAddFutura
            // 
            buttonAddFutura.Location = new Point(24, 287);
            buttonAddFutura.Name = "buttonAddFutura";
            buttonAddFutura.Size = new Size(500, 58);
            buttonAddFutura.TabIndex = 5;
            buttonAddFutura.Text = "Добавить";
            buttonAddFutura.UseVisualStyleBackColor = true;
            // 
            // FormAddFutura
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 730);
            Controls.Add(buttonAddFutura);
            Controls.Add(checkDateTimePicker);
            Controls.Add(ChechComboBox);
            Name = "FormAddFutura";
            Text = "FormAddFutura";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker checkDateTimePicker;
        private ComboBox ChechComboBox;
        private Button buttonAddFutura;
    }
}