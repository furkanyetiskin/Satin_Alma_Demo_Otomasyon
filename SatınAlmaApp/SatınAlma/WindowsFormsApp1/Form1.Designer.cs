namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlınanÜrünDurumlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSatınAlımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlmaDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOturumAcan = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellerToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.satınAlınanÜrünDurumlarıToolStripMenuItem,
            this.tedarikçilerToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.satınAlımToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmanlarToolStripMenuItem});
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // departmanlarToolStripMenuItem
            // 
            this.departmanlarToolStripMenuItem.Name = "departmanlarToolStripMenuItem";
            this.departmanlarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.departmanlarToolStripMenuItem.Text = "Departmanlar";
            this.departmanlarToolStripMenuItem.Click += new System.EventHandler(this.departmanlarToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // satınAlınanÜrünDurumlarıToolStripMenuItem
            // 
            this.satınAlınanÜrünDurumlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünSatınAlımıToolStripMenuItem,
            this.satınAlmaDetayToolStripMenuItem,
            this.siparişDetaylarıToolStripMenuItem});
            this.satınAlınanÜrünDurumlarıToolStripMenuItem.Name = "satınAlınanÜrünDurumlarıToolStripMenuItem";
            this.satınAlınanÜrünDurumlarıToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.satınAlınanÜrünDurumlarıToolStripMenuItem.Text = "Satın Alınan Ürün Durumları";
            // 
            // ürünSatınAlımıToolStripMenuItem
            // 
            this.ürünSatınAlımıToolStripMenuItem.Name = "ürünSatınAlımıToolStripMenuItem";
            this.ürünSatınAlımıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünSatınAlımıToolStripMenuItem.Text = "Ürün Satın Alımı";
            this.ürünSatınAlımıToolStripMenuItem.Click += new System.EventHandler(this.ürünSatınAlımıToolStripMenuItem_Click);
            // 
            // satınAlmaDetayToolStripMenuItem
            // 
            this.satınAlmaDetayToolStripMenuItem.Name = "satınAlmaDetayToolStripMenuItem";
            this.satınAlmaDetayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satınAlmaDetayToolStripMenuItem.Text = "Satın Alma Detay";
            this.satınAlmaDetayToolStripMenuItem.Click += new System.EventHandler(this.satınAlmaDetayToolStripMenuItem_Click);
            // 
            // siparişDetaylarıToolStripMenuItem
            // 
            this.siparişDetaylarıToolStripMenuItem.Name = "siparişDetaylarıToolStripMenuItem";
            this.siparişDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişDetaylarıToolStripMenuItem.Text = "Sipariş Durumları";
            this.siparişDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.siparişDetaylarıToolStripMenuItem_Click);
            // 
            // tedarikçilerToolStripMenuItem
            // 
            this.tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            this.tedarikçilerToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            this.tedarikçilerToolStripMenuItem.Click += new System.EventHandler(this.tedarikçilerToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // satınAlımToolStripMenuItem
            // 
            this.satınAlımToolStripMenuItem.Name = "satınAlımToolStripMenuItem";
            this.satınAlımToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.satınAlımToolStripMenuItem.Text = "Satın Alım";
            this.satınAlımToolStripMenuItem.Click += new System.EventHandler(this.satınAlımToolStripMenuItem_Click);
            // 
            // lblOturumAcan
            // 
            this.lblOturumAcan.AutoSize = true;
            this.lblOturumAcan.Location = new System.Drawing.Point(623, 9);
            this.lblOturumAcan.Name = "lblOturumAcan";
            this.lblOturumAcan.Size = new System.Drawing.Size(0, 13);
            this.lblOturumAcan.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOturumAcan);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satınAlınanÜrünDurumlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSatınAlımıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satınAlmaDetayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDetaylarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanlarToolStripMenuItem;
        private System.Windows.Forms.Label lblOturumAcan;
        private System.Windows.Forms.ToolStripMenuItem satınAlımToolStripMenuItem;
    }
}

