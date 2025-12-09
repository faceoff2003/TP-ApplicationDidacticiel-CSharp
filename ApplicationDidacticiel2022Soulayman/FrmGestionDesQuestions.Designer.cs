namespace ApplicationDidacticiel2022Soulayman
{
    partial class FrmGestionDesQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDesQuestions));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.btnRapportDesQuestions = new System.Windows.Forms.Button();
            this.btnTestes = new System.Windows.Forms.Button();
            this.btnAjouterDesQuestions = new System.Windows.Forms.Button();
            this.btnAjouterUnUtilisateur = new System.Windows.Forms.Button();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.grbAjoutQuestion = new System.Windows.Forms.GroupBox();
            this.lblChampsObligatoires = new System.Windows.Forms.Label();
            this.txtCache = new System.Windows.Forms.TextBox();
            this.btnSuppression = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.lblSucce = new System.Windows.Forms.Label();
            this.pibImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.txtBonneReponse = new System.Windows.Forms.TextBox();
            this.txtReponse3 = new System.Windows.Forms.TextBox();
            this.txtReponse2 = new System.Windows.Forms.TextBox();
            this.txtReponse1 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblBonneReponse = new System.Windows.Forms.Label();
            this.lblReponse3 = new System.Windows.Forms.Label();
            this.lblReponse2 = new System.Windows.Forms.Label();
            this.lblReponse1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnNouvelleQuestion = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlTitre.SuspendLayout();
            this.grbAjoutQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnDeconnecter);
            this.pnlMenu.Controls.Add(this.btnRapportDesQuestions);
            this.pnlMenu.Controls.Add(this.btnTestes);
            this.pnlMenu.Controls.Add(this.btnAjouterDesQuestions);
            this.pnlMenu.Controls.Add(this.btnAjouterUnUtilisateur);
            this.pnlMenu.Location = new System.Drawing.Point(1, 103);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(257, 662);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            // btnRapportDesQuestions
            // 
            this.btnRapportDesQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRapportDesQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRapportDesQuestions.FlatAppearance.BorderSize = 0;
            this.btnRapportDesQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapportDesQuestions.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapportDesQuestions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRapportDesQuestions.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.rapportQuestionniares;
            this.btnRapportDesQuestions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapportDesQuestions.Location = new System.Drawing.Point(0, 240);
            this.btnRapportDesQuestions.Name = "btnRapportDesQuestions";
            this.btnRapportDesQuestions.Size = new System.Drawing.Size(257, 80);
            this.btnRapportDesQuestions.TabIndex = 4;
            this.btnRapportDesQuestions.Text = "Rapport des questionnaires";
            this.btnRapportDesQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapportDesQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRapportDesQuestions.UseVisualStyleBackColor = false;
            this.btnRapportDesQuestions.Click += new System.EventHandler(this.btnRapportDesQuestions_Click);
            // 
            // btnTestes
            // 
            this.btnTestes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTestes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestes.FlatAppearance.BorderSize = 0;
            this.btnTestes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestes.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTestes.Image = global::ApplicationDidacticiel2022Soulayman.Properties.Resources.new_add_user_16734;
            this.btnTestes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestes.Location = new System.Drawing.Point(0, 160);
            this.btnTestes.Name = "btnTestes";
            this.btnTestes.Size = new System.Drawing.Size(257, 80);
            this.btnTestes.TabIndex = 3;
            this.btnTestes.Text = "Tester le Didacticiel";
            this.btnTestes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestes.UseVisualStyleBackColor = false;
            this.btnTestes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAjouterDesQuestions
            // 
            this.btnAjouterDesQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
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
            this.pnlTitre.Controls.Add(this.lblExit);
            this.pnlTitre.Controls.Add(this.lblTitre);
            this.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitre.Location = new System.Drawing.Point(258, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1107, 118);
            this.pnlTitre.TabIndex = 5;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblExit.Location = new System.Drawing.Point(1055, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(38, 37);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitre.Location = new System.Drawing.Point(0, 31);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(1068, 63);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des questions";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(258, 768);
            this.pnlLogo.TabIndex = 4;
            // 
            // grbAjoutQuestion
            // 
            this.grbAjoutQuestion.Controls.Add(this.lblChampsObligatoires);
            this.grbAjoutQuestion.Controls.Add(this.txtCache);
            this.grbAjoutQuestion.Controls.Add(this.btnSuppression);
            this.grbAjoutQuestion.Controls.Add(this.btnModifier);
            this.grbAjoutQuestion.Controls.Add(this.btnDernier);
            this.grbAjoutQuestion.Controls.Add(this.btnSuivant);
            this.grbAjoutQuestion.Controls.Add(this.btnPrecedent);
            this.grbAjoutQuestion.Controls.Add(this.btnPremier);
            this.grbAjoutQuestion.Controls.Add(this.lblSucce);
            this.grbAjoutQuestion.Controls.Add(this.pibImage);
            this.grbAjoutQuestion.Controls.Add(this.btnUpload);
            this.grbAjoutQuestion.Controls.Add(this.txtUpload);
            this.grbAjoutQuestion.Controls.Add(this.txtBonneReponse);
            this.grbAjoutQuestion.Controls.Add(this.txtReponse3);
            this.grbAjoutQuestion.Controls.Add(this.txtReponse2);
            this.grbAjoutQuestion.Controls.Add(this.txtReponse1);
            this.grbAjoutQuestion.Controls.Add(this.txtQuestion);
            this.grbAjoutQuestion.Controls.Add(this.lblBonneReponse);
            this.grbAjoutQuestion.Controls.Add(this.lblReponse3);
            this.grbAjoutQuestion.Controls.Add(this.lblReponse2);
            this.grbAjoutQuestion.Controls.Add(this.lblReponse1);
            this.grbAjoutQuestion.Controls.Add(this.lblQuestion);
            this.grbAjoutQuestion.Controls.Add(this.btnValider);
            this.grbAjoutQuestion.Controls.Add(this.btnNouvelleQuestion);
            this.grbAjoutQuestion.Location = new System.Drawing.Point(280, 141);
            this.grbAjoutQuestion.Name = "grbAjoutQuestion";
            this.grbAjoutQuestion.Size = new System.Drawing.Size(1025, 615);
            this.grbAjoutQuestion.TabIndex = 16;
            this.grbAjoutQuestion.TabStop = false;
            this.grbAjoutQuestion.Text = "groupBox1";
            this.grbAjoutQuestion.Enter += new System.EventHandler(this.grbAjoutQuestion_Enter);
            // 
            // lblChampsObligatoires
            // 
            this.lblChampsObligatoires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblChampsObligatoires.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChampsObligatoires.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampsObligatoires.ForeColor = System.Drawing.Color.Red;
            this.lblChampsObligatoires.Location = new System.Drawing.Point(38, 501);
            this.lblChampsObligatoires.Name = "lblChampsObligatoires";
            this.lblChampsObligatoires.Size = new System.Drawing.Size(221, 30);
            this.lblChampsObligatoires.TabIndex = 49;
            this.lblChampsObligatoires.Text = "* : Champs obligatoires";
            // 
            // txtCache
            // 
            this.txtCache.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCache.HideSelection = false;
            this.txtCache.Location = new System.Drawing.Point(446, 302);
            this.txtCache.Multiline = true;
            this.txtCache.Name = "txtCache";
            this.txtCache.Size = new System.Drawing.Size(445, 37);
            this.txtCache.TabIndex = 41;
            // 
            // btnSuppression
            // 
            this.btnSuppression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSuppression.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuppression.Location = new System.Drawing.Point(751, 554);
            this.btnSuppression.Name = "btnSuppression";
            this.btnSuppression.Size = new System.Drawing.Size(237, 45);
            this.btnSuppression.TabIndex = 40;
            this.btnSuppression.Text = "Suppression";
            this.btnSuppression.UseVisualStyleBackColor = false;
            this.btnSuppression.Click += new System.EventHandler(this.btnSuppression_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnModifier.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnModifier.Location = new System.Drawing.Point(508, 554);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(237, 45);
            this.btnModifier.TabIndex = 39;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDernier.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnDernier.Location = new System.Drawing.Point(672, 430);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(159, 45);
            this.btnDernier.TabIndex = 38;
            this.btnDernier.Text = ">l";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSuivant.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuivant.Location = new System.Drawing.Point(507, 430);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(159, 45);
            this.btnSuivant.TabIndex = 37;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrecedent.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrecedent.Location = new System.Drawing.Point(342, 430);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(159, 45);
            this.btnPrecedent.TabIndex = 36;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPremier.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnPremier.Location = new System.Drawing.Point(177, 430);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(159, 45);
            this.btnPremier.TabIndex = 35;
            this.btnPremier.Text = "l<";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // lblSucce
            // 
            this.lblSucce.AutoSize = true;
            this.lblSucce.Location = new System.Drawing.Point(642, 282);
            this.lblSucce.Name = "lblSucce";
            this.lblSucce.Size = new System.Drawing.Size(0, 17);
            this.lblSucce.TabIndex = 30;
            // 
            // pibImage
            // 
            this.pibImage.BackColor = System.Drawing.Color.Silver;
            this.pibImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pibImage.Location = new System.Drawing.Point(446, 108);
            this.pibImage.Name = "pibImage";
            this.pibImage.Size = new System.Drawing.Size(445, 156);
            this.pibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImage.TabIndex = 29;
            this.pibImage.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnUpload.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpload.Location = new System.Drawing.Point(897, 66);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(108, 36);
            this.btnUpload.TabIndex = 27;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUpload
            // 
            this.txtUpload.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpload.Location = new System.Drawing.Point(446, 64);
            this.txtUpload.Multiline = true;
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(445, 37);
            this.txtUpload.TabIndex = 26;
            // 
            // txtBonneReponse
            // 
            this.txtBonneReponse.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonneReponse.Location = new System.Drawing.Point(264, 365);
            this.txtBonneReponse.Multiline = true;
            this.txtBonneReponse.Name = "txtBonneReponse";
            this.txtBonneReponse.Size = new System.Drawing.Size(176, 37);
            this.txtBonneReponse.TabIndex = 25;
            this.txtBonneReponse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonneReponse_KeyPress);
            // 
            // txtReponse3
            // 
            this.txtReponse3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReponse3.Location = new System.Drawing.Point(264, 310);
            this.txtReponse3.Multiline = true;
            this.txtReponse3.Name = "txtReponse3";
            this.txtReponse3.Size = new System.Drawing.Size(176, 37);
            this.txtReponse3.TabIndex = 23;
            // 
            // txtReponse2
            // 
            this.txtReponse2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReponse2.Location = new System.Drawing.Point(264, 256);
            this.txtReponse2.Multiline = true;
            this.txtReponse2.Name = "txtReponse2";
            this.txtReponse2.Size = new System.Drawing.Size(176, 37);
            this.txtReponse2.TabIndex = 22;
            // 
            // txtReponse1
            // 
            this.txtReponse1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReponse1.Location = new System.Drawing.Point(264, 198);
            this.txtReponse1.Multiline = true;
            this.txtReponse1.Name = "txtReponse1";
            this.txtReponse1.Size = new System.Drawing.Size(176, 37);
            this.txtReponse1.TabIndex = 21;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(19, 64);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(421, 128);
            this.txtQuestion.TabIndex = 17;
            // 
            // lblBonneReponse
            // 
            this.lblBonneReponse.AutoSize = true;
            this.lblBonneReponse.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonneReponse.Location = new System.Drawing.Point(21, 369);
            this.lblBonneReponse.Name = "lblBonneReponse";
            this.lblBonneReponse.Size = new System.Drawing.Size(238, 31);
            this.lblBonneReponse.TabIndex = 24;
            this.lblBonneReponse.Text = "La bonne réponse*";
            // 
            // lblReponse3
            // 
            this.lblReponse3.AutoSize = true;
            this.lblReponse3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse3.Location = new System.Drawing.Point(21, 314);
            this.lblReponse3.Name = "lblReponse3";
            this.lblReponse3.Size = new System.Drawing.Size(152, 31);
            this.lblReponse3.TabIndex = 20;
            this.lblReponse3.Text = "Réponse 3*";
            // 
            // lblReponse2
            // 
            this.lblReponse2.AutoSize = true;
            this.lblReponse2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse2.Location = new System.Drawing.Point(21, 260);
            this.lblReponse2.Name = "lblReponse2";
            this.lblReponse2.Size = new System.Drawing.Size(152, 31);
            this.lblReponse2.TabIndex = 19;
            this.lblReponse2.Text = "Réponse 2*";
            // 
            // lblReponse1
            // 
            this.lblReponse1.AutoSize = true;
            this.lblReponse1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReponse1.Location = new System.Drawing.Point(21, 206);
            this.lblReponse1.Name = "lblReponse1";
            this.lblReponse1.Size = new System.Drawing.Size(146, 31);
            this.lblReponse1.TabIndex = 18;
            this.lblReponse1.Text = "Réponse 1*";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(16, 18);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(322, 31);
            this.lblQuestion.TabIndex = 16;
            this.lblQuestion.Text = "Ecrivez votre question :*";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnValider.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(265, 554);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(237, 45);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnNouvelleQuestion
            // 
            this.btnNouvelleQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnNouvelleQuestion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnNouvelleQuestion.Location = new System.Drawing.Point(20, 554);
            this.btnNouvelleQuestion.Name = "btnNouvelleQuestion";
            this.btnNouvelleQuestion.Size = new System.Drawing.Size(239, 45);
            this.btnNouvelleQuestion.TabIndex = 0;
            this.btnNouvelleQuestion.Text = "Nouvelle question";
            this.btnNouvelleQuestion.UseVisualStyleBackColor = false;
            this.btnNouvelleQuestion.Click += new System.EventHandler(this.btnNouvelleQuestion_Click);
            // 
            // FrmGestionDesQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 768);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.grbAjoutQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionDesQuestions";
            this.Text = "AjouterDesQuestions";
            this.Load += new System.EventHandler(this.FrmAjouterDesQuestions_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.grbAjoutQuestion.ResumeLayout(false);
            this.grbAjoutQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button btnRapportDesQuestions;
        private System.Windows.Forms.Button btnTestes;
        private System.Windows.Forms.Button btnAjouterDesQuestions;
        private System.Windows.Forms.Button btnAjouterUnUtilisateur;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.GroupBox grbAjoutQuestion;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnNouvelleQuestion;
        private System.Windows.Forms.TextBox txtBonneReponse;
        private System.Windows.Forms.TextBox txtReponse3;
        private System.Windows.Forms.TextBox txtReponse2;
        private System.Windows.Forms.TextBox txtReponse1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblBonneReponse;
        private System.Windows.Forms.Label lblReponse3;
        private System.Windows.Forms.Label lblReponse2;
        private System.Windows.Forms.Label lblReponse1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.PictureBox pibImage;
        private System.Windows.Forms.Label lblSucce;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuppression;
        private System.Windows.Forms.TextBox txtCache;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblChampsObligatoires;

    }
}