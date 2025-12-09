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

    public partial class FrmQuiz : Form
    {

 
        string nomFichier = "didacticiel.did";
        DateTime DebutExamen;
        DateTime FinExamen;
        
        public FrmQuiz()
        {
            InitializeComponent();

            btnValiderReponse.Enabled = false;
            grbAffichageQuestion.Enabled = false;
        }


        private void AdminTestes_Load(object sender, EventArgs e)
        {
            btnAutre.Hide();
            txtLogin.Text = Utilisateurs.nomUtilisateur;
            txtMotDePasse.Text = Utilisateurs.PrenomUtilisateur;
            txtPoints.Text = Utilisateurs.points.ToString();

            Utilisateurs.ChercherUtilisateurDansFichier(txtLogin, txtMotDePasse, txtPoints);

                Utilisateurs.desactiverBouttonsPourUtilisateurs(txtLogin, txtMotDePasse, btnAjouterUnUtilisateur, btnAjouterDesQuestions, btnAutre,
                    btnTestes, btnRAZFichier, lstAffichage, lstAffichageNombreAleatoireTest, lstAfficherListeQuestionAleatoireTest);


                if (Didacticiel.fichierVideOuPas(nomFichier) == false)
                {
                    MessageBox.Show("lecture du fichier.......");

                    Didacticiel.LectureQuestionDansFichier(nomFichier);

                    Didacticiel.AfficherListeQuestionReponseTest(lstAffichage);

                    Didacticiel.TirageNombreAleatoire();

                    Didacticiel.AfficherListeNombreAleatoireTest(lstAffichageNombreAleatoireTest);

                    Didacticiel.ConverionListeQuestionEnListeQuestionAleatoire();

                    Didacticiel.AfficherListeQuestionAleatoireTest(lstAfficherListeQuestionAleatoireTest);



                    Didacticiel.TableauImageSansChemin();
                    int position = Didacticiel.PositionImageDansListe();

                }
                else
                {
                    MessageBox.Show("le fichier est vide ....");
                }
            }
        

        private void btnRAZFichier_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(nomFichier);
            streamWriter.Close();
        }

        public void btnValiderReponse_Click(object sender, EventArgs e)
        {
            Didacticiel.ConfigCompteurTempsQuestion(pnlProgresse, tmrCompteur);
           int positionBouttonRadioSelectionne;

            foreach (RadioButton item in grbAffichageQuestion.Controls)
            {
                if (item.Checked == true)
                {
                   positionBouttonRadioSelectionne = item.TabIndex + 1;
                    Didacticiel.ValiderReponse(positionBouttonRadioSelectionne);
                    item.Checked = false;
                    Didacticiel.AffichageReponses(lstAfficherReponse,radRep1, radRep2, radRep3, positionBouttonRadioSelectionne);
                }
                if (Didacticiel.indexQuestion < Didacticiel.listeNombreAleatoire.Count)
                {
                    item.Checked = false;
                    Didacticiel.AffichageQuestionEtudiant(grbAffichageQuestion, radRep1, radRep2, radRep3,
                    Didacticiel.indexQuestion, pibAffichageImage, Didacticiel.PositionImageDansListe());

                    btnValiderReponse.Enabled = true;
                    grbAffichageQuestion.Enabled = true;


                }
                else
                {
                    FinExamen = DateTime.Now;

                    RapportQuestionnaire.CalculerLaDureeDeQuiz(DebutExamen, FinExamen);

                    RapportQuestionnaire.FichierRapportVideOuPas();

                    Didacticiel.BonnesEtMauvausesReponses(lstAfficherReponse);
                    Didacticiel.Findedidacticiel(tmrCompteur, txtPoints, txtLogin, txtMotDePasse, grbAffichageQuestion, btnValiderReponse, btnDebuterDidacticiel, lstAffichage,
                        lstAffichageNombreAleatoireTest, lstAfficherListeQuestionAleatoireTest);

                    RapportQuestionnaire.LectureRapportDansFichier();

                    RapportQuestionnaire rapportQuestionnaire = new RapportQuestionnaire(Utilisateurs.nomUtilisateur, Utilisateurs.PrenomUtilisateur,
                       Didacticiel.pointObtenu, Didacticiel.bonnesReponses, Didacticiel.mauvaisesReponse, RapportQuestionnaire.dureeExam, DebutExamen);
                    RapportQuestionnaire.AjoutRapportDansListe(rapportQuestionnaire);
                    RapportQuestionnaire.AjoutRapportDansFichier();
                    break;
                }
                //break;
            }
        }

        private void btnDebuterDidacticiel_Click(object sender, EventArgs e)
        {
            DebutExamen = DateTime.Now;
            
            Didacticiel.AffichageQuestionEtudiant(grbAffichageQuestion,radRep1, radRep2, radRep3,
                Didacticiel.indexQuestion, pibAffichageImage, Didacticiel.PositionImageDansListe());

            btnValiderReponse.Enabled = true;
            grbAffichageQuestion.Enabled = true;
            tmrCompteur.Start();
        }

        private void btnAjouterUnUtilisateur_Click(object sender, EventArgs e)
        {
            FrmGestionUtilisateur frmAjoutUtilisateur = new FrmGestionUtilisateur();
            frmAjoutUtilisateur.Show();
            this.Hide();
        }

        private void btnAjouterDesQuestions_Click(object sender, EventArgs e)
        {
            FrmGestionDesQuestions frmAjouterDesQuestions = new FrmGestionDesQuestions();
            frmAjouterDesQuestions.Show();
            this.Hide();
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            tmrCompteur.Stop();
            Didacticiel.DeconnecterDidactitiel(tmrCompteur);
            this.Hide();
        }

        private void tmrCompteur_Tick(object sender, EventArgs e)
        {
            Didacticiel.ConfigCompteurTempsQuestion(pnlProgresse, PnlBackground, tmrCompteur);

            //int PositionRBselectionner = 0;
            pnlProgresse.Width += 3;

            if (pnlProgresse.Width == PnlBackground.Width)
            {
                tmrCompteur.Stop();
                MessageBox.Show("temps est écoulé");
                Didacticiel.ConfigCompteurTempsQuestion(pnlProgresse, tmrCompteur);
                radRep3.TabIndex = radRep3.TabIndex + 2;
                radRep3.Checked = true;
                btnValiderReponse_Click(sender, e);
            }     
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {
        }
    }
}
