using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDidacticiel2022Soulayman
{
    public partial class FrmRapportDesQuestionnaires : Form
    {
        int pointeurEnregistrement=FrmGestionUtilisateur.retourPositionRechercher;

        public FrmRapportDesQuestionnaires()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTableauDeBord frmTableauDeBord = new FrmTableauDeBord();
            frmTableauDeBord.Show();
        }

        private void FrmRapportDesQuestionnaires_Load(object sender, EventArgs e)
        {
            RapportQuestionnaire.LectureRapportDansFichier();
            RapportQuestionnaire.AfficherRapportQuestionnaire(txtNom, txtPrenom, txtPointsObtenus, txtBonnereponses,
                txtMauvaisesReponses, txtDureeExamen, txtDateExamen, pointeurEnregistrement);
            RapportQuestionnaire.AffichagePointeurEnregistrementRapport(pointeurEnregistrement, grbRapportQuestions);

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement = 0;
            RapportQuestionnaire.AfficherRapportQuestionnaire(txtNom, txtPrenom, txtPointsObtenus, txtBonnereponses,
                txtMauvaisesReponses, txtDureeExamen, txtDateExamen, pointeurEnregistrement);
            RapportQuestionnaire.AffichagePointeurEnregistrementRapport(pointeurEnregistrement, grbRapportQuestions);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement--;
            if (pointeurEnregistrement >= 0)
            {
                RapportQuestionnaire.AfficherRapportQuestionnaire(txtNom, txtPrenom, txtPointsObtenus, txtBonnereponses,
                txtMauvaisesReponses, txtDureeExamen, txtDateExamen, pointeurEnregistrement);

            }

            else
            {
                pointeurEnregistrement = 0;
                MessageBox.Show("Vous êtes au debut de fichier....");

            }
            RapportQuestionnaire.AffichagePointeurEnregistrementRapport(pointeurEnregistrement, grbRapportQuestions);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement++;
            if (pointeurEnregistrement < RapportQuestionnaire.listeRapportQuestionnaire.Count)
            {
                RapportQuestionnaire.AfficherRapportQuestionnaire(txtNom, txtPrenom, txtPointsObtenus, txtBonnereponses,
                txtMauvaisesReponses, txtDureeExamen, txtDateExamen, pointeurEnregistrement);
            }
            else
            {
                pointeurEnregistrement = RapportQuestionnaire.listeRapportQuestionnaire.Count - 1;
                MessageBox.Show("Vous êtes en fin de la liste...");

            }
            RapportQuestionnaire.AffichagePointeurEnregistrementRapport(pointeurEnregistrement, grbRapportQuestions);
        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmTableauDeBord frmTableauDeBord = new FrmTableauDeBord();
            frmTableauDeBord.Show();
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResulat = MessageBox.Show("êtres vous sûr de fermer la session..?", "déconnexion", MessageBoxButtons.YesNo);
            if (dialogueResulat == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btnAjouterDesQuestions_Click(object sender, EventArgs e)
        {
            FrmGestionDesQuestions frmAjouterDesQuestions = new FrmGestionDesQuestions();
            frmAjouterDesQuestions.Show();
            this.Hide();
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {
            FrmQuiz adminTestes = new FrmQuiz();
            adminTestes.Show();
            this.Hide();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement = RapportQuestionnaire.listeRapportQuestionnaire.Count - 1;
            RapportQuestionnaire.AfficherRapportQuestionnaire(txtNom, txtPrenom, txtPointsObtenus, txtBonnereponses,
                txtMauvaisesReponses, txtDureeExamen, txtDateExamen, pointeurEnregistrement);
            RapportQuestionnaire.AffichagePointeurEnregistrementRapport(pointeurEnregistrement, grbRapportQuestions);
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

                int retourPositionRechercher = RapportQuestionnaire.RechercheRapport(nomPrenomARechercher);

                if (retourPositionRechercher == -1)
                {
                    MessageBox.Show(nomPrenomARechercher + "  " + "n'existe pas");
                    txtRechercher.Clear();
                    txtRechercher.Focus();

                }
                else
                {
                    RapportQuestionnaire.LectureRapportDansFichier();
                    RapportQuestionnaire.AfficherRapportQuestionnaire(txtNom, txtPrenom, txtPointsObtenus, txtBonnereponses,
                txtMauvaisesReponses, txtDureeExamen, txtDateExamen, pointeurEnregistrement);
                    RapportQuestionnaire.AffichagePointeurEnregistrementRapport(pointeurEnregistrement, grbRapportQuestions);
                }
            }
        }

        private void btnAjouterUnUtilisateur_Click(object sender, EventArgs e)
        {
            FrmGestionUtilisateur frmGestionUtilisateur = new FrmGestionUtilisateur();
            frmGestionUtilisateur.Show();
            this.Hide();
        }

        private void btnAutres_Click(object sender, EventArgs e)
        {

        }

        private void txtDureeExamen_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez vous supprimer " + RapportQuestionnaire.listeRapportQuestionnaire[pointeurEnregistrement].Nom + " ?",
               "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);


            if (reponse == DialogResult.Yes)
            {
                string message = RapportQuestionnaire.SuppressionUnEnregistrement(pointeurEnregistrement);
                btnPrecedent_Click(sender, e);
                MessageBox.Show(message);

            }
        }
    }
}
   
