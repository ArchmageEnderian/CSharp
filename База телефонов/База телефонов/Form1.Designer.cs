namespace База_телефонов
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SevenFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EightFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вОбоихФорматахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.RTBbutton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 368);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SevenFormatToolStripMenuItem,
            this.EightFormatToolStripMenuItem,
            this.вОбоихФорматахToolStripMenuItem});
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // SevenFormatToolStripMenuItem
            // 
            this.SevenFormatToolStripMenuItem.Name = "SevenFormatToolStripMenuItem";
            this.SevenFormatToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.SevenFormatToolStripMenuItem.Text = "В формате +7-***-***-**-**";
            this.SevenFormatToolStripMenuItem.Click += new System.EventHandler(this.SevenFormatToolStripMenuItem_Click);
            // 
            // EightFormatToolStripMenuItem
            // 
            this.EightFormatToolStripMenuItem.Name = "EightFormatToolStripMenuItem";
            this.EightFormatToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.EightFormatToolStripMenuItem.Text = "В формате 8**********";
            this.EightFormatToolStripMenuItem.Click += new System.EventHandler(this.EightFormatToolStripMenuItem_Click);
            // 
            // вОбоихФорматахToolStripMenuItem
            // 
            this.вОбоихФорматахToolStripMenuItem.Name = "вОбоихФорматахToolStripMenuItem";
            this.вОбоихФорматахToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.вОбоихФорматахToolStripMenuItem.Text = "В обоих форматах";
            this.вОбоихФорматахToolStripMenuItem.Click += new System.EventHandler(this.ВОбоихФорматахToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчиститьОкноToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // отчиститьОкноToolStripMenuItem
            // 
            this.отчиститьОкноToolStripMenuItem.Name = "отчиститьОкноToolStripMenuItem";
            this.отчиститьОкноToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.отчиститьОкноToolStripMenuItem.Text = "Отчистить окно";
            this.отчиститьОкноToolStripMenuItem.Click += new System.EventHandler(this.ОтчиститьОкноToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem1_Click);
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(593, 403);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(195, 40);
            this.ButtonChange.TabIndex = 2;
            this.ButtonChange.Text = "Сохранить номера";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(420, 416);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(130, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "В формате 8**********";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // RTBbutton
            // 
            this.RTBbutton.Location = new System.Drawing.Point(12, 403);
            this.RTBbutton.Name = "RTBbutton";
            this.RTBbutton.Size = new System.Drawing.Size(177, 40);
            this.RTBbutton.TabIndex = 4;
            this.RTBbutton.Text = "Создать список номеров!";
            this.RTBbutton.UseVisualStyleBackColor = true;
            this.RTBbutton.Click += new System.EventHandler(this.RTBbutton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(237, 416);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(148, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "В формате +7-***-***-**-**";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.RTBbutton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Переносчик телефонов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ToolStripMenuItem SevenFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EightFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.Button RTBbutton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчиститьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вОбоихФорматахToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

