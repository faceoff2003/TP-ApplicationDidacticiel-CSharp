namespace ApplicationDidacticiel2022Soulayman
{
    partial class FrmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz));
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnAutre = new System.Windows.Forms.Button();
            this.btnTestes = new System.Windows.Forms.Button();
            this.btnAjouterDesQuestions = new System.Windows.Forms.Button();
            this.btnAjouterUnUtilisateur = new System.Windows.Forms.Button();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lstReponses = new System.Windows.Forms.ListBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.grbAffichageQuestion = new System.Windows.Forms.GroupBox();
            this.radReponse4 = new System.Windows.Forms.RadioButton();
            this.radRep3 = new System.Windows.Forms.RadioButton();
            this.radRep2 = new System.Windows.Forms.RadioButton();
            this.radRep1 = new System.Windows.Forms.RadioButton();
            this.lstAfficherListeQuestionAleatoireTest = new System.Windows.Forms.ListBox();
            this.lstAffichageNombreAleatoireTest = new System.Windows.Forms.ListBox();
            this.lstAffichage = new System.Windows.Forms.ListBox();
            this.btnRAZFichier = new System.Windows.Forms.Button();
            this.btnValiderReponse = new System.Windows.Forms.Button();
            this.btnDebuterDidacticiel = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.tmrCompteur = new System.Windows.Forms.Timer(this.components);
            this.PnlBackground = new System.Windows.Forms.Panel();
            this.pnlProgresse = new System.Windows.Forms.Panel();
            this.lstAfficherReponse = new System.Windows.Forms.ListBox();
            this.pibAffichageImage = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlTitre.SuspendLayout();
            this.grbAffichageQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAffichageImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(0, 31);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(1102, 63);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Questionnaire";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnDeconnecter);
            this.pnlMenu.Controls.Add(this.btnAutre);
            this.pnlMenu.Controls.Add(this.btnTestes);
            this.pnlMenu.Controls.Add(this.btnAjouterDesQuestions);
            this.pnlMenu.Controls.Add(this.btnAjouterUnUtilisateur);
            this.pnlMenu.Location = new System.Drawing.Point(1, 116);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(257, 629);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDeconnecter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeconnecter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnecter.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeconnecter.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.Deconnexion;
            this.btnDeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnecter.Location = new System.Drawing.Point(0, 320);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(257, 80);
            this.btnDeconnecter.TabIndex = 5;
            this.btnDeconnecter.Text = "Déconnecter";
            this.btnDeconnecter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeconnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeconnecter.UseVisualStyleBackColor = false;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // btnAutre
            // 
            this.btnAutre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAutre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutre.FlatAppearance.BorderSize = 0;
            this.btnAutre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutre.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutre.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAutre.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.rapportQuestionniares;
            this.btnAutre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutre.Location = new System.Drawing.Point(0, 240);
            this.btnAutre.Name = "btnAutre";
            this.btnAutre.Size = new System.Drawing.Size(257, 80);
            this.btnAutre.TabIndex = 4;
            this.btnAutre.Text = "Rapport des questionnaires";
            this.btnAutre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutre.UseVisualStyleBackColor = false;
            // 
            // btnTestes
            // 
            this.btnTestes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTestes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestes.FlatAppearance.BorderSize = 0;
            this.btnTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestes.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTestes.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.TesterDidac;
            this.btnTestes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestes.Location = new System.Drawing.Point(0, 160);
            this.btnTestes.Name = "btnTestes";
            this.btnTestes.Size = new System.Drawing.Size(257, 80);
            this.btnTestes.TabIndex = 3;
            this.btnTestes.Text = "Tester le Didacticiel";
            this.btnTestes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestes.UseVisualStyleBackColor = false;
            this.btnTestes.Click += new System.EventHandler(this.btnTestes_Click);
            // 
            // btnAjouterDesQuestions
            // 
            this.btnAjouterDesQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAjouterDesQuestions.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAjouterDesQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjouterDesQuestions.FlatAppearance.BorderSize = 0;
            this.btnAjouterDesQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDesQuestions.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDesQuestions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAjouterDesQuestions.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.Questions;
            this.btnAjouterDesQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterDesQuestions.Location = new System.Drawing.Point(0, 80);
            this.btnAjouterDesQuestions.Name = "btnAjouterDesQuestions";
            this.btnAjouterDesQuestions.Size = new System.Drawing.Size(257, 80);
            this.btnAjouterDesQuestions.TabIndex = 2;
            this.btnAjouterDesQuestions.Text = "Gestion des Questions";
            this.btnAjouterDesQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterDesQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterDesQuestions.UseVisualStyleBackColor = false;
            this.btnAjouterDesQuestions.Click += new System.EventHandler(this.btnAjouterDesQuestions_Click);
            // 
            // btnAjouterUnUtilisateur
            // 
            this.btnAjouterUnUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAjouterUnUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjouterUnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnAjouterUnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterUnUtilisateur.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterUnUtilisateur.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAjouterUnUtilisateur.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.new_add_user_16734;
            this.btnAjouterUnUtilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterUnUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.btnAjouterUnUtilisateur.Name = "btnAjouterUnUtilisateur";
            this.btnAjouterUnUtilisateur.Size = new System.Drawing.Size(257, 80);
            this.btnAjouterUnUtilisateur.TabIndex = 1;
            this.btnAjouterUnUtilisateur.Text = "Gestion des Utilisateurs";
            this.btnAjouterUnUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterUnUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterUnUtilisateur.UseVisualStyleBackColor = false;
            this.btnAjouterUnUtilisateur.Click += new System.EventHandler(this.btnAjouterUnUtilisateur_Click);
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitre.Controls.Add(this.lblTitre);
            this.pnlTitre.Controls.Add(this.lstReponses);
            this.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitre.Location = new System.Drawing.Point(258, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1118, 118);
            this.pnlTitre.TabIndex = 5;
            // 
            // lstReponses
            // 
            this.lstReponses.FormattingEnabled = true;
            this.lstReponses.ItemHeight = 16;
            this.lstReponses.Location = new System.Drawing.Point(885, 31);
            this.lstReponses.Name = "lstReponses";
            this.lstReponses.Size = new System.Drawing.Size(97, 52);
            this.lstReponses.TabIndex = 19;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(258, 745);
            this.pnlLogo.TabIndex = 4;
            // 
            // grbAffichageQuestion
            // 
            this.grbAffichageQuestion.Controls.Add(this.radReponse4);
            this.grbAffichageQuestion.Controls.Add(this.radRep3);
            this.grbAffichageQuestion.Controls.Add(this.radRep2);
            this.grbAffichageQuestion.Controls.Add(this.radRep1);
            this.grbAffichageQuestion.Location = new System.Drawing.Point(345, 533);
            this.grbAffichageQuestion.Name = "grbAffichageQuestion";
            this.grbAffichageQuestion.Size = new System.Drawing.Size(930, 182);
            this.grbAffichageQuestion.TabIndex = 12;
            this.grbAffichageQuestion.TabStop = false;
            this.grbAffichageQuestion.Text = "groupBox1";
            // 
            // radReponse4
            // 
            this.radReponse4.AutoSize = true;
            this.radReponse4.Location = new System.Drawing.Point(44, 200);
            this.radReponse4.Name = "radReponse4";
            this.radReponse4.Size = new System.Drawing.Size(17, 16);
            this.radReponse4.TabIndex = 3;
            this.radReponse4.TabStop = true;
            this.radReponse4.UseVisualStyleBackColor = true;
            // 
            // radRep3
            // 
            this.radRep3.AutoSize = true;
            this.radRep3.Location = new System.Drawing.Point(44, 149);
            this.radRep3.Name = "radRep3";
            this.radRep3.Size = new System.Drawing.Size(17, 16);
            this.radRep3.TabIndex = 2;
            this.radRep3.TabStop = true;
            this.radRep3.UseVisualStyleBackColor = true;
            // 
            // radRep2
            // 
            this.radRep2.AutoSize = true;
            this.radRep2.Location = new System.Drawing.Point(44, 97);
            this.radRep2.Name = "radRep2";
            this.radRep2.Size = new System.Drawing.Size(17, 16);
            this.radRep2.TabIndex = 1;
            this.radRep2.TabStop = true;
            this.radRep2.UseVisualStyleBackColor = true;
            // 
            // radRep1
            // 
            this.radRep1.AutoSize = true;
            this.radRep1.Location = new System.Drawing.Point(44, 52);
            this.radRep1.Name = "radRep1";
            this.radRep1.Size = new System.Drawing.Size(17, 16);
            this.radRep1.TabIndex = 0;
            this.radRep1.TabStop = true;
            this.radRep1.UseVisualStyleBackColor = true;
            // 
            // lstAfficherListeQuestionAleatoireTest
            // 
            this.lstAfficherListeQuestionAleatoireTest.FormattingEnabled = true;
            this.lstAfficherListeQuestionAleatoireTest.ItemHeight = 16;
            this.lstAfficherListeQuestionAleatoireTest.Location = new System.Drawing.Point(801, 333);
            this.lstAfficherListeQuestionAleatoireTest.Name = "lstAfficherListeQuestionAleatoireTest";
            this.lstAfficherListeQuestionAleatoireTest.Size = new System.Drawing.Size(550, 68);
            this.lstAfficherListeQuestionAleatoireTest.TabIndex = 3;
            // 
            // lstAffichageNombreAleatoireTest
            // 
            this.lstAffichageNombreAleatoireTest.FormattingEnabled = true;
            this.lstAffichageNombreAleatoireTest.ItemHeight = 16;
            this.lstAffichageNombreAleatoireTest.Location = new System.Drawing.Point(801, 240);
            this.lstAffichageNombreAleatoireTest.Name = "lstAffichageNombreAleatoireTest";
            this.lstAffichageNombreAleatoireTest.Size = new System.Drawing.Size(550, 68);
            this.lstAffichageNombreAleatoireTest.TabIndex = 2;
            // 
            // lstAffichage
            // 
            this.lstAffichage.FormattingEnabled = true;
            this.lstAffichage.ItemHeight = 16;
            this.lstAffichage.Location = new System.Drawing.Point(801, 150);
            this.lstAffichage.Name = "lstAffichage";
            this.lstAffichage.Size = new System.Drawing.Size(550, 68);
            this.lstAffichage.TabIndex = 1;
            // 
            // btnRAZFichier
            // 
            this.btnRAZFichier.Location = new System.Drawing.Point(939, 482);
            this.btnRAZFichier.Name = "btnRAZFichier";
            this.btnRAZFichier.Size = new System.Drawing.Size(178, 34);
            this.btnRAZFichier.TabIndex = 8;
            this.btnRAZFichier.Text = "Raz fichier";
            this.btnRAZFichier.UseVisualStyleBackColor = true;
            this.btnRAZFichier.Click += new System.EventHandler(this.btnRAZFichier_Click);
            // 
            // btnValiderReponse
            // 
            this.btnValiderReponse.Location = new System.Drawing.Point(1161, 482);
            this.btnValiderReponse.Name = "btnValiderReponse";
            this.btnValiderReponse.Size = new System.Drawing.Size(178, 34);
            this.btnValiderReponse.TabIndex = 15;
            this.btnValiderReponse.Text = "Valider la réponse";
            this.btnValiderReponse.UseVisualStyleBackColor = true;
            this.btnValiderReponse.Click += new System.EventHandler(this.btnValiderReponse_Click);
            // 
            // btnDebuterDidacticiel
            // 
            this.btnDebuterDidacticiel.Location = new System.Drawing.Point(292, 134);
            this.btnDebuterDidacticiel.Name = "btnDebuterDidacticiel";
            this.btnDebuterDidacticiel.Size = new System.Drawing.Size(178, 34);
            this.btnDebuterDidacticiel.TabIndex = 14;
            this.btnDebuterDidacticiel.Text = "Dibuter Questionnaire";
            this.btnDebuterDidacticiel.UseVisualStyleBackColor = true;
            this.btnDebuterDidacticiel.Click += new System.EventHandler(this.btnDebuterDidacticiel_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(345, 482);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(100, 22);
            this.txtLogin.TabIndex = 16;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(460, 482);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.ReadOnly = true;
            this.txtMotDePasse.Size = new System.Drawing.Size(100, 22);
            this.txtMotDePasse.TabIndex = 17;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(575, 482);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(100, 22);
            this.txtPoints.TabIndex = 18;
            // 
            // tmrCompteur
            // 
            this.tmrCompteur.Interval = 50;
            this.tmrCompteur.Tick += new System.EventHandler(this.tmrCompteur_Tick);
            // 
            // PnlBackground
            // 
            this.PnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PnlBackground.Location = new System.Drawing.Point(258, 730);
            this.PnlBackground.Name = "PnlBackground";
            this.PnlBackground.Size = new System.Drawing.Size(1118, 15);
            this.PnlBackground.TabIndex = 20;
            // 
            // pnlProgresse
            // 
            this.pnlProgresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlProgresse.Location = new System.Drawing.Point(258, 730);
            this.pnlProgresse.Name = "pnlProgresse";
            this.pnlProgresse.Size = new System.Drawing.Size(22, 15);
            this.pnlProgresse.TabIndex = 21;
            // 
            // lstAfficherReponse
            // 
            this.lstAfficherReponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lstAfficherReponse.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAfficherReponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lstAfficherReponse.FormattingEnabled = true;
            this.lstAfficherReponse.ItemHeight = 22;
            this.lstAfficherReponse.Location = new System.Drawing.Point(684, 124);
            this.lstAfficherReponse.Name = "lstAfficherReponse";
            this.lstAfficherReponse.Size = new System.Drawing.Size(680, 334);
            this.lstAfficherReponse.TabIndex = 4;
            // 
            // pibAffichageImage
            // 
            this.pibAffichageImage.Location = new System.Drawing.Point(292, 208);
            this.pibAffichageImage.Name = "pibAffichageImage";
            this.pibAffichageImage.Size = new System.Drawing.Size(319, 228);
            this.pibAffichageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibAffichageImage.TabIndex = 13;
            this.pibAffichageImage.TabStop = false;
            // 
            // FrmQuiz
            // 
            this.AcceptButton = this.btnValiderReponse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDeconnecter;
            this.ClientSize = new System.Drawing.Size(1376, 745);
            this.Controls.Add(this.lstAfficherReponse);
            this.Controls.Add(this.pnlProgresse);
            this.Controls.Add(this.PnlBackground);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pibAffichageImage);
            this.Controls.Add(this.grbAffichageQuestion);
            this.Controls.Add(this.lstAfficherListeQuestionAleatoireTest);
            this.Controls.Add(this.lstAffichageNombreAleatoireTest);
            this.Controls.Add(this.lstAffichage);
            this.Controls.Add(this.btnRAZFichier);
            this.Controls.Add(this.btnValiderReponse);
            this.Controls.Add(this.btnDebuterDidacticiel);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Didacticiel";
            this.Load += new System.EventHandler(this.AdminTestes_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitre.ResumeLayout(false);
            this.grbAffichageQuestion.ResumeLayout(false);
            this.grbAffichageQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibAffichageImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button btnAutre;
        private System.Windows.Forms.Button btnTestes;
        private System.Windows.Forms.Button btnAjouterDesQuestions;
        private System.Windows.Forms.Button btnAjouterUnUtilisateur;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pibAffichageImage;
        private System.Windows.Forms.GroupBox grbAffichageQuestion;
        private System.Windows.Forms.RadioButton radReponse4;
        private System.Windows.Forms.RadioButton radRep3;
        private System.Windows.Forms.RadioButton radRep2;
        private System.Windows.Forms.RadioButton radRep1;
        private System.Windows.Forms.ListBox lstAfficherListeQuestionAleatoireTest;
        private System.Windows.Forms.ListBox lstAffichageNombreAleatoireTest;
        private System.Windows.Forms.ListBox lstAffichage;
        private System.Windows.Forms.Button btnRAZFichier;
        private System.Windows.Forms.Button btnValiderReponse;
        private System.Windows.Forms.Button btnDebuterDidacticiel;
        public System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.ListBox lstReponses;
        private System.Windows.Forms.Panel PnlBackground;
        private System.Windows.Forms.Panel pnlProgresse;
        private System.Windows.Forms.Timer tmrCompteur;
        private System.Windows.Forms.ListBox lstAfficherReponse;
    }
}