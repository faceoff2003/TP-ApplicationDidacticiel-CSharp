namespace ApplicationDidacticiel2022Soulayman
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlIdentification = new System.Windows.Forms.Panel();
            this.btnVider = new System.Windows.Forms.Button();
            this.cbAfficherMotDePasse = new System.Windows.Forms.CheckBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.pnlIdentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIdentification
            // 
            this.pnlIdentification.Controls.Add(this.btnVider);
            this.pnlIdentification.Controls.Add(this.cbAfficherMotDePasse);
            this.pnlIdentification.Controls.Add(this.txtMotDePasse);
            this.pnlIdentification.Controls.Add(this.txtNomUtilisateur);
            this.pnlIdentification.Controls.Add(this.lblExit);
            this.pnlIdentification.Controls.Add(this.btnConnexion);
            this.pnlIdentification.Controls.Add(this.lblMotDePasse);
            this.pnlIdentification.Controls.Add(this.lblNomUtilisateur);
            this.pnlIdentification.Controls.Add(this.lblIdentification);
            this.pnlIdentification.Location = new System.Drawing.Point(138, 78);
            this.pnlIdentification.Name = "pnlIdentification";
            this.pnlIdentification.Size = new System.Drawing.Size(560, 443);
            this.pnlIdentification.TabIndex = 0;
            this.pnlIdentification.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIdentification_Paint);
            // 
            // btnVider
            // 
            this.btnVider.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnVider.Location = new System.Drawing.Point(44, 334);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(470, 37);
            this.btnVider.TabIndex = 8;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // cbAfficherMotDePasse
            // 
            this.cbAfficherMotDePasse.AutoSize = true;
            this.cbAfficherMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.cbAfficherMotDePasse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfficherMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.cbAfficherMotDePasse.Location = new System.Drawing.Point(143, 279);
            this.cbAfficherMotDePasse.Name = "cbAfficherMotDePasse";
            this.cbAfficherMotDePasse.Size = new System.Drawing.Size(294, 30);
            this.cbAfficherMotDePasse.TabIndex = 7;
            this.cbAfficherMotDePasse.Text = "Afficher le mot de passe";
            this.cbAfficherMotDePasse.UseVisualStyleBackColor = false;
            this.cbAfficherMotDePasse.CheckedChanged += new System.EventHandler(this.cbAfficherMotDePasse_CheckedChanged);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotDePasse.Location = new System.Drawing.Point(161, 224);
            this.txtMotDePasse.Multiline = true;
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '●';
            this.txtMotDePasse.Size = new System.Drawing.Size(258, 34);
            this.txtMotDePasse.TabIndex = 6;
            this.txtMotDePasse.Text = "Mot de passe";
            this.txtMotDePasse.Enter += new System.EventHandler(this.txtMotDePasse_Enter);
            this.txtMotDePasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotDePasse_KeyPress);
            this.txtMotDePasse.Leave += new System.EventHandler(this.txtMotDePasse_Leave);
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtNomUtilisateur.Location = new System.Drawing.Point(161, 135);
            this.txtNomUtilisateur.Multiline = true;
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(258, 34);
            this.txtNomUtilisateur.TabIndex = 5;
            this.txtNomUtilisateur.Text = "nom d\'utilisateur";
            this.txtNomUtilisateur.UseSystemPasswordChar = true;
            this.txtNomUtilisateur.Enter += new System.EventHandler(this.txtNomUtilisateur_Enter);
            this.txtNomUtilisateur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUtilisateur_KeyPress);
            this.txtNomUtilisateur.Leave += new System.EventHandler(this.txtNomUtilisateur_Leave);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExit.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblExit.Location = new System.Drawing.Point(510, 11);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(40, 39);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnConnexion.Location = new System.Drawing.Point(44, 377);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(470, 37);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lblMotDePasse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblMotDePasse.Location = new System.Drawing.Point(156, 184);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(153, 26);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblNomUtilisateur.Location = new System.Drawing.Point(156, 97);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(194, 26);
            this.lblNomUtilisateur.TabIndex = 1;
            this.lblNomUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentification.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblIdentification.Location = new System.Drawing.Point(107, 11);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(347, 65);
            this.lblIdentification.TabIndex = 0;
            this.lblIdentification.Text = "Identification";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.fonds_ecran_paysage_magnifique_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 618);
            this.Controls.Add(this.pnlIdentification);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlIdentification.ResumeLayout(false);
            this.pnlIdentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIdentification;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.CheckBox cbAfficherMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label lblIdentification;
    }

    partial class CopyOfFrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlIdentification = new System.Windows.Forms.Panel();
            this.btnVider = new System.Windows.Forms.Button();
            this.cbAfficherMotDePasse = new System.Windows.Forms.CheckBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.pnlIdentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIdentification
            // 
            this.pnlIdentification.Controls.Add(this.btnVider);
            this.pnlIdentification.Controls.Add(this.cbAfficherMotDePasse);
            this.pnlIdentification.Controls.Add(this.txtMotDePasse);
            this.pnlIdentification.Controls.Add(this.txtNomUtilisateur);
            this.pnlIdentification.Controls.Add(this.lblExit);
            this.pnlIdentification.Controls.Add(this.btnConnexion);
            this.pnlIdentification.Controls.Add(this.lblMotDePasse);
            this.pnlIdentification.Controls.Add(this.lblNomUtilisateur);
            this.pnlIdentification.Controls.Add(this.lblIdentification);
            this.pnlIdentification.Location = new System.Drawing.Point(138, 78);
            this.pnlIdentification.Name = "pnlIdentification";
            this.pnlIdentification.Size = new System.Drawing.Size(560, 443);
            this.pnlIdentification.TabIndex = 0;
            this.pnlIdentification.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIdentification_Paint);
            // 
            // btnVider
            // 
            this.btnVider.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnVider.Location = new System.Drawing.Point(44, 334);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(470, 37);
            this.btnVider.TabIndex = 8;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // cbAfficherMotDePasse
            // 
            this.cbAfficherMotDePasse.AutoSize = true;
            this.cbAfficherMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.cbAfficherMotDePasse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfficherMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.cbAfficherMotDePasse.Location = new System.Drawing.Point(143, 279);
            this.cbAfficherMotDePasse.Name = "cbAfficherMotDePasse";
            this.cbAfficherMotDePasse.Size = new System.Drawing.Size(294, 30);
            this.cbAfficherMotDePasse.TabIndex = 7;
            this.cbAfficherMotDePasse.Text = "Afficher le mot de passe";
            this.cbAfficherMotDePasse.UseVisualStyleBackColor = false;
            this.cbAfficherMotDePasse.CheckedChanged += new System.EventHandler(this.cbAfficherMotDePasse_CheckedChanged);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotDePasse.Location = new System.Drawing.Point(161, 224);
            this.txtMotDePasse.Multiline = true;
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '●';
            this.txtMotDePasse.Size = new System.Drawing.Size(258, 34);
            this.txtMotDePasse.TabIndex = 6;
            this.txtMotDePasse.Text = "Mot de passe";
            this.txtMotDePasse.Enter += new System.EventHandler(this.txtMotDePasse_Enter);
            this.txtMotDePasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotDePasse_KeyPress);
            this.txtMotDePasse.Leave += new System.EventHandler(this.txtMotDePasse_Leave);
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtNomUtilisateur.Location = new System.Drawing.Point(161, 135);
            this.txtNomUtilisateur.Multiline = true;
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(258, 34);
            this.txtNomUtilisateur.TabIndex = 5;
            this.txtNomUtilisateur.Text = "nom d\'utilisateur";
            this.txtNomUtilisateur.UseSystemPasswordChar = true;
            this.txtNomUtilisateur.Enter += new System.EventHandler(this.txtNomUtilisateur_Enter);
            this.txtNomUtilisateur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUtilisateur_KeyPress);
            this.txtNomUtilisateur.Leave += new System.EventHandler(this.txtNomUtilisateur_Leave);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExit.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblExit.Location = new System.Drawing.Point(510, 11);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(40, 39);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnConnexion.Location = new System.Drawing.Point(44, 377);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(470, 37);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lblMotDePasse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblMotDePasse.Location = new System.Drawing.Point(156, 184);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(153, 26);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblNomUtilisateur.Location = new System.Drawing.Point(156, 97);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(194, 26);
            this.lblNomUtilisateur.TabIndex = 1;
            this.lblNomUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentification.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblIdentification.Location = new System.Drawing.Point(107, 11);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(347, 65);
            this.lblIdentification.TabIndex = 0;
            this.lblIdentification.Text = "Identification";
            // 
            // CopyOfFrmLogin
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.fonds_ecran_paysage_magnifique_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 618);
            this.Controls.Add(this.pnlIdentification);
            this.Name = "CopyOfFrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlIdentification.ResumeLayout(false);
            this.pnlIdentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIdentification;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.CheckBox cbAfficherMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label lblIdentification;
    }
}

