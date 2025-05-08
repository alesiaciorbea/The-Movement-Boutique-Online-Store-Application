namespace Magazin
{
    partial class CosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CosForm));
            this.btnComana = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvComenzi = new System.Windows.Forms.DataGridView();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.gbPlata = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExpres = new System.Windows.Forms.CheckBox();
            this.chkStandard = new System.Windows.Forms.CheckBox();
            this.lblLivrare = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStrada = new System.Windows.Forms.Label();
            this.lblLocalitate = new System.Windows.Forms.Label();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.txtStrada = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNumerar = new System.Windows.Forms.CheckBox();
            this.chkCard = new System.Windows.Forms.CheckBox();
            this.lblPlata = new System.Windows.Forms.Label();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).BeginInit();
            this.gbPlata.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComana
            // 
            this.btnComana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnComana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComana.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComana.Location = new System.Drawing.Point(1097, 400);
            this.btnComana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComana.Name = "btnComana";
            this.btnComana.Size = new System.Drawing.Size(268, 60);
            this.btnComana.TabIndex = 1;
            this.btnComana.Text = "Finalizare comandă";
            this.btnComana.UseVisualStyleBackColor = false;
            this.btnComana.Click += new System.EventHandler(this.btnComana_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAnuleaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnuleaza.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuleaza.Location = new System.Drawing.Point(43, 474);
            this.btnAnuleaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(248, 43);
            this.btnAnuleaza.TabIndex = 2;
            this.btnAnuleaza.Text = "Anulează comanda";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::Magazin.Properties.Resources._return;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Location = new System.Drawing.Point(43, 14);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(25, 26);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.BackgroundImage = global::Magazin.Properties.Resources.x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(13, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvComenzi
            // 
            this.dgvComenzi.AllowUserToAddRows = false;
            this.dgvComenzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComenzi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComenzi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComenzi.Location = new System.Drawing.Point(43, 146);
            this.dgvComenzi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvComenzi.Name = "dgvComenzi";
            this.dgvComenzi.ReadOnly = true;
            this.dgvComenzi.RowTemplate.Height = 28;
            this.dgvComenzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComenzi.Size = new System.Drawing.Size(768, 311);
            this.dgvComenzi.TabIndex = 6;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(560, 58);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(298, 50);
            this.lblTitlu.TabIndex = 7;
            this.lblTitlu.Text = "COMANDA TA";
            // 
            // gbPlata
            // 
            this.gbPlata.Controls.Add(this.lblTotal);
            this.gbPlata.Controls.Add(this.lblSTotal);
            this.gbPlata.Location = new System.Drawing.Point(829, 400);
            this.gbPlata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlata.Name = "gbPlata";
            this.gbPlata.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPlata.Size = new System.Drawing.Size(244, 57);
            this.gbPlata.TabIndex = 8;
            this.gbPlata.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(101, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 26);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = " ";
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.Location = new System.Drawing.Point(22, 18);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(64, 26);
            this.lblSTotal.TabIndex = 0;
            this.lblSTotal.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExpres);
            this.groupBox1.Controls.Add(this.chkStandard);
            this.groupBox1.Controls.Add(this.lblLivrare);
            this.groupBox1.Location = new System.Drawing.Point(1097, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // chkExpres
            // 
            this.chkExpres.AutoSize = true;
            this.chkExpres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExpres.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExpres.Location = new System.Drawing.Point(42, 81);
            this.chkExpres.Name = "chkExpres";
            this.chkExpres.Size = new System.Drawing.Size(186, 26);
            this.chkExpres.TabIndex = 2;
            this.chkExpres.Text = "Livrare expres - 35 lei";
            this.chkExpres.UseVisualStyleBackColor = true;
            this.chkExpres.CheckedChanged += new System.EventHandler(this.chkExpres_CheckedChanged);
            // 
            // chkStandard
            // 
            this.chkStandard.AutoSize = true;
            this.chkStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStandard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStandard.Location = new System.Drawing.Point(42, 49);
            this.chkStandard.Name = "chkStandard";
            this.chkStandard.Size = new System.Drawing.Size(204, 26);
            this.chkStandard.TabIndex = 1;
            this.chkStandard.Text = "Livrare standard - 15 lei";
            this.chkStandard.UseVisualStyleBackColor = true;
            this.chkStandard.CheckedChanged += new System.EventHandler(this.chkStandard_CheckedChanged);
            // 
            // lblLivrare
            // 
            this.lblLivrare.AutoSize = true;
            this.lblLivrare.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivrare.Location = new System.Drawing.Point(16, 18);
            this.lblLivrare.Name = "lblLivrare";
            this.lblLivrare.Size = new System.Drawing.Size(217, 28);
            this.lblLivrare.TabIndex = 0;
            this.lblLivrare.Text = "Modalitate de livrare";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStrada);
            this.groupBox2.Controls.Add(this.lblLocalitate);
            this.groupBox2.Controls.Add(this.txtLocalitate);
            this.groupBox2.Controls.Add(this.txtStrada);
            this.groupBox2.Controls.Add(this.lblAdresa);
            this.groupBox2.Location = new System.Drawing.Point(829, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblStrada
            // 
            this.lblStrada.AutoSize = true;
            this.lblStrada.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrada.Location = new System.Drawing.Point(248, 53);
            this.lblStrada.Name = "lblStrada";
            this.lblStrada.Size = new System.Drawing.Size(80, 21);
            this.lblStrada.TabIndex = 9;
            this.lblStrada.Text = "Stradă/Nr";
            // 
            // lblLocalitate
            // 
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalitate.Location = new System.Drawing.Point(23, 53);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(77, 21);
            this.lblLocalitate.TabIndex = 8;
            this.lblLocalitate.Text = "Localitate";
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalitate.Location = new System.Drawing.Point(106, 49);
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(126, 29);
            this.txtLocalitate.TabIndex = 7;
            this.txtLocalitate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocalitate_KeyDown);
            // 
            // txtStrada
            // 
            this.txtStrada.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrada.Location = new System.Drawing.Point(330, 49);
            this.txtStrada.Name = "txtStrada";
            this.txtStrada.Size = new System.Drawing.Size(182, 29);
            this.txtStrada.TabIndex = 6;
            this.txtStrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStrada_KeyDown);
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.Location = new System.Drawing.Point(16, 18);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(178, 28);
            this.lblAdresa.TabIndex = 5;
            this.lblAdresa.Text = "Adresa de livrare";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNumerar);
            this.groupBox3.Controls.Add(this.chkCard);
            this.groupBox3.Controls.Add(this.lblPlata);
            this.groupBox3.Location = new System.Drawing.Point(829, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 126);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // chkNumerar
            // 
            this.chkNumerar.AutoSize = true;
            this.chkNumerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNumerar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumerar.Location = new System.Drawing.Point(42, 81);
            this.chkNumerar.Name = "chkNumerar";
            this.chkNumerar.Size = new System.Drawing.Size(97, 26);
            this.chkNumerar.TabIndex = 2;
            this.chkNumerar.Text = "Numerar";
            this.chkNumerar.UseVisualStyleBackColor = true;
            this.chkNumerar.CheckedChanged += new System.EventHandler(this.chkNumerar_CheckedChanged);
            // 
            // chkCard
            // 
            this.chkCard.AutoSize = true;
            this.chkCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCard.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCard.Location = new System.Drawing.Point(42, 49);
            this.chkCard.Name = "chkCard";
            this.chkCard.Size = new System.Drawing.Size(66, 26);
            this.chkCard.TabIndex = 1;
            this.chkCard.Text = "Card";
            this.chkCard.UseVisualStyleBackColor = true;
            this.chkCard.CheckedChanged += new System.EventHandler(this.chkCard_CheckedChanged);
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlata.Location = new System.Drawing.Point(16, 18);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(202, 28);
            this.lblPlata.TabIndex = 0;
            this.lblPlata.Text = "Modalitate de plata";
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSterge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSterge.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(563, 474);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(248, 44);
            this.btnSterge.TabIndex = 11;
            this.btnSterge.Text = "Sterge produs";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // CosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Magazin.Properties.Resources.Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1414, 594);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPlata);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.dgvComenzi);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnComana);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coș de cumpărături";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComenzi)).EndInit();
            this.gbPlata.ResumeLayout(false);
            this.gbPlata.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComana;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvComenzi;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.GroupBox gbPlata;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLivrare;
        private System.Windows.Forms.CheckBox chkExpres;
        private System.Windows.Forms.CheckBox chkStandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStrada;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkNumerar;
        private System.Windows.Forms.CheckBox chkCard;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.TextBox txtLocalitate;
        private System.Windows.Forms.Label lblStrada;
        private System.Windows.Forms.Label lblLocalitate;
        private System.Windows.Forms.Label lblTotal;
    }
}