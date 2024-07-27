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
            btnSil = new Button();
            btnGuncelle = new Button();
            label7 = new Label();
            btnKaydet = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            grpOtel = new GroupBox();
            nmrYildiz = new NumericUpDown();
            label2 = new Label();
            cmbRoom = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            cmbRoomType = new ComboBox();
            label5 = new Label();
            cmbOtel = new ComboBox();
            dgwRez = new DataGridView();
            grpOtel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrYildiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwRez).BeginInit();
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
            label7.Location = new Point(12, 488);
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
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Otel Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-6, 303);
            label4.Name = "label4";
            label4.Size = new Size(132, 37);
            label4.TabIndex = 3;
            label4.Text = "CheclOut:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 248);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 2;
            label3.Text = "CheckIn:";
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(nmrYildiz);
            grpOtel.Controls.Add(btnSil);
            grpOtel.Controls.Add(label2);
            grpOtel.Controls.Add(btnGuncelle);
            grpOtel.Controls.Add(cmbRoom);
            grpOtel.Controls.Add(label9);
            grpOtel.Controls.Add(label8);
            grpOtel.Controls.Add(label6);
            grpOtel.Controls.Add(dateTimePicker2);
            grpOtel.Controls.Add(dateTimePicker1);
            grpOtel.Controls.Add(cmbRoomType);
            grpOtel.Controls.Add(label5);
            grpOtel.Controls.Add(cmbOtel);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label4);
            grpOtel.Controls.Add(label3);
            grpOtel.Location = new Point(12, 12);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(619, 465);
            grpOtel.TabIndex = 28;
            grpOtel.TabStop = false;
            grpOtel.Text = "Rezervasyon Bilgileri";
            // 
            // nmrYildiz
            // 
            nmrYildiz.Location = new Point(195, 201);
            nmrYildiz.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrYildiz.Name = "nmrYildiz";
            nmrYildiz.Size = new Size(120, 43);
            nmrYildiz.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 203);
            label2.Name = "label2";
            label2.Size = new Size(183, 37);
            label2.TabIndex = 37;
            label2.Text = "Misafir Sayısı :";
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(132, 148);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(472, 45);
            cmbRoom.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 97);
            label9.Name = "label9";
            label9.Size = new Size(117, 37);
            label9.TabIndex = 35;
            label9.Text = "Oda Tip:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(132, 345);
            label8.Name = "label8";
            label8.Size = new Size(84, 37);
            label8.TabIndex = 34;
            label8.Text = "Tutar:";
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(132, 250);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(472, 43);
            dateTimePicker2.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 299);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(472, 43);
            dateTimePicker1.TabIndex = 31;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(132, 97);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(472, 45);
            cmbRoomType.TabIndex = 30;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 151);
            label5.Name = "label5";
            label5.Size = new Size(73, 37);
            label5.TabIndex = 29;
            label5.Text = "Oda:";
            // 
            // cmbOtel
            // 
            cmbOtel.FormattingEnabled = true;
            cmbOtel.Location = new Point(132, 46);
            cmbOtel.Name = "cmbOtel";
            cmbOtel.Size = new Size(472, 45);
            cmbOtel.TabIndex = 27;
            cmbOtel.SelectedIndexChanged += cmbOtel_SelectedIndexChanged;
            // 
            // dgwRez
            // 
            dgwRez.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRez.Location = new Point(12, 521);
            dgwRez.Name = "dgwRez";
            dgwRez.Size = new Size(619, 239);
            dgwRez.TabIndex = 33;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1678, 787);
            Controls.Add(dgwRez);
            Controls.Add(label7);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Rezervasyon";
            Text = "Frm_Rezervasyon";
            Load += Frm_Rezervasyon_Load;
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrYildiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwRez).EndInit();
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
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbRoomType;
        private Label label5;
        private Label label8;
        private ComboBox cmbRoom;
        private Label label9;
        private DataGridView dgwRez;
        private NumericUpDown nmrYildiz;
        private Label label2;
    }
}