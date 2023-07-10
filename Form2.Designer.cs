namespace biletprojesi
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
            this.güncelle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtyemekadı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurumu = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbiletalan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(261, 170);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(473, 40);
            this.güncelle.TabIndex = 97;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click_1);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(261, 66);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(473, 42);
            this.listele.TabIndex = 96;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click_1);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(261, 121);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(473, 36);
            this.sil.TabIndex = 95;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click_1);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(261, 15);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(473, 38);
            this.ekle.TabIndex = 94;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(3, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 195);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // txtyemekadı
            // 
            this.txtyemekadı.AutoSize = true;
            this.txtyemekadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyemekadı.Location = new System.Drawing.Point(36, 64);
            this.txtyemekadı.Name = "txtyemekadı";
            this.txtyemekadı.Size = new System.Drawing.Size(101, 20);
            this.txtyemekadı.TabIndex = 91;
            this.txtyemekadı.Text = "Bilet Durumu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Bilet Numarası";
            // 
            // txtDurumu
            // 
            this.txtDurumu.Location = new System.Drawing.Point(143, 66);
            this.txtDurumu.Name = "txtDurumu";
            this.txtDurumu.Size = new System.Drawing.Size(75, 20);
            this.txtDurumu.TabIndex = 88;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(143, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(75, 20);
            this.txtid.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Bilet Alan";
            // 
            // txtbiletalan
            // 
            this.txtbiletalan.Location = new System.Drawing.Point(143, 105);
            this.txtbiletalan.Name = "txtbiletalan";
            this.txtbiletalan.Size = new System.Drawing.Size(75, 20);
            this.txtbiletalan.TabIndex = 98;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbiletalan);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtyemekadı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDurumu);
            this.Controls.Add(this.txtid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtyemekadı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDurumu;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbiletalan;
    }
}