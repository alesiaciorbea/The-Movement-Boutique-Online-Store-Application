namespace Magazin
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.chkParola = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblAut = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkParola
            // 
            this.chkParola.BackColor = System.Drawing.Color.Transparent;
            this.chkParola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkParola.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParola.ForeColor = System.Drawing.Color.White;
            this.chkParola.Location = new System.Drawing.Point(274, 619);
            this.chkParola.Margin = new System.Windows.Forms.Padding(4);
            this.chkParola.Name = "chkParola";
            this.chkParola.Size = new System.Drawing.Size(195, 31);
            this.chkParola.TabIndex = 2;
            this.chkParola.Text = "Afișează parola";
            this.chkParola.UseVisualStyleBackColor = false;
            this.chkParola.CheckedChanged += new System.EventHandler(this.chkParola_CheckedChanged);
            this.chkParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkParola_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(84, 673);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(363, 66);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Autentificare";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(84, 567);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(363, 44);
            this.txtParola.TabIndex = 4;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParola_KeyDown);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Image = global::Magazin.Properties.Resources.logo_rotund;
            this.pbLogo.Location = new System.Drawing.Point(198, 37);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.MaximumSize = new System.Drawing.Size(163, 160);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(140, 140);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // lblParola
            // 
            this.lblParola.BackColor = System.Drawing.Color.Transparent;
            this.lblParola.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(83, 529);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(138, 34);
            this.lblParola.TabIndex = 7;
            this.lblParola.Text = "PAROLĂ";
            // 
            // lblAut
            // 
            this.lblAut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAut.BackColor = System.Drawing.Color.Transparent;
            this.lblAut.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAut.ForeColor = System.Drawing.Color.White;
            this.lblAut.Location = new System.Drawing.Point(95, 241);
            this.lblAut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAut.Name = "lblAut";
            this.lblAut.Size = new System.Drawing.Size(338, 63);
            this.lblAut.TabIndex = 8;
            this.lblAut.Text = "AUTENTIFICARE";
            this.lblAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(83, 423);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(111, 36);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(84, 463);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 44);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblNume
            // 
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.White;
            this.lblNume.Location = new System.Drawing.Point(86, 309);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(123, 29);
            this.lblNume.TabIndex = 12;
            this.lblNume.Text = "NUME";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(84, 351);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(363, 44);
            this.txtNume.TabIndex = 11;
            this.txtNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.BackgroundImage = global::Magazin.Properties.Resources.x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(125, 7);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(287, 32);
            this.lblLogo.TabIndex = 14;
            this.lblLogo.Text = "The Movement Boutique";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Location = new System.Drawing.Point(-5, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 44);
            this.panel1.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Magazin.Properties.Resources.backround_autentificare;
            this.ClientSize = new System.Drawing.Size(534, 796);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAut);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkParola);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkParola;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblAut;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panel1;
    }
}

