﻿namespace cat_test
{
    partial class AdminView
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
            this.Btn_AddDel = new System.Windows.Forms.Button();
            this.Btn_Log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Monitoring = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_AddDel
            // 
            this.Btn_AddDel.Location = new System.Drawing.Point(57, 12);
            this.Btn_AddDel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_AddDel.Name = "button1";
            this.Btn_AddDel.Size = new System.Drawing.Size(143, 42);
            this.Btn_AddDel.TabIndex = 0;
            this.Btn_AddDel.Text = "Добавить/удалить пользователя";
            this.Btn_AddDel.UseVisualStyleBackColor = true;
            this.Btn_AddDel.Click += new System.EventHandler(this.Btn_AddDel_Click);
            // 
            // Btn_Log
            // 
            this.Btn_Log.Location = new System.Drawing.Point(57, 60);
            this.Btn_Log.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_Log.Name = "Btn_Log";
            this.Btn_Log.Size = new System.Drawing.Size(143, 42);
            this.Btn_Log.TabIndex = 1;
            this.Btn_Log.Text = "Сохранить лог";
            this.Btn_Log.UseVisualStyleBackColor = true;
            // 
            // Btn_Monitoring
            // 
            this.Btn_Monitoring.Location = new System.Drawing.Point(396, 38);
            this.Btn_Monitoring.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_Monitoring.Name = "Btn_Monitoring";
            this.Btn_Monitoring.Size = new System.Drawing.Size(143, 42);
            this.Btn_Monitoring.TabIndex = 2;
            this.Btn_Monitoring.Text = "Мониторинг пользователя";
            this.Btn_Monitoring.UseVisualStyleBackColor = true;
            this.Btn_Monitoring.Click += new System.EventHandler(this.Btn_Monitoring_Click); 
            //
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(9, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количесвто пользователей: 3 Количество кормушек: 2 Всего корма: 300 г";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(12, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(261, 338);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Кормушка Вурц Артём пуста\r\nКормушка Вурц Артём наполнилась вручную\r\nКормушка Вася" +
    " Артём наполнилась автоматически\r\n\r\n";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AcceptsTab = true;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(328, 136);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(261, 338);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Артём \r\nПользователь 1\r\nПользователь 2";
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Лог";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(400, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Список пользователй ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Админ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(620, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Monitoring);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_AddDel);
            this.Controls.Add(this.Btn_Log);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Админ";
            this.Text = "Админ";
            this.Load += new System.EventHandler(this.Админ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddDel;
        private System.Windows.Forms.Button Btn_Log;
        private System.Windows.Forms.Button Btn_Monitoring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

