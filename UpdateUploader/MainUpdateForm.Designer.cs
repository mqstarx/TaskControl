namespace UpdateUploader
{
    partial class MainUpdateForm
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
            this.obzor_btn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // obzor_btn
            // 
            this.obzor_btn.Location = new System.Drawing.Point(12, 189);
            this.obzor_btn.Name = "obzor_btn";
            this.obzor_btn.Size = new System.Drawing.Size(120, 23);
            this.obzor_btn.TabIndex = 0;
            this.obzor_btn.Text = "Добавить файл";
            this.obzor_btn.UseVisualStyleBackColor = true;
            this.obzor_btn.Click += new System.EventHandler(this.obzor_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 147);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файлы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер версии";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(145, 189);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Добавить в базу";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(272, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Версия оператора";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 226);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.obzor_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainUpdateForm";
            this.Text = "Добавление новой версии в базу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button obzor_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

