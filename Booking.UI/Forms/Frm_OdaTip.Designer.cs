namespace Booking.UI.Forms
{
    partial class Frm_OdaTip
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
            btnSil = new Button();
            btnGuncelle = new Button();
            label7 = new Label();
            lstOdaTip = new ListBox();
            btnKaydet = new Button();
            txtAciklama = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            grpOtel = new GroupBox();
            nmrKapasite = new NumericUpDown();
            label4 = new Label();
            nmrUcret = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            grpOtel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrKapasite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrUcret).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Location = new Point(995, 433);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(185, 56);
            btnSil.TabIndex = 32;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(816, 433);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(173, 56);
            btnGuncelle.TabIndex = 31;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(663, 13);
            label7.Name = "label7";
            label7.Size = new Size(190, 37);
            label7.TabIndex = 30;
            label7.Text = "Oda Tip Listesi";
            // 
            // lstOdaTip
            // 
            lstOdaTip.FormattingEnabled = true;
            lstOdaTip.ItemHeight = 37;
            lstOdaTip.Location = new Point(663, 53);
            lstOdaTip.Name = "lstOdaTip";
            lstOdaTip.Size = new Size(517, 337);
            lstOdaTip.TabIndex = 29;
            lstOdaTip.SelectedIndexChanged += lstOdaTip_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(476, 275);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(158, 56);
            btnKaydet.TabIndex = 26;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(162, 100);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(472, 110);
            txtAciklama.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(162, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(472, 43);
            txtAd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 97);
            label2.Name = "label2";
            label2.Size = new Size(148, 37);
            label2.TabIndex = 1;
            label2.Text = "Açıklaması:";
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(nmrKapasite);
            grpOtel.Controls.Add(label4);
            grpOtel.Controls.Add(nmrUcret);
            grpOtel.Controls.Add(label3);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(txtAciklama);
            grpOtel.Controls.Add(txtAd);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label2);
            grpOtel.Location = new Point(17, 16);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(640, 473);
            grpOtel.TabIndex = 28;
            grpOtel.TabStop = false;
            grpOtel.Text = "Oda Tip Bilgileri";
            // 
            // nmrKapasite
            // 
            nmrKapasite.Location = new Point(162, 213);
            nmrKapasite.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nmrKapasite.Name = "nmrKapasite";
            nmrKapasite.Size = new Size(120, 43);
            nmrKapasite.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 215);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 33;
            label4.Text = "Kapasite:";
            // 
            // nmrUcret
            // 
            nmrUcret.Location = new Point(514, 216);
            nmrUcret.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrUcret.Name = "nmrUcret";
            nmrUcret.Size = new Size(120, 43);
            nmrUcret.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 219);
            label3.Name = "label3";
            label3.Size = new Size(179, 37);
            label3.TabIndex = 31;
            label3.Text = "Gecelik Ücret:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Oda Adı:";
            // 
            // Frm_OdaTip
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1197, 503);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(label7);
            Controls.Add(lstOdaTip);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_OdaTip";
            Text = "Frm_OdaTip";
            Load += Frm_OdaTip_Load;
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrKapasite).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrUcret).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnGuncelle;
        private Label label7;
        private ListBox lstOdaTip;
        private Button btnKaydet;
        private TextBox txtAciklama;
        private TextBox txtAd;
        private Label label2;
        private GroupBox grpOtel;
        private NumericUpDown nmrKapasite;
        private Label label4;
        private NumericUpDown nmrUcret;
        private Label label3;
        private Label label1;
    }
}