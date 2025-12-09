using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ApplicationDidacticiel2022Soulayman
{
    public partial class FrmGestionUtilisateur : Form
    {

        public static string nomFichier = "Utilisateur.did";
        public static int pointeurEnregistrement;
        DateTime dateExamen;
        bool admin;
        string nomPrenomARechercher;
        public static int retourPositionRechercher;

        


        public FrmGestionUtilisateur()
        {
            InitializeComponent();

        }

        private void FrmAjoutUtilisateur_Load(object sender, EventArgs e)
        {

            //btnAutres.Hide();
            bool videOuPas = Utilisateurs.fichierVideOuPas(nomFichier);
            if (videOuPas == true)
            {
                MessageBox.Show("Le Fichier est vide");

            }
            else
            {
                MessageBox.Show("Le fichier n'est pas vide");
                Utilisateurs.LectureUtilisateursDansFichier(nomFichier);
                RapportQuestionnaire.LectureRapportDansFichier();
                btnPremier_Click(sender, e);
                if (txtDateExamen.Text.Contains("01/01/0001"))
                {
                    btnRapport.Hide();
                }
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement = 0;
            Utilisateurs.AffichageUtilisateurslogin(txtNom, txtPrenom, txtLogin, txtMotDePasse, txtPointsObtenu, cBAdmin,txtDateExamen,pointeurEnregistrement);
            Utilisateurs.AffichagePointeurEnregistrement(pointeurEnregistrement, GrbUtilisateurs);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNom.Text)) || (string.IsNullOrEmpty(txtPrenom.Text)) ||
                (string.IsNullOrEmpty(txtLogin.Text)) || (string.IsNullOrEmpty(txtMotDePasse.Text)))
            {

                MessageBox.Show("veuillez remplir les champs mentionné avec (*)");

            }
            else
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string login = txtLogin.Text;
                string motDePasse = txtMotDePasse.Text;
                admin = cBAdmin.Checked;
                txtDateExamen.Text=dateExamen.ToString();

                if (cBAdmin.Checked == true)
                {
                    admin = true;
                }
                else
                {
                    admin = false;
                }

                Utilisateurs utilisateurs = new Utilisateurs(nom, prenom, login, motDePasse,admin,dateExamen);
                Utilisateurs.AjoutUtilisateursDansListe(utilisateurs);
                Utilisateurs.AjoutUtilisateursDansFichier(nomFichier);

                MessageBox.Show("Ajout effectué avec succés...");
                btnValider.Enabled = false;
                btnPremier_Click(sender, e);
            }
        }

        private void btnNouvelleQuestion_Click(object sender, EventArgs e)
        {
            Utilisateurs.EffacerBoiteDeTexte(GrbUtilisateurs);
            if (txtPointsObtenu.Text == "")
            {
                txtPointsObtenu.Text = ("Teste non éffectuer");
            }
        }

        private void btnAjouterDesQuestions_Click(object sender, EventArgs e)
        {
            FrmGestionDesQuestions frmAjouterDesQuestions = new FrmGestionDesQuestions();
            frmAjouterDesQuestions.Show();
            this.Hide();
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResulat = MessageBox.Show("êtres vous sûr de fermer la session..?", "déconnexion", MessageBoxButtons.YesNo);
            if (dialogueResulat == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement--;
            if (pointeurEnregistrement >= 0)
            {
                Utilisateurs.AffichageUtilisateurslogin(txtNom, txtPrenom, txtLogin, txtMotDePasse, txtPointsObtenu,cBAdmin,
                    txtDateExamen ,pointeurEnregistrement);

            }

            else
            {
                pointeurEnregistrement = 0;
                MessageBox.Show("Vous êtes au debut de fichier....");

            }
            Utilisateurs.AffichagePointeurEnregistrement(pointeurEnregistrement, GrbUtilisateurs);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement++;
            if (pointeurEnregistrement < Utilisateurs.listeUtilisateurs.Count)
            {
                Utilisateurs.AffichageUtilisateurslogin(txtNom, txtPrenom, txtLogin, txtMotDePasse, txtPointsObtenu, cBAdmin, txtDateExamen, pointeurEnregistrement);
            }
            else
            {
                pointeurEnregistrement = Utilisateurs.listeUtilisateurs.Count - 1;
                MessageBox.Show("Vous êtes en fin de la liste...");

            }
            Utilisateurs.AffichagePointeurEnregistrement(pointeurEnregistrement, GrbUtilisateurs);
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement = Utilisateurs.listeUtilisateurs.Count - 1;
            Utilisateurs.AffichageUtilisateurslogin(txtNom, txtPrenom, txtLogin, txtMotDePasse, txtPointsObtenu, cBAdmin, txtDateExamen, pointeurEnregistrement);
            Utilisateurs.AffichagePointeurEnregistrement(pointeurEnregistrement, GrbUtilisateurs);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string login = txtLogin.Text;
            string motDePasse = txtMotDePasse.Text;
            bool admin = cBAdmin.Checked;
            DateTime dateExamen =Convert.ToDateTime(txtDateExamen.Text);

            int pointsObtenus = Convert.ToInt16(txtPointsObtenu.Text);

            string modifications =Utilisateurs.ModifierUtilisateur(nom,prenom,login,motDePasse,pointsObtenus,admin,dateExamen, pointeurEnregistrement);
            MessageBox.Show(modifications);

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRechercher.Text))
            {
                MessageBox.Show("Le champs ne peut pas être vide...");
                txtRechercher.Focus();
            }
            else
            {

                string nomPrenomARechercher = txtRechercher.Text;
                int retourPositionRechercher = Utilisateurs.Recherche(nomPrenomARechercher);

                if (retourPositionRechercher == -1)
                {
                    MessageBox.Show(nomPrenomARechercher + "  " + "n'existe pas");
                    txtRechercher.Clear();
                    txtRechercher.Focus();

                }
                else
                {
                    pointeurEnregistrement = retourPositionRechercher;
                    Utilisateurs.AffichageUtilisateurslogin(txtNom, txtPrenom, txtLogin, txtMotDePasse, txtPointsObtenu, cBAdmin, txtDateExamen, pointeurEnregistrement);
                    Utilisateurs.AffichagePointeurEnregistrement(pointeurEnregistrement, GrbUtilisateurs);
                }

            }
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez vous supprimer " + Utilisateurs.listeUtilisateurs[pointeurEnregistrement].Nom + " ?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (reponse == DialogResult.Yes)
            {
                string message = Utilisateurs.SuppressionUnEnregistrement(pointeurEnregistrement);
                btnPrecedent_Click(sender, e);
                MessageBox.Show(message);

            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTableauDeBord frmTableauDeBord = new FrmTableauDeBord();
            frmTableauDeBord.Show();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'L';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'L';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtPointsObtenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'K';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtRechercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {
            FrmQuiz adminTestes = new FrmQuiz();
            adminTestes.Show();
            this.Hide();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {

            nomPrenomARechercher = (txtNom.Text + " " + txtPrenom.Text);
            retourPositionRechercher = RapportQuestionnaire.RechercheRapport(nomPrenomARechercher);

                FrmRapportDesQuestionnaires frmRapportDesQuestionnaires = new FrmRapportDesQuestionnaires();
                frmRapportDesQuestionnaires.Show();
                this.Hide();
                pointeurEnregistrement = 0;
         
        }

        private void txtPointsObtenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateExamen_TextChanged(object sender, EventArgs e)
        {
            if (txtDateExamen.Text == "01/01/0001 00:00:00")
            {
                btnRapport.Hide();

            }
            else
            {
                btnRapport.Show();

            }
        }

        private void btnAutres_Click(object sender, EventArgs e)
        {
            FrmRapportDesQuestionnaires frmRapportDesQuestionnaires = new FrmRapportDesQuestionnaires();
            frmRapportDesQuestionnaires.Show();
            this.Hide();
        }

    }
}
