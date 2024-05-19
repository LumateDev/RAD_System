namespace project_RAD
{
    partial class ReportForm
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
            labelReportTitle = new Label();
            labelDate1 = new Label();
            labelDate2 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            checkedListBoxProducers = new CheckedListBox();
            buttonCreateReport = new Button();
            buttonExcelReport = new Button();
            buttonCreateChart = new Button();
            richTextBox1 = new RichTextBox();
            buttonSelectAll = new Button();
            SuspendLayout();
            // 
            // labelReportTitle
            // 
            labelReportTitle.AutoSize = true;
            labelReportTitle.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelReportTitle.Location = new Point(30, 21);
            labelReportTitle.Name = "labelReportTitle";
            labelReportTitle.Size = new Size(349, 38);
            labelReportTitle.TabIndex = 0;
            labelReportTitle.Text = "Отчёт по поставщикам";
            // 
            // labelDate1
            // 
            labelDate1.AutoSize = true;
            labelDate1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate1.Location = new Point(71, 105);
            labelDate1.Name = "labelDate1";
            labelDate1.Size = new Size(155, 29);
            labelDate1.TabIndex = 1;
            labelDate1.Text = "Дата начала";
            // 
            // labelDate2
            // 
            labelDate2.AutoSize = true;
            labelDate2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate2.Location = new Point(71, 187);
            labelDate2.Name = "labelDate2";
            labelDate2.Size = new Size(142, 29);
            labelDate2.TabIndex = 2;
            labelDate2.Text = "Дата конца";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(71, 137);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(250, 27);
            dateTimePickerFrom.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(71, 219);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 27);
            dateTimePickerTo.TabIndex = 4;
            // 
            // checkedListBoxProducers
            // 
            checkedListBoxProducers.FormattingEnabled = true;
            checkedListBoxProducers.Location = new Point(71, 263);
            checkedListBoxProducers.Name = "checkedListBoxProducers";
            checkedListBoxProducers.Size = new Size(250, 224);
            checkedListBoxProducers.TabIndex = 5;
            // 
            // buttonCreateReport
            // 
            buttonCreateReport.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateReport.Location = new Point(72, 558);
            buttonCreateReport.Name = "buttonCreateReport";
            buttonCreateReport.Size = new Size(249, 40);
            buttonCreateReport.TabIndex = 6;
            buttonCreateReport.Text = "Создать отчёт";
            buttonCreateReport.UseVisualStyleBackColor = true;
            buttonCreateReport.Click += buttonCreateReport_Click;
            // 
            // buttonExcelReport
            // 
            buttonExcelReport.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExcelReport.Location = new Point(72, 604);
            buttonExcelReport.Name = "buttonExcelReport";
            buttonExcelReport.Size = new Size(249, 40);
            buttonExcelReport.TabIndex = 7;
            buttonExcelReport.Text = "Эскорпт в EXCEL";
            buttonExcelReport.UseVisualStyleBackColor = true;
            buttonExcelReport.Click += buttonExcelReport_Click;
            // 
            // buttonCreateChart
            // 
            buttonCreateChart.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateChart.Location = new Point(71, 650);
            buttonCreateChart.Name = "buttonCreateChart";
            buttonCreateChart.Size = new Size(250, 39);
            buttonCreateChart.TabIndex = 8;
            buttonCreateChart.Text = "Создать график";
            buttonCreateChart.UseVisualStyleBackColor = true;
            buttonCreateChart.Click += buttonCreateChart_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(410, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(634, 681);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new Point(69, 493);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(252, 29);
            buttonSelectAll.TabIndex = 10;
            buttonSelectAll.Text = "Выбрать всех";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 705);
            Controls.Add(buttonSelectAll);
            Controls.Add(richTextBox1);
            Controls.Add(buttonCreateChart);
            Controls.Add(buttonExcelReport);
            Controls.Add(buttonCreateReport);
            Controls.Add(checkedListBoxProducers);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(labelDate2);
            Controls.Add(labelDate1);
            Controls.Add(labelReportTitle);
            Name = "ReportForm";
            Text = "ReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelReportTitle;
        private Label labelDate1;
        private Label labelDate2;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private CheckedListBox checkedListBoxProducers;
        private Button buttonCreateReport;
        private Button buttonExcelReport;
        private Button buttonCreateChart;
        private RichTextBox richTextBox1;
        private Button buttonSelectAll;
    }
}