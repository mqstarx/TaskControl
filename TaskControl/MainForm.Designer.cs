namespace TaskControl
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
            this.task_listView = new System.Windows.Forms.ListView();
            this.status_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refresh_btn = new System.Windows.Forms.Button();
            this.show_completed_cxb = new System.Windows.Forms.CheckBox();
            this.сссс = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.сссс,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.task_listView.FullRowSelect = true;
            this.task_listView.GridLines = true;
            this.task_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.task_listView.Location = new System.Drawing.Point(12, 45);
            this.task_listView.MultiSelect = false;
            this.task_listView.Name = "task_listView";
            this.task_listView.Size = new System.Drawing.Size(1081, 417);
            this.task_listView.TabIndex = 1;
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
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(13, 13);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // show_completed_cxb
            // 
            this.show_completed_cxb.AutoSize = true;
            this.show_completed_cxb.Location = new System.Drawing.Point(105, 17);
            this.show_completed_cxb.Name = "show_completed_cxb";
            this.show_completed_cxb.Size = new System.Drawing.Size(148, 17);
            this.show_completed_cxb.TabIndex = 3;
            this.show_completed_cxb.Text = "Показать завершенные";
            this.show_completed_cxb.UseVisualStyleBackColor = true;
            this.show_completed_cxb.CheckedChanged += new System.EventHandler(this.show_completed_cxb_CheckedChanged);
            // 
            // сссс
            // 
            this.сссс.Text = "Исполнитель";
            this.сссс.Width = 329;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 474);
            this.Controls.Add(this.show_completed_cxb);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.task_listView);
            this.Name = "MainForm";
            this.Text = "Автоматизированный контроль";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView task_listView;
        private System.Windows.Forms.ColumnHeader status_col;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.CheckBox show_completed_cxb;
        private System.Windows.Forms.ColumnHeader сссс;
    }
}

