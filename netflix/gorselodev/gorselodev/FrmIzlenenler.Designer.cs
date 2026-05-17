namespace gorselodev
{
    partial class FrmIzlenenler
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
            this.pnlIzlenenler = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lblana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_cikis = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIzlenenler
            // 
            this.pnlIzlenenler.ColumnCount = 4;
            this.pnlIzlenenler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlIzlenenler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlIzlenenler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlIzlenenler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlIzlenenler.Location = new System.Drawing.Point(4, 77);
            this.pnlIzlenenler.Name = "pnlIzlenenler";
            this.pnlIzlenenler.RowCount = 1;
            this.pnlIzlenenler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlIzlenenler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlIzlenenler.Size = new System.Drawing.Size(991, 260);
            this.pnlIzlenenler.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Lbl_cikis);
            this.panel1.Controls.Add(this.Lblana);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 71);
            this.panel1.TabIndex = 1;
            // 
            // Lblana
            // 
            this.Lblana.AutoSize = true;
            this.Lblana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblana.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lblana.Location = new System.Drawing.Point(184, 22);
            this.Lblana.Name = "Lblana";
            this.Lblana.Size = new System.Drawing.Size(83, 20);
            this.Lblana.TabIndex = 6;
            this.Lblana.Text = "Ana Sayfa";
            this.Lblana.Click += new System.EventHandler(this.Lblana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "NETFLİX";
            // 
            // Lbl_cikis
            // 
            this.Lbl_cikis.AutoSize = true;
            this.Lbl_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_cikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_cikis.Location = new System.Drawing.Point(922, 20);
            this.Lbl_cikis.Name = "Lbl_cikis";
            this.Lbl_cikis.Size = new System.Drawing.Size(31, 29);
            this.Lbl_cikis.TabIndex = 7;
            this.Lbl_cikis.Text = "X";
            this.Lbl_cikis.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmIzlenenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(970, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIzlenenler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzlenenler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIzlenenler";
            this.Load += new System.EventHandler(this.FrmIzlenenler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlIzlenenler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lblana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_cikis;
    }
}