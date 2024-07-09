namespace WindowsFormsApp1.View
{
    partial class Form2
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
            this.label_university = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_menu = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OFG = new System.Windows.Forms.OpenFileDialog();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(81, 516);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(773, 16);
            this.label_university.TabIndex = 0;
            this.label_university.Text = "ФГБОУ ВО «Сибирский государственный университет имени М.Ф. Решетнева» Лесосибирск" +
    "ий филиал;";
            this.label_university.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_information.Location = new System.Drawing.Point(388, 12);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(235, 40);
            this.label_information.TabIndex = 1;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            this.label_information.MouseLeave += new System.EventHandler(this.label_information_MouseLeave);
            this.label_information.MouseHover += new System.EventHandler(this.label_information_MouseHover);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.Location = new System.Drawing.Point(780, 12);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(121, 40);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label_information);
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_menu);
            this.panel_main.Location = new System.Drawing.Point(0, 425);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(981, 66);
            this.panel_main.TabIndex = 3;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_menu.Location = new System.Drawing.Point(44, 12);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(245, 40);
            this.label_menu.TabIndex = 4;
            this.label_menu.Text = "Главное меню";
            this.label_menu.Click += new System.EventHandler(this.label_menu_Click);
            this.label_menu.MouseLeave += new System.EventHandler(this.label_menu_MouseLeave);
            this.label_menu.MouseHover += new System.EventHandler(this.label_menu_MouseHover);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 14);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(168, 58);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Запуск";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(199, 14);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(168, 58);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox1.Location = new System.Drawing.Point(12, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(954, 341);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // OFG
            // 
            this.OFG.FileName = "OFG";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(978, 549);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_university);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Расчет итоговых значений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog OFG;
    }
}