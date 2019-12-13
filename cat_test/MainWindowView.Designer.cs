namespace View
{
    partial class MainWindowView
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
            this.Btn_Admin = new System.Windows.Forms.Button();
            this.Btn_User = new System.Windows.Forms.Button();
            this.Btn_Simulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Admin
            // 
            this.Btn_Admin.Location = new System.Drawing.Point(12, 79);
            this.Btn_Admin.Name = "btn_Admin";
            this.Btn_Admin.Size = new System.Drawing.Size(212, 75);
            this.Btn_Admin.TabIndex = 0;
            this.Btn_Admin.Text = "Администратор ";
            this.Btn_Admin.UseVisualStyleBackColor = true;
            this.Btn_Admin.Click += new System.EventHandler(this.Btn_Admin_Click);
            // 
            // Btn_User
            // 
            this.Btn_User.Location = new System.Drawing.Point(292, 79);
            this.Btn_User.Name = "btn_User";
            this.Btn_User.Size = new System.Drawing.Size(212, 75);
            this.Btn_User.TabIndex = 1;
            this.Btn_User.Text = "Пользователь";
            this.Btn_User.UseVisualStyleBackColor = true;
            this.Btn_User.Click += new System.EventHandler(this.Btn_User_Click);
            // 
            // Btn_Simulation
            // 
            this.Btn_Simulation.Location = new System.Drawing.Point(560, 79);
            this.Btn_Simulation.Name = "Btn_Simulation";
            this.Btn_Simulation.Size = new System.Drawing.Size(212, 75);
            this.Btn_Simulation.TabIndex = 2;
            this.Btn_Simulation.Text = "Старт симуляции";
            this.Btn_Simulation.UseVisualStyleBackColor = true;
            this.Btn_Simulation.Click += new System.EventHandler(this.Btn_Simulation_Click);
            // 
            // Главное_окно
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.Btn_Simulation);
            this.Controls.Add(this.Btn_User);
            this.Controls.Add(this.Btn_Admin);
            this.Name = "Главное_окно";
            this.Text = "Приветсвуем";
            this.Load += new System.EventHandler(this.MainWindowView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Admin;
        private System.Windows.Forms.Button Btn_User;
        private System.Windows.Forms.Button Btn_Simulation;
    }
}