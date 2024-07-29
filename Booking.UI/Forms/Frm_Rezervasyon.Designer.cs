namespace Booking.UI.Forms
{
    partial class Frm_Rezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rezervasyon));
            btnSil = new Button();
            btnGuncelle = new Button();
            label7 = new Label();
            btnKaydet = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            grpOtel = new GroupBox();
            nmrSayi = new NumericUpDown();
            label2 = new Label();
            label9 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            cmbRoomType = new ComboBox();
            cmbOtel = new ComboBox();
            dgwRez = new DataGridView();
            groupBox1 = new GroupBox();
            btnGuestDelete = new Button();
            btnGuestUpdate = new Button();
            dtpDateOfBirth = new DateTimePicker();
            txtTCKN = new TextBox();
            label8 = new Label();
            txtAdres = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtMail = new TextBox();
            txtTel = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label5 = new Label();
            lstMisafir = new ListBox();
            pictureBox1 = new PictureBox();
            grpOtel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSayi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwRez).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Location = new Point(459, 402);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(145, 48);
            btnSil.TabIndex = 32;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(308, 348);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(145, 48);
            btnGuncelle.TabIndex = 31;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 497);
            label7.Name = "label7";
            label7.Size = new Size(242, 37);
            label7.TabIndex = 30;
            label7.Text = "Rezervasyon Listesi";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(459, 348);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(145, 48);
            btnKaydet.TabIndex = 26;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Otel Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(132, 37);
            label4.TabIndex = 3;
            label4.Text = "CheclOut:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 146);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 2;
            label3.Text = "CheckIn:";
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(nmrSayi);
            grpOtel.Controls.Add(btnSil);
            grpOtel.Controls.Add(label2);
            grpOtel.Controls.Add(btnGuncelle);
            grpOtel.Controls.Add(label9);
            grpOtel.Controls.Add(lblTotal);
            grpOtel.Controls.Add(label6);
            grpOtel.Controls.Add(dtpCheckIn);
            grpOtel.Controls.Add(dtpCheckOut);
            grpOtel.Controls.Add(cmbRoomType);
            grpOtel.Controls.Add(cmbOtel);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label4);
            grpOtel.Controls.Add(label3);
            grpOtel.Location = new Point(12, 12);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(656, 484);
            grpOtel.TabIndex = 28;
            grpOtel.TabStop = false;
            grpOtel.Text = "Rezervasyon Bilgileri";
            // 
            // nmrSayi
            // 
            nmrSayi.Location = new Point(150, 246);
            nmrSayi.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrSayi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrSayi.Name = "nmrSayi";
            nmrSayi.Size = new Size(120, 43);
            nmrSayi.TabIndex = 38;
            nmrSayi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 248);
            label2.Name = "label2";
            label2.Size = new Size(144, 37);
            label2.TabIndex = 37;
            label2.Text = "Kişi Sayısı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 97);
            label9.Name = "label9";
            label9.Size = new Size(117, 37);
            label9.TabIndex = 35;
            label9.Text = "Oda Tip:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(192, 0, 0);
            lblTotal.Location = new Point(132, 345);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 37);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "0 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 345);
            label6.Name = "label6";
            label6.Size = new Size(84, 37);
            label6.TabIndex = 33;
            label6.Text = "Tutar:";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(150, 148);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(472, 43);
            dtpCheckIn.TabIndex = 32;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(150, 197);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(472, 43);
            dtpCheckOut.TabIndex = 31;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(150, 97);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(472, 45);
            cmbRoomType.TabIndex = 30;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // cmbOtel
            // 
            cmbOtel.FormattingEnabled = true;
            cmbOtel.Location = new Point(150, 46);
            cmbOtel.Name = "cmbOtel";
            cmbOtel.Size = new Size(472, 45);
            cmbOtel.TabIndex = 27;
            cmbOtel.SelectedIndexChanged += cmbOtel_SelectedIndexChanged;
            // 
            // dgwRez
            // 
            dgwRez.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRez.Location = new Point(349, 530);
            dgwRez.Name = "dgwRez";
            dgwRez.Size = new Size(1160, 273);
            dgwRez.TabIndex = 33;
            dgwRez.SelectionChanged += dgwRez_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnGuestDelete);
            groupBox1.Controls.Add(btnGuestUpdate);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(txtTCKN);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Location = new Point(1111, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 484);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Misafir Bilgileri";
            // 
            // btnGuestDelete
            // 
            btnGuestDelete.Location = new Point(515, 425);
            btnGuestDelete.Name = "btnGuestDelete";
            btnGuestDelete.Size = new Size(145, 48);
            btnGuestDelete.TabIndex = 35;
            btnGuestDelete.Text = "Sil";
            btnGuestDelete.UseVisualStyleBackColor = true;
            btnGuestDelete.Click += btnGuestDelete_Click;
            // 
            // btnGuestUpdate
            // 
            btnGuestUpdate.Location = new Point(364, 425);
            btnGuestUpdate.Name = "btnGuestUpdate";
            btnGuestUpdate.Size = new Size(145, 48);
            btnGuestUpdate.TabIndex = 34;
            btnGuestUpdate.Text = "Güncelle";
            btnGuestUpdate.UseVisualStyleBackColor = true;
            btnGuestUpdate.Click += btnGuestUpdate_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(188, 198);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(472, 43);
            dtpDateOfBirth.TabIndex = 33;
            // 
            // txtTCKN
            // 
            txtTCKN.Location = new Point(188, 149);
            txtTCKN.Name = "txtTCKN";
            txtTCKN.Size = new Size(472, 43);
            txtTCKN.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 146);
            label8.Name = "label8";
            label8.Size = new Size(133, 37);
            label8.TabIndex = 31;
            label8.Text = "TC Kimlik:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(188, 247);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(472, 74);
            txtAdres.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(92, 241);
            label10.Name = "label10";
            label10.Size = new Size(90, 37);
            label10.TabIndex = 29;
            label10.Text = "Adres:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(0, 195);
            label11.Name = "label11";
            label11.Size = new Size(182, 37);
            label11.TabIndex = 27;
            label11.Text = "Doğum Tarihi:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(188, 376);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(472, 43);
            txtMail.TabIndex = 7;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(188, 327);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(472, 43);
            txtTel.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(188, 100);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(472, 43);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(188, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(472, 43);
            txtAd.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(119, 51);
            label12.Name = "label12";
            label12.Size = new Size(63, 37);
            label12.TabIndex = 0;
            label12.Text = "Adı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(107, 373);
            label13.Name = "label13";
            label13.Size = new Size(75, 37);
            label13.TabIndex = 3;
            label13.Text = "Mail:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(79, 97);
            label14.Name = "label14";
            label14.Size = new Size(103, 37);
            label14.TabIndex = 1;
            label14.Text = "Soyadı:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(74, 327);
            label15.Name = "label15";
            label15.Size = new Size(108, 37);
            label15.TabIndex = 2;
            label15.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(705, 12);
            label5.Name = "label5";
            label5.Size = new Size(176, 37);
            label5.TabIndex = 44;
            label5.Text = "Misafir Listesi";
            // 
            // lstMisafir
            // 
            lstMisafir.FormattingEnabled = true;
            lstMisafir.ItemHeight = 37;
            lstMisafir.Location = new Point(705, 51);
            lstMisafir.Name = "lstMisafir";
            lstMisafir.Size = new Size(364, 226);
            lstMisafir.TabIndex = 43;
            lstMisafir.SelectedIndexChanged += lstMisafir_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(772, 283);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1803, 815);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lstMisafir);
            Controls.Add(groupBox1);
            Controls.Add(dgwRez);
            Controls.Add(label7);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Rezervasyon";
            Text = "Rezervasyon";
            Load += Frm_Rezervasyon_Load;
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrSayi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwRez).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnGuncelle;
        private Label label7;
        private ListBox lstRez;
        private Button btnKaydet;
        private Label label1;
        private Label label4;
        private Label label3;
        private GroupBox grpOtel;
        private ComboBox cmbOtel;
        private Label label6;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private ComboBox cmbRoomType;
        private Label lblTotal;
        private Label label9;
        private DataGridView dgwRez;
        private NumericUpDown nmrSayi;
        private Label label2;
        private GroupBox groupBox1;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtTCKN;
        private Label label8;
        private TextBox txtAdres;
        private Label label10;
        private Label label11;
        private TextBox txtMail;
        private TextBox txtTel;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label5;
        private ListBox lstMisafir;
        private Button btnGuestDelete;
        private Button btnGuestUpdate;
        private PictureBox pictureBox1;
    }
}