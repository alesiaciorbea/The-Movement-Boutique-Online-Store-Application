namespace Magazin
{
    partial class CardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
            this.lblNr = new System.Windows.Forms.Label();
            this.gbCard = new System.Windows.Forms.GroupBox();
            this.btnPlata = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.Location = new System.Drawing.Point(30, 16);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(160, 26);
            this.lblNr.TabIndex = 0;
            this.lblNr.Text = "Numărul cardului";
            // 
            // gbCard
            // 
            this.gbCard.BackColor = System.Drawing.Color.White;
            this.gbCard.Controls.Add(this.btnPlata);
            this.gbCard.Controls.Add(this.txtCod);
            this.gbCard.Controls.Add(this.label4);
            this.gbCard.Controls.Add(this.txtAn);
            this.gbCard.Controls.Add(this.label3);
            this.gbCard.Controls.Add(this.txtLuna);
            this.gbCard.Controls.Add(this.label2);
            this.gbCard.Controls.Add(this.txtNume);
            this.gbCard.Controls.Add(this.label1);
            this.gbCard.Controls.Add(this.txtNumar);
            this.gbCard.Controls.Add(this.lblNr);
            this.gbCard.Location = new System.Drawing.Point(51, 74);
            this.gbCard.Name = "gbCard";
            this.gbCard.Size = new System.Drawing.Size(343, 371);
            this.gbCard.TabIndex = 1;
            this.gbCard.TabStop = false;
            this.gbCard.Text = " ";
            // 
            // btnPlata
            // 
            this.btnPlata.BackgroundImage = global::Magazin.Properties.Resources.backround_autentificare;
            this.btnPlata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlata.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlata.ForeColor = System.Drawing.Color.White;
            this.btnPlata.Location = new System.Drawing.Point(35, 306);
            this.btnPlata.Name = "btnPlata";
            this.btnPlata.Size = new System.Drawing.Size(282, 45);
            this.btnPlata.TabIndex = 10;
            this.btnPlata.Text = "Plătește";
            this.btnPlata.UseVisualStyleBackColor = true;
            this.btnPlata.Click += new System.EventHandler(this.btnPlata_Click);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(35, 257);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(122, 28);
            this.txtCod.TabIndex = 9;
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVC/CVV2";
            // 
            // txtAn
            // 
            this.txtAn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAn.Location = new System.Drawing.Point(184, 187);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(122, 28);
            this.txtAn.TabIndex = 7;
            this.txtAn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAn_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "An expirare";
            // 
            // txtLuna
            // 
            this.txtLuna.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuna.Location = new System.Drawing.Point(36, 187);
            this.txtLuna.Name = "txtLuna";
            this.txtLuna.Size = new System.Drawing.Size(122, 28);
            this.txtLuna.TabIndex = 5;
            this.txtLuna.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLuna_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lună expirare";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(35, 116);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(271, 28);
            this.txtNume.TabIndex = 3;
            this.txtNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume titular card";
            // 
            // txtNumar
            // 
            this.txtNumar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumar.Location = new System.Drawing.Point(35, 45);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(271, 28);
            this.txtNumar.TabIndex = 1;
            this.txtNumar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumar_KeyDown);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::Magazin.Properties.Resources._return;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Location = new System.Drawing.Point(12, 11);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(25, 26);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazin.Properties.Resources.Backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 506);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date card";
            this.gbCard.ResumeLayout(false);
            this.gbCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.GroupBox gbCard;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.Button btnPlata;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
    }
}