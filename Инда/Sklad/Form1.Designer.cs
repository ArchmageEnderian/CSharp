namespace Sklad
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
            this.label3 = new System.Windows.Forms.Label();
            this.God = new System.Windows.Forms.Button();
            this.Rab = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здравствуйте! Добро пожаловать на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"Биржа труда\"!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пожалуйста, выберите верное утверждение";
            // 
            // God
            // 
            this.God.Location = new System.Drawing.Point(12, 62);
            this.God.Name = "God";
            this.God.Size = new System.Drawing.Size(103, 53);
            this.God.TabIndex = 3;
            this.God.Text = "Я работодатель";
            this.God.UseVisualStyleBackColor = true;
            this.God.Click += new System.EventHandler(this.God_Click);
            // 
            // Rab
            // 
            this.Rab.Location = new System.Drawing.Point(121, 62);
            this.Rab.Name = "Rab";
            this.Rab.Size = new System.Drawing.Size(109, 53);
            this.Rab.TabIndex = 4;
            this.Rab.Text = "Я \"еще\" не рабочий";
            this.Rab.UseVisualStyleBackColor = true;
            this.Rab.Click += new System.EventHandler(this.Rab_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(38, 9);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(154, 13);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Сервер не доступен! ЭТО ГГ!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 127);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Rab);
            this.Controls.Add(this.God);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Биржа мемов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button God;
        private System.Windows.Forms.Button Rab;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

