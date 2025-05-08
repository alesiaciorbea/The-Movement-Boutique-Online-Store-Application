namespace Magazin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtMarime = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnImagine = new System.Windows.Forms.Button();
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.gbProdus = new System.Windows.Forms.GroupBox();
            this.pbImagine = new System.Windows.Forms.PictureBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblMarime = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.gbActiuni = new System.Windows.Forms.GroupBox();
            this.lblCauta = new System.Windows.Forms.Label();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvComenzi = new System.Windows.Forms.DataGridView();
            this.lblComenzi = new System.Windows.Forms.Label();
            this.lblStoc = new System.Windows.Forms.Label();
            this.btnFinalizare = new System.Windows.Forms.Button();
            this.gbStoc = new System.Windows.Forms.GroupBox();
            this.gbComenzi = new System.Windows.Forms.GroupBox();
            this.btnStergeC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.gbProdus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).BeginInit();
            this.gbActiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).BeginInit();
            this.gbStoc.SuspendLayout();
            this.gbComenzi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(150, 104);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(252, 26);
            this.cmbCategorie.TabIndex = 0;
            // 
            // txtDenumire
            // 
            this.txtDenumire.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenumire.Location = new System.Drawing.Point(150, 52);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(252, 25);
            this.txtDenumire.TabIndex = 1;
            // 
            // txtMarime
            // 
            this.txtMarime.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarime.Location = new System.Drawing.Point(150, 165);
            this.txtMarime.Name = "txtMarime";
            this.txtMarime.Size = new System.Drawing.Size(88, 25);
            this.txtMarime.TabIndex = 2;
            // 
            // txtPret
            // 
            this.txtPret.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPret.Location = new System.Drawing.Point(310, 165);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(92, 25);
            this.txtPret.TabIndex = 3;
            // 
            // btnImagine
            // 
            this.btnImagine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagine.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagine.ForeColor = System.Drawing.Color.White;
            this.btnImagine.Image = global::Magazin.Properties.Resources.backround_autentificare;
            this.btnImagine.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnImagine.Location = new System.Drawing.Point(443, 166);
            this.btnImagine.Name = "btnImagine";
            this.btnImagine.Size = new System.Drawing.Size(144, 49);
            this.btnImagine.TabIndex = 4;
            this.btnImagine.Text = "Încarcă imagine";
            this.btnImagine.UseVisualStyleBackColor = true;
            this.btnImagine.Click += new System.EventHandler(this.btnImagine_Click);
            // 
            // dgvProduse
            // 
            this.dgvProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProduse.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Location = new System.Drawing.Point(25, 53);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.ReadOnly = true;
            this.dgvProduse.RowHeadersWidth = 62;
            this.dgvProduse.RowTemplate.Height = 28;
            this.dgvProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduse.Size = new System.Drawing.Size(632, 382);
            this.dgvProduse.TabIndex = 5;
            this.dgvProduse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduse_CellClick);
            // 
            // gbProdus
            // 
            this.gbProdus.BackColor = System.Drawing.Color.White;
            this.gbProdus.Controls.Add(this.pbImagine);
            this.gbProdus.Controls.Add(this.lblPret);
            this.gbProdus.Controls.Add(this.lblMarime);
            this.gbProdus.Controls.Add(this.lblCategorie);
            this.gbProdus.Controls.Add(this.lblDenumire);
            this.gbProdus.Controls.Add(this.txtDenumire);
            this.gbProdus.Controls.Add(this.cmbCategorie);
            this.gbProdus.Controls.Add(this.btnImagine);
            this.gbProdus.Controls.Add(this.txtMarime);
            this.gbProdus.Controls.Add(this.txtPret);
            this.gbProdus.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProdus.Location = new System.Drawing.Point(48, 285);
            this.gbProdus.Name = "gbProdus";
            this.gbProdus.Size = new System.Drawing.Size(630, 229);
            this.gbProdus.TabIndex = 6;
            this.gbProdus.TabStop = false;
            this.gbProdus.Text = "Detalii produs";
            // 
            // pbImagine
            // 
            this.pbImagine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagine.Image = global::Magazin.Properties.Resources.logo_rotund;
            this.pbImagine.Location = new System.Drawing.Point(443, 31);
            this.pbImagine.Name = "pbImagine";
            this.pbImagine.Size = new System.Drawing.Size(144, 124);
            this.pbImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagine.TabIndex = 9;
            this.pbImagine.TabStop = false;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(255, 162);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(49, 26);
            this.lblPret.TabIndex = 8;
            this.lblPret.Text = "Preț";
            // 
            // lblMarime
            // 
            this.lblMarime.AutoSize = true;
            this.lblMarime.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarime.Location = new System.Drawing.Point(56, 162);
            this.lblMarime.Name = "lblMarime";
            this.lblMarime.Size = new System.Drawing.Size(83, 26);
            this.lblMarime.TabIndex = 7;
            this.lblMarime.Text = "Mărime";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(45, 101);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(99, 26);
            this.lblCategorie.TabIndex = 6;
            this.lblCategorie.Text = "Categorie";
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenumire.Location = new System.Drawing.Point(40, 49);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(104, 26);
            this.lblDenumire.TabIndex = 5;
            this.lblDenumire.Text = "Denumire";
            // 
            // gbActiuni
            // 
            this.gbActiuni.BackColor = System.Drawing.Color.White;
            this.gbActiuni.Controls.Add(this.lblCauta);
            this.gbActiuni.Controls.Add(this.txtCauta);
            this.gbActiuni.Controls.Add(this.btnModifica);
            this.gbActiuni.Controls.Add(this.btnSterge);
            this.gbActiuni.Controls.Add(this.btnAdauga);
            this.gbActiuni.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActiuni.Location = new System.Drawing.Point(48, 60);
            this.gbActiuni.Name = "gbActiuni";
            this.gbActiuni.Size = new System.Drawing.Size(630, 198);
            this.gbActiuni.TabIndex = 7;
            this.gbActiuni.TabStop = false;
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauta.Location = new System.Drawing.Point(56, 41);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(133, 26);
            this.lblCauta.TabIndex = 13;
            this.lblCauta.Text = "Caută produs";
            // 
            // txtCauta
            // 
            this.txtCauta.Location = new System.Drawing.Point(195, 44);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(392, 25);
            this.txtCauta.TabIndex = 12;
            this.txtCauta.TextChanged += new System.EventHandler(this.txtCauta_TextChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModifica.BackgroundImage")));
            this.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifica.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(422, 89);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(165, 80);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifică produs";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSterge.BackgroundImage")));
            this.btnSterge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSterge.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ForeColor = System.Drawing.Color.White;
            this.btnSterge.Location = new System.Drawing.Point(238, 89);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(164, 80);
            this.btnSterge.TabIndex = 1;
            this.btnSterge.Text = "Șterge produs";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdauga.BackgroundImage = global::Magazin.Properties.Resources.backround_autentificare;
            this.btnAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdauga.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.Color.White;
            this.btnAdauga.Location = new System.Drawing.Point(61, 89);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(163, 80);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adaugă produs";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::Magazin.Properties.Resources._return;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Location = new System.Drawing.Point(48, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(29, 30);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(14, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvComenzi
            // 
            this.dgvComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComenzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComenzi.BackgroundColor = System.Drawing.Color.White;
            this.dgvComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComenzi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComenzi.Location = new System.Drawing.Point(26, 53);
            this.dgvComenzi.Name = "dgvComenzi";
            this.dgvComenzi.ReadOnly = true;
            this.dgvComenzi.RowHeadersWidth = 62;
            this.dgvComenzi.RowTemplate.Height = 28;
            this.dgvComenzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComenzi.Size = new System.Drawing.Size(1086, 207);
            this.dgvComenzi.TabIndex = 10;
            // 
            // lblComenzi
            // 
            this.lblComenzi.AutoSize = true;
            this.lblComenzi.BackColor = System.Drawing.Color.White;
            this.lblComenzi.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComenzi.Location = new System.Drawing.Point(20, 18);
            this.lblComenzi.Name = "lblComenzi";
            this.lblComenzi.Size = new System.Drawing.Size(215, 32);
            this.lblComenzi.TabIndex = 10;
            this.lblComenzi.Text = "LISTĂ COMENZI";
            // 
            // lblStoc
            // 
            this.lblStoc.AutoSize = true;
            this.lblStoc.BackColor = System.Drawing.Color.White;
            this.lblStoc.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoc.Location = new System.Drawing.Point(19, 18);
            this.lblStoc.Name = "lblStoc";
            this.lblStoc.Size = new System.Drawing.Size(82, 32);
            this.lblStoc.TabIndex = 15;
            this.lblStoc.Text = "STOC";
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizare.BackgroundImage")));
            this.btnFinalizare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizare.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizare.ForeColor = System.Drawing.Color.White;
            this.btnFinalizare.Location = new System.Drawing.Point(1129, 164);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(177, 96);
            this.btnFinalizare.TabIndex = 14;
            this.btnFinalizare.Text = "Finalizare comandă";
            this.btnFinalizare.UseVisualStyleBackColor = true;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // gbStoc
            // 
            this.gbStoc.BackColor = System.Drawing.Color.White;
            this.gbStoc.Controls.Add(this.dgvProduse);
            this.gbStoc.Controls.Add(this.lblStoc);
            this.gbStoc.Location = new System.Drawing.Point(711, 60);
            this.gbStoc.Name = "gbStoc";
            this.gbStoc.Size = new System.Drawing.Size(673, 454);
            this.gbStoc.TabIndex = 16;
            this.gbStoc.TabStop = false;
            // 
            // gbComenzi
            // 
            this.gbComenzi.BackColor = System.Drawing.Color.White;
            this.gbComenzi.Controls.Add(this.btnStergeC);
            this.gbComenzi.Controls.Add(this.lblComenzi);
            this.gbComenzi.Controls.Add(this.dgvComenzi);
            this.gbComenzi.Controls.Add(this.btnFinalizare);
            this.gbComenzi.Location = new System.Drawing.Point(48, 549);
            this.gbComenzi.Name = "gbComenzi";
            this.gbComenzi.Size = new System.Drawing.Size(1336, 291);
            this.gbComenzi.TabIndex = 17;
            this.gbComenzi.TabStop = false;
            // 
            // btnStergeC
            // 
            this.btnStergeC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStergeC.BackgroundImage")));
            this.btnStergeC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergeC.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeC.ForeColor = System.Drawing.Color.White;
            this.btnStergeC.Location = new System.Drawing.Point(1129, 53);
            this.btnStergeC.Name = "btnStergeC";
            this.btnStergeC.Size = new System.Drawing.Size(177, 96);
            this.btnStergeC.TabIndex = 15;
            this.btnStergeC.Text = "Sterge comandă";
            this.btnStergeC.UseVisualStyleBackColor = true;
            this.btnStergeC.Click += new System.EventHandler(this.btnStergeC_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazin.Properties.Resources.Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 868);
            this.Controls.Add(this.gbComenzi);
            this.Controls.Add(this.gbStoc);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbActiuni);
            this.Controls.Add(this.gbProdus);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionare magazin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.gbProdus.ResumeLayout(false);
            this.gbProdus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagine)).EndInit();
            this.gbActiuni.ResumeLayout(false);
            this.gbActiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).EndInit();
            this.gbStoc.ResumeLayout(false);
            this.gbStoc.PerformLayout();
            this.gbComenzi.ResumeLayout(false);
            this.gbComenzi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtMarime;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnImagine;
        private System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.GroupBox gbProdus;
        private System.Windows.Forms.GroupBox gbActiuni;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblMarime;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.PictureBox pbImagine;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvComenzi;
        private System.Windows.Forms.Label lblComenzi;
        private System.Windows.Forms.Label lblStoc;
        private System.Windows.Forms.Button btnFinalizare;
        private System.Windows.Forms.GroupBox gbStoc;
        private System.Windows.Forms.GroupBox gbComenzi;
        private System.Windows.Forms.Button btnStergeC;
    }
}