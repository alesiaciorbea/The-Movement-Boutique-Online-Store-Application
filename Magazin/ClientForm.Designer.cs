namespace Magazin
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.acasăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femeiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantofiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.costumeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bărbațiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantofiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSalut = new System.Windows.Forms.Label();
            this.pbFPantofi = new System.Windows.Forms.PictureBox();
            this.pbFCostum = new System.Windows.Forms.PictureBox();
            this.pbBPantofi = new System.Windows.Forms.PictureBox();
            this.pbBCostum = new System.Windows.Forms.PictureBox();
            this.lblFPantofi = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblFRochii = new System.Windows.Forms.Label();
            this.lblBPantofi = new System.Windows.Forms.Label();
            this.lblBCostum = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFPantofi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFCostum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBPantofi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBCostum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acasăToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.deconectareToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(933, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // acasăToolStripMenuItem
            // 
            this.acasăToolStripMenuItem.Image = global::Magazin.Properties.Resources.acasa;
            this.acasăToolStripMenuItem.Name = "acasăToolStripMenuItem";
            this.acasăToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.acasăToolStripMenuItem.Text = " Acasă";
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
            this.pantofiToolStripMenuItem1,
            this.costumeToolStripMenuItem1});
            this.femeiToolStripMenuItem.Image = global::Magazin.Properties.Resources.femeie;
            this.femeiToolStripMenuItem.Name = "femeiToolStripMenuItem";
            this.femeiToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.femeiToolStripMenuItem.Text = "Femei";
            // 
            // pantofiToolStripMenuItem1
            // 
            this.pantofiToolStripMenuItem1.Image = global::Magazin.Properties.Resources.pantofF;
            this.pantofiToolStripMenuItem1.Name = "pantofiToolStripMenuItem1";
            this.pantofiToolStripMenuItem1.Size = new System.Drawing.Size(193, 36);
            this.pantofiToolStripMenuItem1.Text = "Pantofi";
            this.pantofiToolStripMenuItem1.Click += new System.EventHandler(this.pantofiToolStripMenuItem1_Click);
            // 
            // costumeToolStripMenuItem1
            // 
            this.costumeToolStripMenuItem1.Image = global::Magazin.Properties.Resources.rochie;
            this.costumeToolStripMenuItem1.Name = "costumeToolStripMenuItem1";
            this.costumeToolStripMenuItem1.Size = new System.Drawing.Size(193, 36);
            this.costumeToolStripMenuItem1.Text = "Costume";
            this.costumeToolStripMenuItem1.Click += new System.EventHandler(this.costumeToolStripMenuItem1_Click);
            // 
            // bărbațiToolStripMenuItem
            // 
            this.bărbațiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantofiToolStripMenuItem,
            this.costumeToolStripMenuItem});
            this.bărbațiToolStripMenuItem.Image = global::Magazin.Properties.Resources.barbat;
            this.bărbațiToolStripMenuItem.Name = "bărbațiToolStripMenuItem";
            this.bărbațiToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.bărbațiToolStripMenuItem.Text = "Bărbați";
            // 
            // pantofiToolStripMenuItem
            // 
            this.pantofiToolStripMenuItem.Image = global::Magazin.Properties.Resources.pantofB;
            this.pantofiToolStripMenuItem.Name = "pantofiToolStripMenuItem";
            this.pantofiToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.pantofiToolStripMenuItem.Text = "Pantofi";
            this.pantofiToolStripMenuItem.Click += new System.EventHandler(this.pantofiToolStripMenuItem_Click);
            // 
            // costumeToolStripMenuItem
            // 
            this.costumeToolStripMenuItem.Image = global::Magazin.Properties.Resources.costumB;
            this.costumeToolStripMenuItem.Name = "costumeToolStripMenuItem";
            this.costumeToolStripMenuItem.Size = new System.Drawing.Size(193, 36);
            this.costumeToolStripMenuItem.Text = "Costume";
            this.costumeToolStripMenuItem.Click += new System.EventHandler(this.costumeToolStripMenuItem_Click);
            // 
            // deconectareToolStripMenuItem
            // 
            this.deconectareToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deconectareToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deconectareToolStripMenuItem.Image = global::Magazin.Properties.Resources.deconectare;
            this.deconectareToolStripMenuItem.Name = "deconectareToolStripMenuItem";
            this.deconectareToolStripMenuItem.Size = new System.Drawing.Size(185, 36);
            this.deconectareToolStripMenuItem.Text = "Deconectare";
            this.deconectareToolStripMenuItem.Click += new System.EventHandler(this.deconectareToolStripMenuItem_Click);
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
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::Magazin.Properties.Resources.despre;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.infoToolStripMenuItem.Text = "Despre noi";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // lblSalut
            // 
            this.lblSalut.AutoSize = true;
            this.lblSalut.BackColor = System.Drawing.Color.Transparent;
            this.lblSalut.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalut.ForeColor = System.Drawing.Color.White;
            this.lblSalut.Location = new System.Drawing.Point(390, 77);
            this.lblSalut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalut.Name = "lblSalut";
            this.lblSalut.Size = new System.Drawing.Size(87, 39);
            this.lblSalut.TabIndex = 1;
            this.lblSalut.Text = "Salut";
            // 
            // pbFPantofi
            // 
            this.pbFPantofi.BackgroundImage = global::Magazin.Properties.Resources.pantofi_plasa_rosii;
            this.pbFPantofi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFPantofi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFPantofi.Location = new System.Drawing.Point(74, 240);
            this.pbFPantofi.Margin = new System.Windows.Forms.Padding(2);
            this.pbFPantofi.Name = "pbFPantofi";
            this.pbFPantofi.Size = new System.Drawing.Size(180, 180);
            this.pbFPantofi.TabIndex = 2;
            this.pbFPantofi.TabStop = false;
            this.pbFPantofi.Click += new System.EventHandler(this.pbFPantofi_Click);
            // 
            // pbFCostum
            // 
            this.pbFCostum.BackgroundImage = global::Magazin.Properties.Resources.rochie_rosie;
            this.pbFCostum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFCostum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFCostum.Location = new System.Drawing.Point(275, 240);
            this.pbFCostum.Margin = new System.Windows.Forms.Padding(2);
            this.pbFCostum.Name = "pbFCostum";
            this.pbFCostum.Size = new System.Drawing.Size(180, 180);
            this.pbFCostum.TabIndex = 3;
            this.pbFCostum.TabStop = false;
            this.pbFCostum.Click += new System.EventHandler(this.pbFCostum_Click);
            // 
            // pbBPantofi
            // 
            this.pbBPantofi.BackgroundImage = global::Magazin.Properties.Resources.pantofi_barbati_rosii;
            this.pbBPantofi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBPantofi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBPantofi.Location = new System.Drawing.Point(690, 240);
            this.pbBPantofi.Margin = new System.Windows.Forms.Padding(2);
            this.pbBPantofi.Name = "pbBPantofi";
            this.pbBPantofi.Size = new System.Drawing.Size(180, 180);
            this.pbBPantofi.TabIndex = 4;
            this.pbBPantofi.TabStop = false;
            this.pbBPantofi.Click += new System.EventHandler(this.pbBPantofi_Click);
            // 
            // pbBCostum
            // 
            this.pbBCostum.BackgroundImage = global::Magazin.Properties.Resources.costum_barbatii_negru;
            this.pbBCostum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBCostum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBCostum.Location = new System.Drawing.Point(480, 240);
            this.pbBCostum.Margin = new System.Windows.Forms.Padding(2);
            this.pbBCostum.Name = "pbBCostum";
            this.pbBCostum.Size = new System.Drawing.Size(180, 180);
            this.pbBCostum.TabIndex = 5;
            this.pbBCostum.TabStop = false;
            this.pbBCostum.Click += new System.EventHandler(this.pbBCostum_Click);
            // 
            // lblFPantofi
            // 
            this.lblFPantofi.AutoSize = true;
            this.lblFPantofi.BackColor = System.Drawing.Color.Transparent;
            this.lblFPantofi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPantofi.ForeColor = System.Drawing.Color.Transparent;
            this.lblFPantofi.Location = new System.Drawing.Point(78, 434);
            this.lblFPantofi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFPantofi.Name = "lblFPantofi";
            this.lblFPantofi.Size = new System.Drawing.Size(167, 26);
            this.lblFPantofi.TabIndex = 6;
            this.lblFPantofi.Text = "PANTOFI FEMEI";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Palatino Linotype", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(389, 148);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(96, 47);
            this.lblTitlu.TabIndex = 7;
            this.lblTitlu.Text = "Titlu";
            // 
            // lblFRochii
            // 
            this.lblFRochii.AutoSize = true;
            this.lblFRochii.BackColor = System.Drawing.Color.Transparent;
            this.lblFRochii.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFRochii.ForeColor = System.Drawing.Color.Transparent;
            this.lblFRochii.Location = new System.Drawing.Point(289, 434);
            this.lblFRochii.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFRochii.Name = "lblFRochii";
            this.lblFRochii.Size = new System.Drawing.Size(152, 26);
            this.lblFRochii.TabIndex = 8;
            this.lblFRochii.Text = "ROCHII FEMEI";
            // 
            // lblBPantofi
            // 
            this.lblBPantofi.AutoSize = true;
            this.lblBPantofi.BackColor = System.Drawing.Color.Transparent;
            this.lblBPantofi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPantofi.ForeColor = System.Drawing.Color.Transparent;
            this.lblBPantofi.Location = new System.Drawing.Point(685, 434);
            this.lblBPantofi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBPantofi.Name = "lblBPantofi";
            this.lblBPantofi.Size = new System.Drawing.Size(196, 26);
            this.lblBPantofi.TabIndex = 9;
            this.lblBPantofi.Text = "PANTOFI BĂRBAȚI";
            // 
            // lblBCostum
            // 
            this.lblBCostum.AutoSize = true;
            this.lblBCostum.BackColor = System.Drawing.Color.Transparent;
            this.lblBCostum.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCostum.ForeColor = System.Drawing.Color.Transparent;
            this.lblBCostum.Location = new System.Drawing.Point(475, 434);
            this.lblBCostum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBCostum.Name = "lblBCostum";
            this.lblBCostum.Size = new System.Drawing.Size(196, 26);
            this.lblBCostum.TabIndex = 10;
            this.lblBCostum.Text = "COSTUM BĂRBAȚI";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Magazin.Properties.Resources.logo_rotund;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(43, 50);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(12, 152);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(183, 21);
            this.lblLogo.TabIndex = 12;
            this.lblLogo.Text = "The Movement Boutique";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Magazin.Properties.Resources.Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 573);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblBCostum);
            this.Controls.Add(this.lblBPantofi);
            this.Controls.Add(this.lblFRochii);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblFPantofi);
            this.Controls.Add(this.pbBCostum);
            this.Controls.Add(this.pbBPantofi);
            this.Controls.Add(this.pbFCostum);
            this.Controls.Add(this.pbFPantofi);
            this.Controls.Add(this.lblSalut);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazin";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFPantofi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFCostum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBPantofi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBCostum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem acasăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femeiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantofiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem costumeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bărbațiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantofiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.Label lblSalut;
        private System.Windows.Forms.ToolStripMenuItem deconectareToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbFPantofi;
        private System.Windows.Forms.PictureBox pbFCostum;
        private System.Windows.Forms.PictureBox pbBPantofi;
        private System.Windows.Forms.PictureBox pbBCostum;
        private System.Windows.Forms.Label lblFPantofi;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblFRochii;
        private System.Windows.Forms.Label lblBPantofi;
        private System.Windows.Forms.Label lblBCostum;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label lblLogo;
    }
}