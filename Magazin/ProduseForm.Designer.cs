namespace Magazin
{
    partial class ProduseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduseForm));
            this.panelProduse = new System.Windows.Forms.Panel();
            this.lblProduse = new System.Windows.Forms.Label();
            this.flowLayoutProduse = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.acasăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femeiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantofiFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costumeFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bărbațiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantofiBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.costumeBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProduse.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProduse
            // 
            this.panelProduse.BackColor = System.Drawing.Color.White;
            this.panelProduse.BackgroundImage = global::Magazin.Properties.Resources.Backround;
            this.panelProduse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelProduse.Controls.Add(this.lblProduse);
            this.panelProduse.Controls.Add(this.flowLayoutProduse);
            this.panelProduse.Controls.Add(this.menuStrip);
            this.panelProduse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProduse.Location = new System.Drawing.Point(0, 0);
            this.panelProduse.Margin = new System.Windows.Forms.Padding(2);
            this.panelProduse.Name = "panelProduse";
            this.panelProduse.Size = new System.Drawing.Size(843, 647);
            this.panelProduse.TabIndex = 0;
            // 
            // lblProduse
            // 
            this.lblProduse.AutoSize = true;
            this.lblProduse.BackColor = System.Drawing.Color.Transparent;
            this.lblProduse.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduse.ForeColor = System.Drawing.Color.White;
            this.lblProduse.Location = new System.Drawing.Point(132, 86);
            this.lblProduse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduse.Name = "lblProduse";
            this.lblProduse.Size = new System.Drawing.Size(577, 65);
            this.lblProduse.TabIndex = 1;
            this.lblProduse.Text = "PRODUSELE NOASTRE";
            this.lblProduse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutProduse
            // 
            this.flowLayoutProduse.AutoScroll = true;
            this.flowLayoutProduse.BackColor = System.Drawing.Color.White;
            this.flowLayoutProduse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutProduse.Location = new System.Drawing.Point(95, 172);
            this.flowLayoutProduse.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutProduse.Name = "flowLayoutProduse";
            this.flowLayoutProduse.Size = new System.Drawing.Size(657, 415);
            this.flowLayoutProduse.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acasăToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.cosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(843, 38);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // acasăToolStripMenuItem
            // 
            this.acasăToolStripMenuItem.Image = global::Magazin.Properties.Resources.acasa;
            this.acasăToolStripMenuItem.Name = "acasăToolStripMenuItem";
            this.acasăToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.acasăToolStripMenuItem.Text = "Acasă";
            this.acasăToolStripMenuItem.Click += new System.EventHandler(this.acasăToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.femeiToolStripMenuItem,
            this.bărbațiToolStripMenuItem});
            this.produseToolStripMenuItem.Image = global::Magazin.Properties.Resources.produse;
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // femeiToolStripMenuItem
            // 
            this.femeiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantofiFToolStripMenuItem,
            this.costumeFToolStripMenuItem});
            this.femeiToolStripMenuItem.Image = global::Magazin.Properties.Resources.femeie;
            this.femeiToolStripMenuItem.Name = "femeiToolStripMenuItem";
            this.femeiToolStripMenuItem.Size = new System.Drawing.Size(174, 36);
            this.femeiToolStripMenuItem.Text = "Femei";
            // 
            // pantofiFToolStripMenuItem
            // 
            this.pantofiFToolStripMenuItem.Image = global::Magazin.Properties.Resources.pantofF;
            this.pantofiFToolStripMenuItem.Name = "pantofiFToolStripMenuItem";
            this.pantofiFToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.pantofiFToolStripMenuItem.Text = "Pantofi";
            this.pantofiFToolStripMenuItem.Click += new System.EventHandler(this.pantofiFToolStripMenuItem_Click);
            // 
            // costumeFToolStripMenuItem
            // 
            this.costumeFToolStripMenuItem.Image = global::Magazin.Properties.Resources.rochie;
            this.costumeFToolStripMenuItem.Name = "costumeFToolStripMenuItem";
            this.costumeFToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.costumeFToolStripMenuItem.Text = "Costume";
            this.costumeFToolStripMenuItem.Click += new System.EventHandler(this.costumeFToolStripMenuItem1_Click);
            // 
            // bărbațiToolStripMenuItem
            // 
            this.bărbațiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantofiBToolStripMenuItem1,
            this.costumeBToolStripMenuItem1});
            this.bărbațiToolStripMenuItem.Image = global::Magazin.Properties.Resources.barbat;
            this.bărbațiToolStripMenuItem.Name = "bărbațiToolStripMenuItem";
            this.bărbațiToolStripMenuItem.Size = new System.Drawing.Size(174, 36);
            this.bărbațiToolStripMenuItem.Text = "Bărbați";
            // 
            // pantofiBToolStripMenuItem1
            // 
            this.pantofiBToolStripMenuItem1.Image = global::Magazin.Properties.Resources.pantofB;
            this.pantofiBToolStripMenuItem1.Name = "pantofiBToolStripMenuItem1";
            this.pantofiBToolStripMenuItem1.Size = new System.Drawing.Size(193, 36);
            this.pantofiBToolStripMenuItem1.Text = "Pantofi";
            this.pantofiBToolStripMenuItem1.Click += new System.EventHandler(this.pantofiBToolStripMenuItem_Click);
            // 
            // costumeBToolStripMenuItem1
            // 
            this.costumeBToolStripMenuItem1.Image = global::Magazin.Properties.Resources.costumB;
            this.costumeBToolStripMenuItem1.Name = "costumeBToolStripMenuItem1";
            this.costumeBToolStripMenuItem1.Size = new System.Drawing.Size(193, 36);
            this.costumeBToolStripMenuItem1.Text = "Costume";
            this.costumeBToolStripMenuItem1.Click += new System.EventHandler(this.costumeBToolStripMenuItem1_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cosToolStripMenuItem.Image = global::Magazin.Properties.Resources.cos;
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.cosToolStripMenuItem.Text = "Coș";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.coșToolStripMenuItem_Click);
            // 
            // ProduseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 647);
            this.Controls.Add(this.panelProduse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProduseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse";
            this.panelProduse.ResumeLayout(false);
            this.panelProduse.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProduse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutProduse;
        private System.Windows.Forms.Label lblProduse;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem acasăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femeiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantofiFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costumeFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bărbațiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantofiBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem costumeBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
    }
}