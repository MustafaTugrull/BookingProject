namespace Booking.UI.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            tANIMLAMALARToolStripMenuItem = new ToolStripMenuItem();
            oTELToolStripMenuItem1 = new ToolStripMenuItem();
            mISAFIRToolStripMenuItem = new ToolStripMenuItem();
            rEZERVASYONtoolStripMenuItem1 = new ToolStripMenuItem();
            oDAKAYITToolStripMenuItem = new ToolStripMenuItem();
            oDATİPKAYITToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 20F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tANIMLAMALARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1798, 45);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tANIMLAMALARToolStripMenuItem
            // 
            tANIMLAMALARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oTELToolStripMenuItem1, mISAFIRToolStripMenuItem, rEZERVASYONtoolStripMenuItem1, oDAKAYITToolStripMenuItem, oDATİPKAYITToolStripMenuItem });
            tANIMLAMALARToolStripMenuItem.Name = "tANIMLAMALARToolStripMenuItem";
            tANIMLAMALARToolStripMenuItem.Size = new Size(129, 41);
            tANIMLAMALARToolStripMenuItem.Text = "MENU #";
            // 
            // oTELToolStripMenuItem1
            // 
            oTELToolStripMenuItem1.Name = "oTELToolStripMenuItem1";
            oTELToolStripMenuItem1.Size = new Size(269, 42);
            oTELToolStripMenuItem1.Text = "OTEL KAYIT ";
            oTELToolStripMenuItem1.Click += oTELToolStripMenuItem1_Click;
            // 
            // mISAFIRToolStripMenuItem
            // 
            mISAFIRToolStripMenuItem.Name = "mISAFIRToolStripMenuItem";
            mISAFIRToolStripMenuItem.Size = new Size(269, 42);
            mISAFIRToolStripMenuItem.Text = "MİSAFİR KAYIT";
            mISAFIRToolStripMenuItem.Click += mISAFIRToolStripMenuItem_Click;
            // 
            // rEZERVASYONtoolStripMenuItem1
            // 
            rEZERVASYONtoolStripMenuItem1.Name = "rEZERVASYONtoolStripMenuItem1";
            rEZERVASYONtoolStripMenuItem1.Size = new Size(269, 42);
            rEZERVASYONtoolStripMenuItem1.Text = "REZERVASYON";
            rEZERVASYONtoolStripMenuItem1.Click += rEZERVASYONtoolStripMenuItem1_Click;
            // 
            // oDAKAYITToolStripMenuItem
            // 
            oDAKAYITToolStripMenuItem.Name = "oDAKAYITToolStripMenuItem";
            oDAKAYITToolStripMenuItem.Size = new Size(269, 42);
            oDAKAYITToolStripMenuItem.Text = "ODA KAYIT";
            oDAKAYITToolStripMenuItem.Click += oDAKAYITToolStripMenuItem_Click;
            // 
            // oDATİPKAYITToolStripMenuItem
            // 
            oDATİPKAYITToolStripMenuItem.Name = "oDATİPKAYITToolStripMenuItem";
            oDATİPKAYITToolStripMenuItem.Size = new Size(269, 42);
            oDATİPKAYITToolStripMenuItem.Text = "ODA TİP KAYIT";
            oDATİPKAYITToolStripMenuItem.Click += oDATİPKAYITToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1798, 732);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20F);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tANIMLAMALARToolStripMenuItem;
        private ToolStripMenuItem oTELToolStripMenuItem1;
        private ToolStripMenuItem mISAFIRToolStripMenuItem;
        private ToolStripMenuItem rEZERVASYONtoolStripMenuItem1;
        private ToolStripMenuItem oDAKAYITToolStripMenuItem;
        private ToolStripMenuItem oDATİPKAYITToolStripMenuItem;
    }
}