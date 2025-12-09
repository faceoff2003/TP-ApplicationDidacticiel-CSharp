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
    public partial class FrmGestionDesQuestions : Form
    {
        public static string nomFichier = "didacticiel.did";
        int pointeurEnregistrement=0;
        OpenFileDialog maPhoto = new OpenFileDialog();
        public FrmGestionDesQuestions()
        {
            InitializeComponent();
            lblTitre.Text = "Ajouter des questions";
            btnAjouterDesQuestions.BackColor = Color.FromArgb(0, 150, 136);
            //txtCache.Hide();    
        }

        private void btnAjouterUnUtilisateur_Click(object sender, EventArgs e)
        {
            FrmGestionUtilisateur frmAjoutUtilisateur = new FrmGestionUtilisateur();
            frmAjoutUtilisateur.Show();
            this.Hide();
        }

        private void btnAjouterDesQuestions_Click(object sender, EventArgs e)
        {
            lblTitre.Text = "Ajouter des questions";
            btnAjouterDesQuestions.BackColor = Color.FromArgb(0, 150, 136);
        }

        private void FrmAjouterDesQuestions_Load(object sender, EventArgs e)
        {
            //btnRapportDesQuestions.Hide();
            bool videOuPas = Didacticiel.fichierVideOuPas(nomFichier);
            if (videOuPas == true)
            {
                MessageBox.Show("le fichier est vide ....");

                //// question 1 :
                //Didacticiel question = new Didacticiel("en quelle année est apparu le DOS", "2000", "1970", "1980", 3, "image0001.jpg");
                //Didacticiel.AjoutQuestionDansListe(question);
                //// question 2 :
                //question = new Didacticiel("en quelle année est apparu le language C", "1969", "1978", "2002", 1, "image0002.jpg");
                //Didacticiel.AjoutQuestionDansListe(question);
                //// question 3 :
                //question = new Didacticiel("Que veut dire l'acronyme SQL", "Sans question libre", "Structured query language", "Sorry query language", 1, "image0003.jpg");
                //Didacticiel.AjoutQuestionDansListe(question);
                //// question 4 :
                //question = new Didacticiel("En quelle année est apparu le language C#", "2002", "2010", "2015", 1, "image0004.jpg");
                //Didacticiel.AjoutQuestionDansListe(question);
                //// Ecriture dans le fichier :

                //Didacticiel.AjoutQuestionDansFichier(nomFichier);

                //Didacticiel.TirageNombreAleatoire();
                //Didacticiel.ConverionListeQuestionEnListeQuestionAleatoire();
                //Didacticiel.TableauImageSansChemin();
                //int position = Didacticiel.PositionImageDansListe();

            }
            else
            {

                MessageBox.Show("le fichier n'est pas vide");
                Didacticiel.LectureQuestionDansFichier(nomFichier);
                Didacticiel.TirageNombreAleatoire();
                Didacticiel.ConverionListeQuestionEnListeQuestionAleatoire();
                Didacticiel.TableauImageSansChemin();
                int position = Didacticiel.PositionImageDansListe();


                btnPremier_Click(sender, e);
            
            
            }

        }

        private void btnNouvelleQuestion_Click(object sender, EventArgs e)
        {
            Didacticiel.EffacerBoiteDeTexte(grbAjoutQuestion);
            btnValider.Enabled = true;
            pibImage.Image = null;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(txtQuestion.Text) || string.IsNullOrEmpty(txtReponse1.Text) || string.IsNullOrEmpty(txtReponse2.Text) ||
                string.IsNullOrEmpty(txtReponse2.Text) || string.IsNullOrEmpty(txtBonneReponse.Text) || string.IsNullOrEmpty(txtUpload.Text)))
            {
            MessageBox.Show("Veuillez remplir tous les champs..");
            }
            else
            {
            string Question = txtQuestion.Text;
            string Reponse1 = txtReponse1.Text;
            string Reponse2 = txtReponse2.Text;
            string Reponse3 = txtReponse3.Text;
            int Labonnereponse = Convert.ToInt16(txtBonneReponse.Text);
            string NomImage = txtUpload.Text;

                Didacticiel ditacticiel = new Didacticiel(Question,Reponse1,Reponse2,Reponse3,Labonnereponse,NomImage);
                Didacticiel.AjoutQuestionDansListe(ditacticiel);
                Didacticiel.AjoutQuestionDansFichier(nomFichier);


                try
                {
                    File.Copy((txtCache.Text), Path.Combine(Didacticiel.Image2, Path.GetFileName(txtCache.Text)), false);
                }
                catch (IOException)
                {
                    MessageBox.Show("Une Image avec le nom " + maPhoto.SafeFileName + " éxiste déja Dans le fichier");
                    btnUpload_Click(sender,e);
                }

                MessageBox.Show("Ajout effectué avec succés...");
 
                Didacticiel.LectureQuestionDansFichier(nomFichier);
                txtUpload.Clear();
                txtCache.Clear();
                btnValider.Enabled = false;
                btnPremier_Click(sender, e);
                Didacticiel.listeNombreAleatoire.Clear();
                Didacticiel.listeQuestionAleatoire.Clear();

                Didacticiel.LectureQuestionDansFichier(nomFichier);
                Didacticiel.TirageNombreAleatoire();
                Didacticiel.ConverionListeQuestionEnListeQuestionAleatoire();
                Didacticiel.TableauImageSansChemin();
                int position = Didacticiel.PositionImageDansListe();

                //AdminTestes adminTestes = new AdminTestes();
                //adminTestes.Show();
                //this.Hide();

            
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Didacticiel.telechargerImage(txtCache, txtUpload, pibImage);
        }

        private void grbAjoutQuestion_Enter(object sender, EventArgs e)
        {

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement = 0;

            Didacticiel.AffichageDansfrmAjouterDesQuestions(txtQuestion,txtReponse1,txtReponse2,txtReponse3,txtBonneReponse,pibImage, pointeurEnregistrement,Didacticiel.PositionImageDansListe());
            Didacticiel.AffichagePointeurEnregistrement(pointeurEnregistrement, grbAjoutQuestion);

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement = Didacticiel.listeQuestion.Count - 1;
            Didacticiel.AffichageDansfrmAjouterDesQuestions(txtQuestion, txtReponse1, txtReponse2, txtReponse3, txtBonneReponse, pibImage, pointeurEnregistrement, Didacticiel.PositionImageDansListe());
            Didacticiel.AffichagePointeurEnregistrement(pointeurEnregistrement, grbAjoutQuestion);


            }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement--;
            if (pointeurEnregistrement >= 0)
            {
                Didacticiel.AffichageDansfrmAjouterDesQuestions
                    (txtQuestion, txtReponse1, txtReponse2, txtReponse3, txtBonneReponse, pibImage, pointeurEnregistrement, Didacticiel.PositionImageDansListe());

            }
            else
            {
                pointeurEnregistrement = 0;
                MessageBox.Show("Vous êtres au début de fichier...");
            
            }
            Didacticiel.AffichagePointeurEnregistrement(pointeurEnregistrement, grbAjoutQuestion);

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            pointeurEnregistrement++;
            if (pointeurEnregistrement < Didacticiel.listeQuestion.Count)
            {
                Didacticiel.AffichageDansfrmAjouterDesQuestions(txtQuestion, txtReponse1, txtReponse2, txtReponse3, txtBonneReponse, pibImage, pointeurEnregistrement, Didacticiel.PositionImageDansListe());

            }
            else
            {
                pointeurEnregistrement = Didacticiel.listeQuestion.Count - 1;
                MessageBox.Show("Vous êtes en fin de fichier...");
            
            }

            Didacticiel.AffichagePointeurEnregistrement(pointeurEnregistrement, grbAjoutQuestion);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string Question = txtQuestion.Text;
            string Reponse1 = txtReponse1.Text;
            string Reponse2 = txtReponse2.Text;
            string Reponse3 = txtReponse3.Text;
            int Labonnereponse = Convert.ToInt32(txtBonneReponse.Text);
            string NomImage = txtUpload.Text;

            string modification = Didacticiel.ModifierUnEnregistrement
                (Question, Reponse1, Reponse2, Reponse3, Labonnereponse, NomImage, pointeurEnregistrement);
            MessageBox.Show(modification);

        }

        private void btnSuppression_Click(object sender, EventArgs e)

        {
            DialogResult reponse = MessageBox.Show("vous voulez supprimer " + Didacticiel.listeQuestion[pointeurEnregistrement].Question + "?", "delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (reponse == DialogResult.Yes)
            {
                string message = Didacticiel.SuppressionUnEnregistrement(pointeurEnregistrement);
                btnPremier_Click(sender, e);
                MessageBox.Show(message);
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuiz adminTestes = new FrmQuiz();
            Didacticiel.listeQuestion.Clear();
            Didacticiel.listeNombreAleatoire.Clear();
            Didacticiel.listeQuestionAleatoire.Clear();
            Didacticiel.indexQuestion = 0;
            adminTestes.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
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

        private void txtBonneReponse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'X';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void btnRapportDesQuestions_Click(object sender, EventArgs e)
        {
            FrmRapportDesQuestionnaires frmRapportDesQuestionnaires = new FrmRapportDesQuestionnaires();
            frmRapportDesQuestionnaires.Show();
            this.Hide();
        }


        }
    }
