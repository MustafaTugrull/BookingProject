namespace Booking.UI.Forms
{
    partial class Frm_Misafir
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
            grpOtel = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            txtTCKN = new TextBox();
            label6 = new Label();
            txtAdres = new TextBox();
            label5 = new Label();
            label8 = new Label();
            btnKaydet = new Button();
            txtMail = new TextBox();
            txtTel = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpOtel.SuspendLayout();
            SuspendLayout();
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(dtpDateOfBirth);
            grpOtel.Controls.Add(txtTCKN);
            grpOtel.Controls.Add(label6);
            grpOtel.Controls.Add(txtAdres);
            grpOtel.Controls.Add(label5);
            grpOtel.Controls.Add(label8);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(txtMail);
            grpOtel.Controls.Add(txtTel);
            grpOtel.Controls.Add(txtSoyad);
            grpOtel.Controls.Add(txtAd);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label4);
            grpOtel.Controls.Add(label2);
            grpOtel.Controls.Add(label3);
            grpOtel.Location = new Point(17, 13);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(720, 484);
            grpOtel.TabIndex = 33;
            grpOtel.TabStop = false;
            grpOtel.Text = "Misafir Bilgileri";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 146);
            label6.Name = "label6";
            label6.Size = new Size(133, 37);
            label6.TabIndex = 31;
            label6.Text = "TC Kimlik:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(188, 247);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(472, 74);
            txtAdres.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 241);
            label5.Name = "label5";
            label5.Size = new Size(90, 37);
            label5.TabIndex = 29;
            label5.Text = "Adres:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 195);
            label8.Name = "label8";
            label8.Size = new Size(182, 37);
            label8.TabIndex = 27;
            label8.Text = "Doğum Tarihi:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(490, 423);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(170, 50);
            btnKaydet.TabIndex = 26;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 37);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 373);
            label4.Name = "label4";
            label4.Size = new Size(75, 37);
            label4.TabIndex = 3;
            label4.Text = "Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 97);
            label2.Name = "label2";
            label2.Size = new Size(103, 37);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 327);
            label3.Name = "label3";
            label3.Size = new Size(108, 37);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // Frm_Misafir
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(873, 503);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Misafir";
            Text = "Frm_Misafir";
            Load += Frm_Misafir_Load;
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOtel;
        private Button btnKaydet;
        private TextBox txtMail;
        private TextBox txtTel;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label8;
        private TextBox txtAdres;
        private Label label5;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtTCKN;
        private Label label6;
    }
}