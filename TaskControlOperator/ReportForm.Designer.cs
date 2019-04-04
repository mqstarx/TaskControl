namespace TaskControlOperator
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
            this.period = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create_report = new System.Windows.Forms.Button();
            this.report_txb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.users_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // period
            // 
            this.period.CustomFormat = "MMMM yyyy";
            this.period.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.period.Location = new System.Drawing.Point(6, 19);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(200, 20);
            this.period.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.period);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период отчета";
            // 
            // create_report
            // 
            this.create_report.Location = new System.Drawing.Point(679, 31);
            this.create_report.Name = "create_report";
            this.create_report.Size = new System.Drawing.Size(99, 23);
            this.create_report.TabIndex = 1;
            this.create_report.Text = "Сформировать";
            this.create_report.UseVisualStyleBackColor = true;
            this.create_report.Click += new System.EventHandler(this.create_report_Click);
            // 
            // report_txb
            // 
            this.report_txb.AcceptsReturn = true;
            this.report_txb.AcceptsTab = true;
            this.report_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_txb.Location = new System.Drawing.Point(12, 81);
            this.report_txb.Multiline = true;
            this.report_txb.Name = "report_txb";
            this.report_txb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.report_txb.Size = new System.Drawing.Size(765, 408);
            this.report_txb.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.users_cmb);
            this.groupBox2.Location = new System.Drawing.Point(229, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнитель";
            // 
            // users_cmb
            // 
            this.users_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.users_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.users_cmb.FormattingEnabled = true;
            this.users_cmb.Location = new System.Drawing.Point(17, 22);
            this.users_cmb.Name = "users_cmb";
            this.users_cmb.Size = new System.Drawing.Size(414, 21);
            this.users_cmb.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 501);
            this.Controls.Add(this.create_report);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.report_txb);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Shown += new System.EventHandler(this.ReportForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker period;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button create_report;
        private System.Windows.Forms.TextBox report_txb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox users_cmb;
    }
}