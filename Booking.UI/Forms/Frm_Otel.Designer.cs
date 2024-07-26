namespace Booking.UI.Forms
{
    partial class Frm_Otel
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpOtel = new GroupBox();
            chkActive = new CheckBox();
            label9 = new Label();
            dtpCheckOut = new DateTimePicker();
            btnKaydet = new Button();
            label8 = new Label();
            dtpCheckIn = new DateTimePicker();
            label6 = new Label();
            nmrYildiz = new NumericUpDown();
            label5 = new Label();
            txtMail = new TextBox();
            txtTel = new TextBox();
            txtAdres = new TextBox();
            txtAd = new TextBox();
            lstOtel = new ListBox();
            label7 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            grpOtel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrYildiz).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Otel Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 97);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 1;
            label2.Text = "Adres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 213);
            label3.Name = "label3";
            label3.Size = new Size(108, 37);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 262);
            label4.Name = "label4";
            label4.Size = new Size(82, 37);
            label4.TabIndex = 3;
            label4.Text = "Mail :";
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(chkActive);
            grpOtel.Controls.Add(label9);
            grpOtel.Controls.Add(dtpCheckOut);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(label8);
            grpOtel.Controls.Add(dtpCheckIn);
            grpOtel.Controls.Add(label6);
            grpOtel.Controls.Add(nmrYildiz);
            grpOtel.Controls.Add(label5);
            grpOtel.Controls.Add(txtMail);
            grpOtel.Controls.Add(txtTel);
            grpOtel.Controls.Add(txtAdres);
            grpOtel.Controls.Add(txtAd);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label4);
            grpOtel.Controls.Add(label2);
            grpOtel.Controls.Add(label3);
            grpOtel.Location = new Point(12, 12);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(640, 473);
            grpOtel.TabIndex = 4;
            grpOtel.TabStop = false;
            grpOtel.Text = "Otel Bilgileri";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(375, 417);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(90, 41);
            chkActive.TabIndex = 32;
            chkActive.Text = "Aktif";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(271, 417);
            label9.Name = "label9";
            label9.Size = new Size(111, 37);
            label9.TabIndex = 31;
            label9.Text = "Durum :";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(145, 360);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(472, 43);
            dtpCheckOut.TabIndex = 30;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(471, 407);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(158, 56);
            btnKaydet.TabIndex = 26;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-6, 360);
            label8.Name = "label8";
            label8.Size = new Size(145, 37);
            label8.TabIndex = 29;
            label8.Text = "CheckOut :";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(145, 311);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(472, 43);
            dtpCheckIn.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 311);
            label6.Name = "label6";
            label6.Size = new Size(123, 37);
            label6.TabIndex = 27;
            label6.Text = "CheckIn :";
            // 
            // nmrYildiz
            // 
            nmrYildiz.Location = new Point(145, 415);
            nmrYildiz.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrYildiz.Name = "nmrYildiz";
            nmrYildiz.Size = new Size(120, 43);
            nmrYildiz.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 417);
            label5.Name = "label5";
            label5.Size = new Size(94, 37);
            label5.TabIndex = 8;
            label5.Text = "Yıldız :";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(145, 262);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(472, 43);
            txtMail.TabIndex = 7;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(145, 213);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(472, 43);
            txtTel.TabIndex = 6;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(145, 97);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(472, 110);
            txtAdres.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(145, 48);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(472, 43);
            txtAd.TabIndex = 4;
            // 
            // lstOtel
            // 
            lstOtel.FormattingEnabled = true;
            lstOtel.ItemHeight = 37;
            lstOtel.Location = new Point(658, 49);
            lstOtel.Name = "lstOtel";
            lstOtel.Size = new Size(517, 374);
            lstOtel.TabIndex = 5;
            lstOtel.SelectedIndexChanged += lstOtel_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(658, 9);
            label7.Name = "label7";
            label7.Size = new Size(146, 37);
            label7.TabIndex = 6;
            label7.Text = "Otel Listesi";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(811, 429);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(173, 56);
            btnGuncelle.TabIndex = 26;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(990, 429);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(185, 56);
            btnSil.TabIndex = 27;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Frm_Otel
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1197, 499);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(label7);
            Controls.Add(lstOtel);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Otel";
            Text = "Frm_Otel";
            Load += Frm_Otel_Load;
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrYildiz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox grpOtel;
        private TextBox txtAd;
        private TextBox txtMail;
        private TextBox txtTel;
        private TextBox txtAdres;
        private Label label5;
        private NumericUpDown nmrYildiz;
        private ListBox lstOtel;
        private Label label7;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private DateTimePicker dtpCheckOut;
        private Label label8;
        private DateTimePicker dtpCheckIn;
        private Label label6;
        private CheckBox chkActive;
        private Label label9;
    }
}