namespace Magazin
{
    partial class MesajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajForm));
            this.panel = new System.Windows.Forms.Panel();
            this.panelIncarca = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbImagine = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.panelIncarca);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 353);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(555, 30);
            this.panel.TabIndex = 0;
            // 
            // panelIncarca
            // 
            this.panelIncarca.BackColor = System.Drawing.Color.White;
            this.panelIncarca.Location = new System.Drawing.Point(0, 0);
            this.panelIncarca.Name = "panelIncarca";
            this.panelIncarca.Size = new System.Drawing.Size(49, 30);
            this.panelIncarca.TabIndex = 1;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblMesaj.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.ForeColor = System.Drawing.Color.White;
            this.lblMesaj.Location = new System.Drawing.Point(218, 251);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(93, 37);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "Mesaj";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbImagine
            // 
            this.pbImagine.BackColor = System.Drawing.Color.Transparent;
            this.pbImagine.Location = new System.Drawing.Point(181, 53);
            this.pbImagine.Name = "pbImagine";
            this.pbImagine.Size = new System.Drawing.Size(170, 170);
            this.pbImagine.TabIndex = 2;
            this.pbImagine.TabStop = false;
            // 
            // MesajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazin.Properties.Resources.backround_autentificare;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 383);
            this.Controls.Add(this.pbImagine);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesajForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelIncarca;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbImagine;
    }
}