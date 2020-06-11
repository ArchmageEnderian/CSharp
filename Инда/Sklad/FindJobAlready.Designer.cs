namespace Sklad
{
    partial class FindJobAlready
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
            this.raeTdnApiR = new System.Windows.Forms.Button();
            this.id_vakansii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doljnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trebovaniya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opisanie_raboti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vakansii,
            this.Doljnost,
            this.Oklad,
            this.Trebovaniya,
            this.Company,
            this.Region,
            this.Opisanie_raboti});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // raeTdnApiR
            // 
            this.raeTdnApiR.Location = new System.Drawing.Point(904, 493);
            this.raeTdnApiR.Name = "raeTdnApiR";
            this.raeTdnApiR.Size = new System.Drawing.Size(26, 24);
            this.raeTdnApiR.TabIndex = 1;
            this.raeTdnApiR.Text = "?";
            this.raeTdnApiR.UseVisualStyleBackColor = true;
            this.raeTdnApiR.Click += new System.EventHandler(this.raeTdnApiR_Click);
            // 
            // id_vakansii
            // 
            this.id_vakansii.HeaderText = "ID вакансии";
            this.id_vakansii.Name = "id_vakansii";
            this.id_vakansii.ReadOnly = true;
            // 
            // Doljnost
            // 
            this.Doljnost.HeaderText = "Должность";
            this.Doljnost.Name = "Doljnost";
            this.Doljnost.ReadOnly = true;
            // 
            // Oklad
            // 
            this.Oklad.HeaderText = "Оклад";
            this.Oklad.Name = "Oklad";
            this.Oklad.ReadOnly = true;
            // 
            // Trebovaniya
            // 
            this.Trebovaniya.HeaderText = "Требования";
            this.Trebovaniya.Name = "Trebovaniya";
            this.Trebovaniya.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.HeaderText = "Компания";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.HeaderText = "Регион";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // Opisanie_raboti
            // 
            this.Opisanie_raboti.HeaderText = "Описание";
            this.Opisanie_raboti.Name = "Opisanie_raboti";
            this.Opisanie_raboti.ReadOnly = true;
            // 
            // FindJobAlready
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.raeTdnApiR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindJobAlready";
            this.Text = "FindJobAlready";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button raeTdnApiR;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vakansii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doljnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oklad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trebovaniya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opisanie_raboti;
    }
}