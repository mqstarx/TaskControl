namespace TaskControlOperator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.task_listView = new System.Windows.Forms.ListView();
            this.status_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новаяЗадачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.show_ended_tasks_cxb = new System.Windows.Forms.CheckBox();
            this.report_btn = new System.Windows.Forms.Button();
            this.only_req_cxb = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // task_listView
            // 
            this.task_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.task_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.status_col,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.task_listView.ContextMenuStrip = this.contextMenuStrip;
            this.task_listView.FullRowSelect = true;
            this.task_listView.GridLines = true;
            this.task_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.task_listView.Location = new System.Drawing.Point(12, 36);
            this.task_listView.MultiSelect = false;
            this.task_listView.Name = "task_listView";
            this.task_listView.Size = new System.Drawing.Size(992, 485);
            this.task_listView.TabIndex = 0;
            this.task_listView.UseCompatibleStateImageBehavior = false;
            this.task_listView.View = System.Windows.Forms.View.Details;
            this.task_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.task_listView_MouseDoubleClick);
            // 
            // status_col
            // 
            this.status_col.Text = "Статус задачи";
            this.status_col.Width = 146;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Текст задачи";
            this.columnHeader1.Width = 207;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Исполнитель";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата начала";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата завершения";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата завершения факт";
            this.columnHeader5.Width = 136;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяЗадачаToolStripMenuItem,
            this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(272, 48);
            // 
            // новаяЗадачаToolStripMenuItem
            // 
            this.новаяЗадачаToolStripMenuItem.Name = "новаяЗадачаToolStripMenuItem";
            this.новаяЗадачаToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.новаяЗадачаToolStripMenuItem.Text = "Новая задача";
            this.новаяЗадачаToolStripMenuItem.Click += new System.EventHandler(this.новаяЗадачаToolStripMenuItem_Click);
            // 
            // новаяЗадачаНаОсновеВыбраннойToolStripMenuItem
            // 
            this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem.Name = "новаяЗадачаНаОсновеВыбраннойToolStripMenuItem";
            this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem.Text = "Новая задача на основе выбранной";
            this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem.Click += new System.EventHandler(this.новаяЗадачаНаОсновеВыбраннойToolStripMenuItem_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(12, 7);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // show_ended_tasks_cxb
            // 
            this.show_ended_tasks_cxb.AutoSize = true;
            this.show_ended_tasks_cxb.Location = new System.Drawing.Point(103, 11);
            this.show_ended_tasks_cxb.Name = "show_ended_tasks_cxb";
            this.show_ended_tasks_cxb.Size = new System.Drawing.Size(146, 17);
            this.show_ended_tasks_cxb.TabIndex = 2;
            this.show_ended_tasks_cxb.Text = "Показать исполненные";
            this.show_ended_tasks_cxb.UseVisualStyleBackColor = true;
            this.show_ended_tasks_cxb.CheckedChanged += new System.EventHandler(this.show_ended_tasks_cxb_CheckedChanged);
            // 
            // report_btn
            // 
            this.report_btn.Location = new System.Drawing.Point(449, 7);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(75, 23);
            this.report_btn.TabIndex = 4;
            this.report_btn.Text = "Отчет";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // only_req_cxb
            // 
            this.only_req_cxb.AutoSize = true;
            this.only_req_cxb.Location = new System.Drawing.Point(280, 11);
            this.only_req_cxb.Name = "only_req_cxb";
            this.only_req_cxb.Size = new System.Drawing.Size(163, 17);
            this.only_req_cxb.TabIndex = 5;
            this.only_req_cxb.Text = "Показать только запросы ";
            this.only_req_cxb.UseVisualStyleBackColor = true;
            this.only_req_cxb.CheckedChanged += new System.EventHandler(this.only_req_cxb_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.only_req_cxb);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.show_ended_tasks_cxb);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.task_listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Автоматизированный контроль исполнения задач (Оператор)";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView task_listView;
        private System.Windows.Forms.ColumnHeader status_col;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.CheckBox show_ended_tasks_cxb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem новаяЗадачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяЗадачаНаОсновеВыбраннойToolStripMenuItem;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.CheckBox only_req_cxb;
    }
}

