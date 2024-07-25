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
            lstRez = new ListBox();
            btnKaydet = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpOtel = new GroupBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label8 = new Label();
            grpOtel.SuspendLayout();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Location = new Point(990, 429);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(185, 56);
            btnSil.TabIndex = 32;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(811, 429);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(173, 56);
            btnGuncelle.TabIndex = 31;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(637, 9);
            label7.Name = "label7";
            label7.Size = new Size(242, 37);
            label7.TabIndex = 30;
            label7.Text = "Rezervasyon Listesi";
            // 
            // lstRez
            // 
            lstRez.FormattingEnabled = true;
            lstRez.ItemHeight = 37;
            lstRez.Location = new Point(637, 49);
            lstRez.Name = "lstRez";
            lstRez.Size = new Size(538, 374);
            lstRez.TabIndex = 29;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(426, 384);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(178, 73);
            btnKaydet.TabIndex = 26;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(-6, 250);
            label4.Name = "label4";
            label4.Size = new Size(132, 37);
            label4.TabIndex = 3;
            label4.Text = "CheclOut:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(103, 37);
            label2.TabIndex = 1;
            label2.Text = "Misafir:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 195);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 2;
            label3.Text = "CheckIn:";
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(label8);
            grpOtel.Controls.Add(label6);
            grpOtel.Controls.Add(dateTimePicker2);
            grpOtel.Controls.Add(dateTimePicker1);
            grpOtel.Controls.Add(comboBox3);
            grpOtel.Controls.Add(label5);
            grpOtel.Controls.Add(comboBox2);
            grpOtel.Controls.Add(comboBox1);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label4);
            grpOtel.Controls.Add(label2);
            grpOtel.Controls.Add(label3);
            grpOtel.Location = new Point(12, 12);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(619, 473);
            grpOtel.TabIndex = 28;
            grpOtel.TabStop = false;
            grpOtel.Text = "Rezervasyon Bilgileri";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(472, 45);
            comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(472, 45);
            comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(132, 146);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(472, 45);
            comboBox3.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 144);
            label5.Name = "label5";
            label5.Size = new Size(73, 37);
            label5.TabIndex = 29;
            label5.Text = "Oda:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(132, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(472, 43);
            dateTimePicker1.TabIndex = 31;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(132, 197);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(472, 43);
            dateTimePicker2.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 336);
            label6.Name = "label6";
            label6.Size = new Size(84, 37);
            label6.TabIndex = 33;
            label6.Text = "Tutar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(132, 336);
            label8.Name = "label8";
            label8.Size = new Size(84, 37);
            label8.TabIndex = 34;
            label8.Text = "Tutar:";
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1197, 497);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(label7);
            Controls.Add(lstRez);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Rezervasyon";
            Text = "Frm_Rezervasyon";
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
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
        private Label label2;
        private Label label3;
        private GroupBox grpOtel;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private Label label5;
        private Label label8;
    }
}