namespace TaskControlOperator
{
    partial class TaskActionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskActionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.task_text_txb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.users_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.status_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.date_begin_task = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.date_end_task = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.date_perenos = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.date_end_fakt = new System.Windows.Forms.DateTimePicker();
            this.confirm_end_task_btn = new System.Windows.Forms.Button();
            this.return_task_btn = new System.Windows.Forms.Button();
            this.msg_list = new System.Windows.Forms.ListBox();
            this.msg_txb = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.edit_task = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.users_sogl_cmb = new System.Windows.Forms.ComboBox();
            this.panelSogl = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.task_text_txb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текст задачи";
            // 
            // task_text_txb
            // 
            this.task_text_txb.Location = new System.Drawing.Point(6, 19);
            this.task_text_txb.Multiline = true;
            this.task_text_txb.Name = "task_text_txb";
            this.task_text_txb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.task_text_txb.Size = new System.Drawing.Size(277, 75);
            this.task_text_txb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.users_cmb);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исполнитель";
            // 
            // users_cmb
            // 
            this.users_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.users_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.users_cmb.FormattingEnabled = true;
            this.users_cmb.Location = new System.Drawing.Point(6, 19);
            this.users_cmb.Name = "users_cmb";
            this.users_cmb.Size = new System.Drawing.Size(458, 21);
            this.users_cmb.TabIndex = 0;
            this.users_cmb.TextChanged += new System.EventHandler(this.users_cmb_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.status_cmb);
            this.groupBox3.Location = new System.Drawing.Point(323, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статус";
            // 
            // status_cmb
            // 
            this.status_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cmb.FormattingEnabled = true;
            this.status_cmb.Location = new System.Drawing.Point(6, 46);
            this.status_cmb.Name = "status_cmb";
            this.status_cmb.Size = new System.Drawing.Size(135, 21);
            this.status_cmb.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.date_begin_task);
            this.groupBox4.Location = new System.Drawing.Point(506, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 56);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дата начала";
            // 
            // date_begin_task
            // 
            this.date_begin_task.Location = new System.Drawing.Point(6, 25);
            this.date_begin_task.Name = "date_begin_task";
            this.date_begin_task.Size = new System.Drawing.Size(200, 20);
            this.date_begin_task.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.date_end_task);
            this.groupBox5.Location = new System.Drawing.Point(506, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 58);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дата завершения(срок)";
            // 
            // date_end_task
            // 
            this.date_end_task.Location = new System.Drawing.Point(6, 29);
            this.date_end_task.Name = "date_end_task";
            this.date_end_task.Size = new System.Drawing.Size(200, 20);
            this.date_end_task.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.date_perenos);
            this.groupBox6.Location = new System.Drawing.Point(270, 243);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 67);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Перенос срока на:";
            // 
            // date_perenos
            // 
            this.date_perenos.Location = new System.Drawing.Point(6, 37);
            this.date_perenos.Name = "date_perenos";
            this.date_perenos.Size = new System.Drawing.Size(200, 20);
            this.date_perenos.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.date_end_fakt);
            this.groupBox7.Location = new System.Drawing.Point(12, 243);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 67);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Дата фактического завершения";
            // 
            // date_end_fakt
            // 
            this.date_end_fakt.Location = new System.Drawing.Point(6, 37);
            this.date_end_fakt.Name = "date_end_fakt";
            this.date_end_fakt.Size = new System.Drawing.Size(200, 20);
            this.date_end_fakt.TabIndex = 1;
            // 
            // confirm_end_task_btn
            // 
            this.confirm_end_task_btn.Location = new System.Drawing.Point(17, 537);
            this.confirm_end_task_btn.Name = "confirm_end_task_btn";
            this.confirm_end_task_btn.Size = new System.Drawing.Size(278, 23);
            this.confirm_end_task_btn.TabIndex = 8;
            this.confirm_end_task_btn.Text = "Подтвердить завершение(перенос) задачи";
            this.confirm_end_task_btn.UseVisualStyleBackColor = true;
            this.confirm_end_task_btn.Click += new System.EventHandler(this.confirm_end_task_btn_Click);
            // 
            // return_task_btn
            // 
            this.return_task_btn.Location = new System.Drawing.Point(309, 537);
            this.return_task_btn.Name = "return_task_btn";
            this.return_task_btn.Size = new System.Drawing.Size(253, 23);
            this.return_task_btn.TabIndex = 11;
            this.return_task_btn.Text = "Отменить запрос на завершение или перенос срока";
            this.return_task_btn.UseVisualStyleBackColor = true;
            this.return_task_btn.Click += new System.EventHandler(this.return_task_btn_Click);
            // 
            // msg_list
            // 
            this.msg_list.FormattingEnabled = true;
            this.msg_list.Location = new System.Drawing.Point(6, 19);
            this.msg_list.Name = "msg_list";
            this.msg_list.ScrollAlwaysVisible = true;
            this.msg_list.Size = new System.Drawing.Size(688, 160);
            this.msg_list.TabIndex = 12;
            // 
            // msg_txb
            // 
            this.msg_txb.Location = new System.Drawing.Point(6, 189);
            this.msg_txb.Name = "msg_txb";
            this.msg_txb.Size = new System.Drawing.Size(688, 20);
            this.msg_txb.TabIndex = 13;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.msg_list);
            this.groupBox8.Controls.Add(this.msg_txb);
            this.groupBox8.Location = new System.Drawing.Point(18, 316);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(701, 215);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Сообщения";
            // 
            // edit_task
            // 
            this.edit_task.Location = new System.Drawing.Point(568, 537);
            this.edit_task.Name = "edit_task";
            this.edit_task.Size = new System.Drawing.Size(144, 23);
            this.edit_task.TabIndex = 15;
            this.edit_task.Text = "Редактировать";
            this.edit_task.UseVisualStyleBackColor = true;
            this.edit_task.Click += new System.EventHandler(this.edit_task_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.users_sogl_cmb);
            this.groupBox9.Location = new System.Drawing.Point(12, 172);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(471, 47);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Согласующий перенос срока";
            // 
            // users_sogl_cmb
            // 
            this.users_sogl_cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.users_sogl_cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.users_sogl_cmb.FormattingEnabled = true;
            this.users_sogl_cmb.Location = new System.Drawing.Point(6, 19);
            this.users_sogl_cmb.Name = "users_sogl_cmb";
            this.users_sogl_cmb.Size = new System.Drawing.Size(458, 21);
            this.users_sogl_cmb.TabIndex = 0;
            // 
            // panelSogl
            // 
            this.panelSogl.BackColor = System.Drawing.Color.Red;
            this.panelSogl.Location = new System.Drawing.Point(489, 191);
            this.panelSogl.Name = "panelSogl";
            this.panelSogl.Size = new System.Drawing.Size(21, 21);
            this.panelSogl.TabIndex = 16;
            // 
            // TaskActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 572);
            this.Controls.Add(this.panelSogl);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.edit_task);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.return_task_btn);
            this.Controls.Add(this.confirm_end_task_btn);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskActionForm";
            this.Text = "Управление задачей";
            this.Shown += new System.EventHandler(this.TaskActionForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox task_text_txb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox users_cmb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.DateTimePicker date_begin_task;
        public System.Windows.Forms.DateTimePicker date_end_task;
        public System.Windows.Forms.DateTimePicker date_perenos;
        public System.Windows.Forms.DateTimePicker date_end_fakt;
        private System.Windows.Forms.ListBox msg_list;
        public System.Windows.Forms.TextBox msg_txb;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox status_cmb;
        public System.Windows.Forms.Button confirm_end_task_btn;
        public System.Windows.Forms.Button return_task_btn;
        public System.Windows.Forms.Button edit_task;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox users_sogl_cmb;
        private System.Windows.Forms.Panel panelSogl;
    }
}