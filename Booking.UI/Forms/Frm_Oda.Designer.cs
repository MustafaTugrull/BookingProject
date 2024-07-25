namespace Booking.UI.Forms
{
    partial class Frm_Oda
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
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            label7 = new Label();
            lstOda = new ListBox();
            grpOtel = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            chkActive = new CheckBox();
            grpOtel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 149);
            label5.Name = "label5";
            label5.Size = new Size(116, 37);
            label5.TabIndex = 29;
            label5.Text = "Oda No:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(472, 45);
            comboBox2.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(472, 45);
            comboBox1.TabIndex = 27;
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
            label1.Location = new Point(7, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Otel Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 100);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 1;
            label2.Text = "Oda Tipi:";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(995, 433);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(185, 56);
            btnSil.TabIndex = 37;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(816, 433);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(173, 56);
            btnGuncelle.TabIndex = 36;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(642, 13);
            label7.Name = "label7";
            label7.Size = new Size(146, 37);
            label7.TabIndex = 35;
            label7.Text = "Oda Listesi";
            // 
            // lstOda
            // 
            lstOda.FormattingEnabled = true;
            lstOda.ItemHeight = 37;
            lstOda.Location = new Point(642, 53);
            lstOda.Name = "lstOda";
            lstOda.Size = new Size(538, 374);
            lstOda.TabIndex = 34;
            // 
            // grpOtel
            // 
            grpOtel.BackColor = SystemColors.Control;
            grpOtel.Controls.Add(chkActive);
            grpOtel.Controls.Add(label3);
            grpOtel.Controls.Add(numericUpDown2);
            grpOtel.Controls.Add(label5);
            grpOtel.Controls.Add(comboBox2);
            grpOtel.Controls.Add(comboBox1);
            grpOtel.Controls.Add(btnKaydet);
            grpOtel.Controls.Add(label1);
            grpOtel.Controls.Add(label2);
            grpOtel.Location = new Point(17, 16);
            grpOtel.Name = "grpOtel";
            grpOtel.Size = new Size(619, 473);
            grpOtel.TabIndex = 33;
            grpOtel.TabStop = false;
            grpOtel.Text = "Oda Bilgileri";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(132, 147);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 43);
            numericUpDown2.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 198);
            label3.Name = "label3";
            label3.Size = new Size(104, 37);
            label3.TabIndex = 37;
            label3.Text = "Durum:";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(132, 197);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(90, 41);
            chkActive.TabIndex = 38;
            chkActive.Text = "Aktif";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // Frm_Oda
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1197, 503);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(label7);
            Controls.Add(lstOda);
            Controls.Add(grpOtel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Frm_Oda";
            Text = "Frm_Oda";
            grpOtel.ResumeLayout(false);
            grpOtel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label7;
        private ListBox lstOda;
        private GroupBox grpOtel;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private CheckBox chkActive;
    }
}