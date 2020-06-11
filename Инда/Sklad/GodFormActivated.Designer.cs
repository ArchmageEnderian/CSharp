namespace BD
{
    partial class GodFormActivated
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Take = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Otmena = new System.Windows.Forms.Button();
            this.yesbut = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_vac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fam,
            this.name,
            this.lastName,
            this.doljnost,
            this.oklad,
            this.info});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID Соискателя";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fam
            // 
            this.fam.HeaderText = "Фамилия";
            this.fam.Name = "fam";
            this.fam.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Отчество";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // doljnost
            // 
            this.doljnost.HeaderText = "Должность";
            this.doljnost.Name = "doljnost";
            this.doljnost.ReadOnly = true;
            // 
            // oklad
            // 
            this.oklad.HeaderText = "Желаемая зарплата";
            this.oklad.Name = "oklad";
            this.oklad.ReadOnly = true;
            // 
            // info
            // 
            this.info.HeaderText = "Резюме";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 599);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(99, 44);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(346, 599);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 44);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить вакансию";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(657, 599);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(99, 44);
            this.Take.TabIndex = 3;
            this.Take.Text = "Взять на собеседование?";
            this.Take.UseVisualStyleBackColor = true;
            this.Take.Click += new System.EventHandler(this.Take_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(580, 623);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Otmena
            // 
            this.Otmena.Location = new System.Drawing.Point(472, 599);
            this.Otmena.Name = "Otmena";
            this.Otmena.Size = new System.Drawing.Size(99, 44);
            this.Otmena.TabIndex = 6;
            this.Otmena.Text = "Отмена";
            this.Otmena.UseVisualStyleBackColor = true;
            this.Otmena.Click += new System.EventHandler(this.Otmena_Click);
            // 
            // yesbut
            // 
            this.yesbut.Location = new System.Drawing.Point(657, 599);
            this.yesbut.Name = "yesbut";
            this.yesbut.Size = new System.Drawing.Size(99, 44);
            this.yesbut.TabIndex = 7;
            this.yesbut.Text = "Взять на собеседование!";
            this.yesbut.UseVisualStyleBackColor = true;
            this.yesbut.Click += new System.EventHandler(this.yesbut_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(577, 603);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Выберите ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vac,
            this.dolj,
            this.okl,
            this.opisanie});
            this.dataGridView2.Location = new System.Drawing.Point(12, 363);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(744, 230);
            this.dataGridView2.TabIndex = 9;
            // 
            // id_vac
            // 
            this.id_vac.HeaderText = "ID Вакансии";
            this.id_vac.Name = "id_vac";
            this.id_vac.ReadOnly = true;
            // 
            // dolj
            // 
            this.dolj.HeaderText = "Должность";
            this.dolj.Name = "dolj";
            this.dolj.ReadOnly = true;
            // 
            // okl
            // 
            this.okl.HeaderText = "Оклад";
            this.okl.Name = "okl";
            this.okl.ReadOnly = true;
            // 
            // opisanie
            // 
            this.opisanie.HeaderText = "Описание работы";
            this.opisanie.Name = "opisanie";
            this.opisanie.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Откликнувшиеся на вакансии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Спискок ваших вакансий";
            // 
            // GodFormActivated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Otmena);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Take);
            this.Controls.Add(this.yesbut);
            this.Name = "GodFormActivated";
            this.Text = "GodFormActivated";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Take;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Otmena;
        private System.Windows.Forms.Button yesbut;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doljnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn oklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolj;
        private System.Windows.Forms.DataGridViewTextBoxColumn okl;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}