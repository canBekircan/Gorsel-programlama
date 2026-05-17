namespace gorselodev
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_sonizlenen = new System.Windows.Forms.Label();
            this.Lblana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFilmler = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnizle = new System.Windows.Forms.Button();
            this.panel_flm = new System.Windows.Forms.Panel();
            this.Lbl_int = new System.Windows.Forms.Label();
            this.Lbl_ata = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loupicture = new System.Windows.Forms.PictureBox();
            this.illegalpicture = new System.Windows.Forms.PictureBox();
            this.ataturkpicture = new System.Windows.Forms.PictureBox();
            this.interpicture = new System.Windows.Forms.PictureBox();
            this.Lbl_cikis = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlFilmler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_flm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loupicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illegalpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataturkpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Lbl_cikis);
            this.panel1.Controls.Add(this.Lbl_sonizlenen);
            this.panel1.Controls.Add(this.Lblana);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 71);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_sonizlenen
            // 
            this.Lbl_sonizlenen.AutoSize = true;
            this.Lbl_sonizlenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_sonizlenen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_sonizlenen.Location = new System.Drawing.Point(273, 22);
            this.Lbl_sonizlenen.Name = "Lbl_sonizlenen";
            this.Lbl_sonizlenen.Size = new System.Drawing.Size(94, 20);
            this.Lbl_sonizlenen.TabIndex = 7;
            this.Lbl_sonizlenen.Text = "Son İzlenen";
            this.Lbl_sonizlenen.Click += new System.EventHandler(this.Lbl_sonizlenen_Click_1);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlFilmler
            // 
            this.pnlFilmler.BackColor = System.Drawing.Color.Gray;
            this.pnlFilmler.ColumnCount = 4;
            this.pnlFilmler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlFilmler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlFilmler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlFilmler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlFilmler.Controls.Add(this.Loupicture, 3, 0);
            this.pnlFilmler.Controls.Add(this.illegalpicture, 2, 0);
            this.pnlFilmler.Controls.Add(this.ataturkpicture, 1, 0);
            this.pnlFilmler.Controls.Add(this.interpicture, 0, 0);
            this.pnlFilmler.Location = new System.Drawing.Point(0, 425);
            this.pnlFilmler.Name = "pnlFilmler";
            this.pnlFilmler.RowCount = 1;
            this.pnlFilmler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlFilmler.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.pnlFilmler.Size = new System.Drawing.Size(970, 224);
            this.pnlFilmler.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnizle);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 277);
            this.panel2.TabIndex = 2;
            // 
            // btnizle
            // 
            this.btnizle.BackColor = System.Drawing.Color.Red;
            this.btnizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnizle.Location = new System.Drawing.Point(0, 229);
            this.btnizle.Name = "btnizle";
            this.btnizle.Size = new System.Drawing.Size(126, 48);
            this.btnizle.TabIndex = 1;
            this.btnizle.Text = "Şimdi İzle";
            this.btnizle.UseVisualStyleBackColor = false;
            this.btnizle.Click += new System.EventHandler(this.btnizle_Click);
            // 
            // panel_flm
            // 
            this.panel_flm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_flm.Controls.Add(this.label4);
            this.panel_flm.Controls.Add(this.label3);
            this.panel_flm.Controls.Add(this.Lbl_ata);
            this.panel_flm.Controls.Add(this.Lbl_int);
            this.panel_flm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_flm.Location = new System.Drawing.Point(0, 348);
            this.panel_flm.Name = "panel_flm";
            this.panel_flm.Size = new System.Drawing.Size(970, 71);
            this.panel_flm.TabIndex = 3;
            // 
            // Lbl_int
            // 
            this.Lbl_int.AutoSize = true;
            this.Lbl_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_int.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_int.Location = new System.Drawing.Point(34, 29);
            this.Lbl_int.Name = "Lbl_int";
            this.Lbl_int.Size = new System.Drawing.Size(171, 25);
            this.Lbl_int.TabIndex = 0;
            this.Lbl_int.Text = "INTERSTELLAR";
            // 
            // Lbl_ata
            // 
            this.Lbl_ata.AutoSize = true;
            this.Lbl_ata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_ata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_ata.Location = new System.Drawing.Point(302, 29);
            this.Lbl_ata.Name = "Lbl_ata";
            this.Lbl_ata.Size = new System.Drawing.Size(114, 25);
            this.Lbl_ata.TabIndex = 1;
            this.Lbl_ata.Text = "ATATÜRK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(495, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "İLLEGAL HAYATLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(827, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "LOU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::gorselodev.Properties.Resources.aşk1012;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(970, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Loupicture
            // 
            this.Loupicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loupicture.Image = global::gorselodev.Properties.Resources.lou;
            this.Loupicture.Location = new System.Drawing.Point(729, 3);
            this.Loupicture.Name = "Loupicture";
            this.Loupicture.Size = new System.Drawing.Size(238, 218);
            this.Loupicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loupicture.TabIndex = 3;
            this.Loupicture.TabStop = false;
            this.Loupicture.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // illegalpicture
            // 
            this.illegalpicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.illegalpicture.Image = global::gorselodev.Properties.Resources.illegal;
            this.illegalpicture.Location = new System.Drawing.Point(487, 3);
            this.illegalpicture.Name = "illegalpicture";
            this.illegalpicture.Size = new System.Drawing.Size(236, 218);
            this.illegalpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.illegalpicture.TabIndex = 2;
            this.illegalpicture.TabStop = false;
            this.illegalpicture.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // ataturkpicture
            // 
            this.ataturkpicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ataturkpicture.Image = global::gorselodev.Properties.Resources.ataturk;
            this.ataturkpicture.Location = new System.Drawing.Point(245, 3);
            this.ataturkpicture.Name = "ataturkpicture";
            this.ataturkpicture.Size = new System.Drawing.Size(236, 218);
            this.ataturkpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ataturkpicture.TabIndex = 1;
            this.ataturkpicture.TabStop = false;
            this.ataturkpicture.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // interpicture
            // 
            this.interpicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interpicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interpicture.Image = global::gorselodev.Properties.Resources.inter;
            this.interpicture.Location = new System.Drawing.Point(3, 3);
            this.interpicture.Name = "interpicture";
            this.interpicture.Size = new System.Drawing.Size(236, 218);
            this.interpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.interpicture.TabIndex = 0;
            this.interpicture.TabStop = false;
            this.interpicture.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Lbl_cikis
            // 
            this.Lbl_cikis.AutoSize = true;
            this.Lbl_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_cikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_cikis.Location = new System.Drawing.Point(915, 17);
            this.Lbl_cikis.Name = "Lbl_cikis";
            this.Lbl_cikis.Size = new System.Drawing.Size(31, 29);
            this.Lbl_cikis.TabIndex = 8;
            this.Lbl_cikis.Text = "X";
            this.Lbl_cikis.Click += new System.EventHandler(this.Lbl_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(970, 714);
            this.Controls.Add(this.panel_flm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlFilmler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netflix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFilmler.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_flm.ResumeLayout(false);
            this.panel_flm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loupicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illegalpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataturkpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pnlFilmler;
        private System.Windows.Forms.PictureBox Loupicture;
        private System.Windows.Forms.PictureBox illegalpicture;
        private System.Windows.Forms.PictureBox ataturkpicture;
        private System.Windows.Forms.PictureBox interpicture;
        private System.Windows.Forms.Label Lbl_sonizlenen;
        private System.Windows.Forms.Label Lblana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnizle;
        private System.Windows.Forms.Panel panel_flm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_ata;
        private System.Windows.Forms.Label Lbl_int;
        private System.Windows.Forms.Label Lbl_cikis;
    }
}

