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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindJobAlready));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raeTdnApiR = new System.Windows.Forms.Button();
            this.id_vakansii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doljnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oklad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trebovaniya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opisanie_raboti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Rezume = new System.Windows.Forms.Button();
            this.Sender = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Otmena = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Poslat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
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
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(904, 523);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(27, 15);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // Rezume
            // 
            this.Rezume.Location = new System.Drawing.Point(12, 379);
            this.Rezume.Name = "Rezume";
            this.Rezume.Size = new System.Drawing.Size(100, 37);
            this.Rezume.TabIndex = 3;
            this.Rezume.Text = "Создать резюме";
            this.Rezume.UseVisualStyleBackColor = true;
            this.Rezume.Click += new System.EventHandler(this.Rezume_Click);
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(653, 379);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(103, 37);
            this.Sender.TabIndex = 4;
            this.Sender.Text = "Предложить свое резюме!";
            this.Sender.UseVisualStyleBackColor = true;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(567, 396);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(80, 20);
            this.textBox.TabIndex = 5;
            // 
            // Otmena
            // 
            this.Otmena.Location = new System.Drawing.Point(458, 379);
            this.Otmena.Name = "Otmena";
            this.Otmena.Size = new System.Drawing.Size(103, 37);
            this.Otmena.TabIndex = 6;
            this.Otmena.Text = "Отмена";
            this.Otmena.UseVisualStyleBackColor = true;
            this.Otmena.Click += new System.EventHandler(this.Otmena_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(586, 379);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Номер:";
            // 
            // Poslat
            // 
            this.Poslat.Location = new System.Drawing.Point(653, 379);
            this.Poslat.Name = "Poslat";
            this.Poslat.Size = new System.Drawing.Size(103, 37);
            this.Poslat.TabIndex = 8;
            this.Poslat.Text = "Послать Резюме!";
            this.Poslat.UseVisualStyleBackColor = true;
            this.Poslat.Click += new System.EventHandler(this.Poslat_Click);
            // 
            // FindJobAlready
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 428);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Otmena);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Rezume);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.raeTdnApiR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.Poslat);
            this.Name = "FindJobAlready";
            this.Text = "FindJobAlready";
            this.Load += new System.EventHandler(this.FindJobAlready_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Rezume;
        private System.Windows.Forms.Button Sender;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Otmena;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Poslat;
    }
}