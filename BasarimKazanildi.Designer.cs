
namespace MC_Login
{
    partial class BasarimKazanildi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasarimKazanildi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.basarimaciklamasi = new System.Windows.Forms.Label();
            this.basarimadi = new System.Windows.Forms.Label();
            this.basarimkazanildi0 = new System.Windows.Forms.Label();
            this.basarimgidiyor = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.basarimaciklamasi);
            this.panel1.Controls.Add(this.basarimadi);
            this.panel1.Controls.Add(this.basarimkazanildi0);
            this.panel1.Location = new System.Drawing.Point(541, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 115);
            this.panel1.TabIndex = 32;
            // 
            // basarimaciklamasi
            // 
            this.basarimaciklamasi.AutoSize = true;
            this.basarimaciklamasi.Font = new System.Drawing.Font("Minecraft", 10F);
            this.basarimaciklamasi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.basarimaciklamasi.Location = new System.Drawing.Point(129, 74);
            this.basarimaciklamasi.Name = "basarimaciklamasi";
            this.basarimaciklamasi.Size = new System.Drawing.Size(65, 20);
            this.basarimaciklamasi.TabIndex = 2;
            this.basarimaciklamasi.Text = "        ";
            // 
            // basarimadi
            // 
            this.basarimadi.AutoSize = true;
            this.basarimadi.Font = new System.Drawing.Font("Minecraft", 10F);
            this.basarimadi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.basarimadi.Location = new System.Drawing.Point(129, 51);
            this.basarimadi.Name = "basarimadi";
            this.basarimadi.Size = new System.Drawing.Size(65, 20);
            this.basarimadi.TabIndex = 1;
            this.basarimadi.Text = "        ";
            // 
            // basarimkazanildi0
            // 
            this.basarimkazanildi0.AutoSize = true;
            this.basarimkazanildi0.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold);
            this.basarimkazanildi0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.basarimkazanildi0.Location = new System.Drawing.Point(129, 27);
            this.basarimkazanildi0.Name = "basarimkazanildi0";
            this.basarimkazanildi0.Size = new System.Drawing.Size(82, 24);
            this.basarimkazanildi0.TabIndex = 0;
            this.basarimkazanildi0.Text = "        ";
            // 
            // basarimgidiyor
            // 
            this.basarimgidiyor.Interval = 2999;
            this.basarimgidiyor.Tick += new System.EventHandler(this.basarimgidiyor_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BasarimKazanildi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasarimKazanildi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BasarimKazanildi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label basarimaciklamasi;
        private System.Windows.Forms.Label basarimadi;
        private System.Windows.Forms.Label basarimkazanildi0;
        private System.Windows.Forms.Timer basarimgidiyor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}