namespace project_RAD
{
    partial class Producement_ContractActions
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
            comboBoxSelectProducer = new ComboBox();
            dateTimePickerContract = new DateTimePicker();
            textBoxPayment = new TextBox();
            labelProducerId = new Label();
            labelContractDate = new Label();
            labelContractPayment = new Label();
            buttonContractAdd = new Button();
            buttonContractCancel = new Button();
            comboBoxPaymentStatus = new ComboBox();
            labelPaymentStatus = new Label();
            SuspendLayout();
            // 
            // comboBoxSelectProducer
            // 
            comboBoxSelectProducer.FormattingEnabled = true;
            comboBoxSelectProducer.Location = new Point(97, 42);
            comboBoxSelectProducer.Name = "comboBoxSelectProducer";
            comboBoxSelectProducer.Size = new Size(248, 28);
            comboBoxSelectProducer.TabIndex = 0;
            // 
            // dateTimePickerContract
            // 
            dateTimePickerContract.Location = new Point(95, 115);
            dateTimePickerContract.Name = "dateTimePickerContract";
            dateTimePickerContract.Size = new Size(250, 27);
            dateTimePickerContract.TabIndex = 1;
            // 
            // textBoxPayment
            // 
            textBoxPayment.Location = new Point(95, 272);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(248, 27);
            textBoxPayment.TabIndex = 2;
            // 
            // labelProducerId
            // 
            labelProducerId.AutoSize = true;
            labelProducerId.Location = new Point(99, 9);
            labelProducerId.Name = "labelProducerId";
            labelProducerId.Size = new Size(178, 20);
            labelProducerId.TabIndex = 3;
            labelProducerId.Text = "Укажите производителя";
            // 
            // labelContractDate
            // 
            labelContractDate.AutoSize = true;
            labelContractDate.Location = new Point(97, 83);
            labelContractDate.Name = "labelContractDate";
            labelContractDate.Size = new Size(173, 20);
            labelContractDate.TabIndex = 4;
            labelContractDate.Text = "Укажите дату контракта";
            // 
            // labelContractPayment
            // 
            labelContractPayment.AutoSize = true;
            labelContractPayment.Location = new Point(95, 232);
            labelContractPayment.Name = "labelContractPayment";
            labelContractPayment.Size = new Size(132, 20);
            labelContractPayment.TabIndex = 5;
            labelContractPayment.Text = "Внесённая сумма";
            // 
            // buttonContractAdd
            // 
            buttonContractAdd.BackColor = Color.LimeGreen;
            buttonContractAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContractAdd.Location = new Point(95, 330);
            buttonContractAdd.Name = "buttonContractAdd";
            buttonContractAdd.Size = new Size(118, 44);
            buttonContractAdd.TabIndex = 6;
            buttonContractAdd.Text = "Добавить";
            buttonContractAdd.UseVisualStyleBackColor = false;
            buttonContractAdd.Click += buttonContractAdd_Click;
            // 
            // buttonContractCancel
            // 
            buttonContractCancel.BackColor = Color.IndianRed;
            buttonContractCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContractCancel.Location = new Point(235, 330);
            buttonContractCancel.Name = "buttonContractCancel";
            buttonContractCancel.Size = new Size(110, 44);
            buttonContractCancel.TabIndex = 7;
            buttonContractCancel.Text = "Отмена";
            buttonContractCancel.UseVisualStyleBackColor = false;
            buttonContractCancel.Click += buttonContractCancel_Click;
            // 
            // comboBoxPaymentStatus
            // 
            comboBoxPaymentStatus.FormattingEnabled = true;
            comboBoxPaymentStatus.Items.AddRange(new object[] { "оплачено", "предоплата", "не оплачено" });
            comboBoxPaymentStatus.Location = new Point(95, 190);
            comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            comboBoxPaymentStatus.Size = new Size(151, 28);
            comboBoxPaymentStatus.TabIndex = 8;
            // 
            // labelPaymentStatus
            // 
            labelPaymentStatus.AutoSize = true;
            labelPaymentStatus.Location = new Point(101, 159);
            labelPaymentStatus.Name = "labelPaymentStatus";
            labelPaymentStatus.Size = new Size(114, 20);
            labelPaymentStatus.TabIndex = 9;
            labelPaymentStatus.Text = "Статус платежа";
            // 
            // Producement_ContractActions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 399);
            Controls.Add(labelPaymentStatus);
            Controls.Add(comboBoxPaymentStatus);
            Controls.Add(buttonContractCancel);
            Controls.Add(buttonContractAdd);
            Controls.Add(labelContractPayment);
            Controls.Add(labelContractDate);
            Controls.Add(labelProducerId);
            Controls.Add(textBoxPayment);
            Controls.Add(dateTimePickerContract);
            Controls.Add(comboBoxSelectProducer);
            Name = "Producement_ContractActions";
            Text = "Producement_Actions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSelectProducer;
        private DateTimePicker dateTimePickerContract;
        private TextBox textBoxPayment;
        private Label labelProducerId;
        private Label labelContractDate;
        private Label labelContractPayment;
        private Button buttonContractAdd;
        private Button buttonContractCancel;
        private ComboBox comboBoxPaymentStatus;
        private Label labelPaymentStatus;
    }
}