
namespace GecmisDefteri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstMesajlar = new System.Windows.Forms.ListBox();
            this.cmsMesajlar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFavori = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSadeceFavoriler = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cmsMesajlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMesajlar
            // 
            this.lstMesajlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMesajlar.FormattingEnabled = true;
            this.lstMesajlar.ItemHeight = 30;
            this.lstMesajlar.Location = new System.Drawing.Point(14, 157);
            this.lstMesajlar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstMesajlar.Name = "lstMesajlar";
            this.lstMesajlar.Size = new System.Drawing.Size(588, 364);
            this.lstMesajlar.TabIndex = 0;
            this.lstMesajlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMesajlar_KeyDown);
            this.lstMesajlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstMesajlar_MouseDown);
            // 
            // cmsMesajlar
            // 
            this.cmsMesajlar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSil,
            this.tsmiFavori});
            this.cmsMesajlar.Name = "cmsMesajlar";
            this.cmsMesajlar.Size = new System.Drawing.Size(182, 48);
            this.cmsMesajlar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMesajlar_ItemClicked);
            // 
            // tsmiSil
            // 
            this.tsmiSil.Name = "tsmiSil";
            this.tsmiSil.Size = new System.Drawing.Size(181, 22);
            this.tsmiSil.Text = "Sil";
            // 
            // tsmiFavori
            // 
            this.tsmiFavori.Name = "tsmiFavori";
            this.tsmiFavori.Size = new System.Drawing.Size(181, 22);
            this.tsmiFavori.Text = "Favorilere Ekle/Çıkar";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMesaj.Location = new System.Drawing.Point(14, 42);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(455, 36);
            this.txtMesaj.TabIndex = 1;
            this.txtMesaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMesaj_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(475, 42);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesajın:";
            // 
            // chkSadeceFavoriler
            // 
            this.chkSadeceFavoriler.AutoSize = true;
            this.chkSadeceFavoriler.Location = new System.Drawing.Point(12, 114);
            this.chkSadeceFavoriler.Name = "chkSadeceFavoriler";
            this.chkSadeceFavoriler.Size = new System.Drawing.Size(215, 34);
            this.chkSadeceFavoriler.TabIndex = 4;
            this.chkSadeceFavoriler.Text = "Sadece Favorilerim";
            this.chkSadeceFavoriler.UseVisualStyleBackColor = true;
            this.chkSadeceFavoriler.CheckedChanged += new System.EventHandler(this.chkSadeceFavoriler_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Location = new System.Drawing.Point(395, 112);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(207, 36);
            this.txtAra.TabIndex = 6;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 536);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkSadeceFavoriler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lstMesajlar);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçmiş Defteri";
            this.cmsMesajlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMesajlar;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsMesajlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiSil;
        private System.Windows.Forms.ToolStripMenuItem tsmiFavori;
        private System.Windows.Forms.CheckBox chkSadeceFavoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
    }
}

