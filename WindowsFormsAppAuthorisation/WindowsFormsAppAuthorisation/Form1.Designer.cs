namespace WindowsFormsAppAuthorisation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginregbox = new System.Windows.Forms.TextBox();
            this.loginenbox = new System.Windows.Forms.TextBox();
            this.passregbox = new System.Windows.Forms.TextBox();
            this.passenbox = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация:";
            // 
            // loginregbox
            // 
            this.loginregbox.Location = new System.Drawing.Point(232, 65);
            this.loginregbox.Name = "loginregbox";
            this.loginregbox.Size = new System.Drawing.Size(132, 20);
            this.loginregbox.TabIndex = 2;
            // 
            // loginenbox
            // 
            this.loginenbox.Location = new System.Drawing.Point(12, 65);
            this.loginenbox.Name = "loginenbox";
            this.loginenbox.Size = new System.Drawing.Size(128, 20);
            this.loginenbox.TabIndex = 3;
            // 
            // passregbox
            // 
            this.passregbox.Location = new System.Drawing.Point(232, 114);
            this.passregbox.Name = "passregbox";
            this.passregbox.Size = new System.Drawing.Size(132, 20);
            this.passregbox.TabIndex = 4;
            // 
            // passenbox
            // 
            this.passenbox.Location = new System.Drawing.Point(12, 114);
            this.passenbox.Name = "passenbox";
            this.passenbox.Size = new System.Drawing.Size(128, 20);
            this.passenbox.TabIndex = 5;
            // 
            // enterbutton
            // 
            this.enterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbutton.Location = new System.Drawing.Point(12, 140);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(128, 23);
            this.enterbutton.TabIndex = 6;
            this.enterbutton.Text = "Войти";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerbutton.Location = new System.Drawing.Point(232, 140);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(132, 23);
            this.registerbutton.TabIndex = 7;
            this.registerbutton.Text = "Зарегистрироваться";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 188);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.passenbox);
            this.Controls.Add(this.passregbox);
            this.Controls.Add(this.loginenbox);
            this.Controls.Add(this.loginregbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Поле входа в систему";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginregbox;
        private System.Windows.Forms.TextBox loginenbox;
        private System.Windows.Forms.TextBox passregbox;
        private System.Windows.Forms.TextBox passenbox;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

