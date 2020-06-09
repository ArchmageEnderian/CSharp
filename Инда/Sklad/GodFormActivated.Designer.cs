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
            this.fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Take = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fam,
            this.name,
            this.lastName,
            this.doljnost,
            this.oklad,
            this.info});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 350);
            this.dataGridView1.TabIndex = 0;
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
            this.Refresh.Location = new System.Drawing.Point(12, 368);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(99, 44);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(275, 368);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 44);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить вакансию";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Take
            // 
            this.Take.Location = new System.Drawing.Point(559, 368);
            this.Take.Name = "Take";
            this.Take.Size = new System.Drawing.Size(99, 44);
            this.Take.TabIndex = 3;
            this.Take.Text = "Взять на работу!";
            this.Take.UseVisualStyleBackColor = true;
            this.Take.Click += new System.EventHandler(this.Take_Click);
            // 
            // GodFormActivated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 424);
            this.Controls.Add(this.Take);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GodFormActivated";
            this.Text = "GodFormActivated";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doljnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn oklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Take;
    }
}