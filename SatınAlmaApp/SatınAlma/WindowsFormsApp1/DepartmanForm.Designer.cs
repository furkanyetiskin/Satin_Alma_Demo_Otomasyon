namespace WindowsFormsApp1
{
    partial class DepartmanForm
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
            this.components = new System.ComponentModel.Container();
            this.dgwDepartmanlar = new System.Windows.Forms.DataGridView();
            this.contextMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.txtDepartmanAdi = new System.Windows.Forms.TextBox();
            this.txtDepartmanEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartmanlar)).BeginInit();
            this.contextMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDepartmanlar
            // 
            this.dgwDepartmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartmanlar.ContextMenuStrip = this.contextMStrip;
            this.dgwDepartmanlar.Location = new System.Drawing.Point(12, 81);
            this.dgwDepartmanlar.Name = "dgwDepartmanlar";
            this.dgwDepartmanlar.Size = new System.Drawing.Size(263, 279);
            this.dgwDepartmanlar.TabIndex = 3;
            this.dgwDepartmanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepartmanlar_CellClick);
            // 
            // contextMStrip
            // 
            this.contextMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMStrip.Name = "contextMStrip";
            this.contextMStrip.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(12, 19);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(77, 13);
            this.lblDepartmanAdi.TabIndex = 4;
            this.lblDepartmanAdi.Text = "Departman Adı";
            // 
            // txtDepartmanAdi
            // 
            this.txtDepartmanAdi.Location = new System.Drawing.Point(12, 36);
            this.txtDepartmanAdi.Name = "txtDepartmanAdi";
            this.txtDepartmanAdi.Size = new System.Drawing.Size(100, 20);
            this.txtDepartmanAdi.TabIndex = 0;
            // 
            // txtDepartmanEkle
            // 
            this.txtDepartmanEkle.Location = new System.Drawing.Point(119, 32);
            this.txtDepartmanEkle.Name = "txtDepartmanEkle";
            this.txtDepartmanEkle.Size = new System.Drawing.Size(75, 23);
            this.txtDepartmanEkle.TabIndex = 1;
            this.txtDepartmanEkle.Text = "Ekle";
            this.txtDepartmanEkle.UseVisualStyleBackColor = true;
            this.txtDepartmanEkle.Click += new System.EventHandler(this.txtDepartmanEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(200, 32);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // DepartmanForm
            // 
            this.AcceptButton = this.txtDepartmanEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 374);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtDepartmanEkle);
            this.Controls.Add(this.txtDepartmanAdi);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Controls.Add(this.dgwDepartmanlar);
            this.Name = "DepartmanForm";
            this.Text = "Departmanlar";
            this.Load += new System.EventHandler(this.Departmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartmanlar)).EndInit();
            this.contextMStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDepartmanlar;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.TextBox txtDepartmanAdi;
        private System.Windows.Forms.Button txtDepartmanEkle;
        private System.Windows.Forms.ContextMenuStrip contextMStrip;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
    }
}