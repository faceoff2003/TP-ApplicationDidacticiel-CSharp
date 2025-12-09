using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ApplicationDidacticiel2022Soulayman
{
    class Didacticiel
    {
        // Zone des variables, des tableaux,des listes
        // En clair, ce qui n'est pas un membre classique

        // Liste<> contenant les questions

        public static List<Didacticiel> listeQuestion = new List<Didacticiel>();

        // Liste<> qui va contenir les nombres aléatoires

        public static List<int> listeNombreAleatoire = new List<int>();

        // Liste<> Contenant les question aléatoire (Aprés le tirrage des index aléatoires)

        public static List<Didacticiel> listeQuestionAleatoire = new List<Didacticiel>();

        // Tableau contenant les champs de la ligne du fichier

        private static string[] champs;

        // Position de la question --> Index de la question
        public static int indexQuestion = 0;

        // Mémorisation des points de l'étudiant (un variable qui contient les points)
        public static int pointObtenu;

        // Variable qui contient image sans chemin (mais pas un tableau);

        public static string Image2;

          public static  string reponse;

          public static List<string> listeReponses = new List<string>();

        public static int bonnesReponses;
        public static int mauvaisesReponse;




        // Attribus--------------------------

        private string question;
        private string reponse1;
        private string reponse2;
        private string reponse3;
        private int bonneReponse;
        private string nomImage;

        //Constructeur paramétré-----------------------

        public Didacticiel(string question, string reponse1, string reponse2, string reponse3, int bonneReponse, string nomImage)
        {
            this.question = question;
            this.reponse1 = reponse1;
            this.Reponse2 = reponse2;
            this.Reponse3 = reponse3;
            this.bonneReponse = bonneReponse;
            this.nomImage = nomImage;
        }

        //Constructeur par defaut---------------------------

        public Didacticiel() { }

        // Propriétés-----------------------------------------
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string Reponse1
        {
            get { return reponse1; }
            set { reponse1 = value; }
        }

        public string Reponse2
        {
            get { return reponse2; }
            set { reponse2 = value; }
        }

        public string Reponse3
        {
            get { return reponse3; }
            set { reponse3 = value; }
        }

        public int BonneReponse
        {
            get { return bonneReponse; }
            set { bonneReponse = value; }
        }

        public string NomImage
        {
            get { return nomImage; }
            set { nomImage = value; }
        }

        // Méthodes----------------------------------------------------------------------------------------
        //----------------------------Début de Méthode fichierVideOuPas-------------------------

        public static bool fichierVideOuPas(string nomDufichierAAnalyser)
        {
            StreamReader streamReader = new StreamReader(nomDufichierAAnalyser);
            string lectureLigne = streamReader.ReadLine();

            if (lectureLigne == null)
            {
                streamReader.Close();
                return true;
            }

            else
            {
                streamReader.Close();
                return false;
            }
        }
        //----------------------------Fin de Méthode fichierVideOuPas-------------------------

        //----------------------------Début de Méthode AjoutQuestionDansListe-------------------------

        // "question" ci-dessous est un objet de type "Didacticiel" c-à-d un objet de notre class
        public static void AjoutQuestionDansListe(Didacticiel question)
        {
            // On ajoute les objets de type "Didacticiel"dans la liste "listeQuestion"

            listeQuestion.Add(question);

        }
        //----------------------------Fin de Méthode AjoutQuestionDansListe-------------------------
        //----------------------------Début de Méthode AjoutQuestionDansFichier-------------------------

        public static void AjoutQuestionDansFichier(string nomDuFichier)
        {
            StreamWriter streamWriter = new StreamWriter(nomDuFichier);

            for (int i = 0; i < listeQuestion.Count; i++)
            {

                streamWriter.WriteLine(listeQuestion[i].Question + ";" + listeQuestion[i].Reponse1 + ";" +
                listeQuestion[i].Reponse2 + ";" + listeQuestion[i].Reponse3 + ";" +
                listeQuestion[i].BonneReponse + ";" + listeQuestion[i].NomImage + ";");
            }

            streamWriter.Close();

        }
        //----------------------------Fin de Méthode AjoutQuestionDansFichier-------------------------
        //----------------------------Début de Méthode LectureQuestionDansFichier------------------------

        public static void LectureQuestionDansFichier(string nomDuFichier)
        {
            listeQuestion.Clear();
            StreamReader streamReader = new StreamReader(nomDuFichier);

            string lectureLigneFichier = streamReader.ReadLine();

            while (lectureLigneFichier != null)
            {
                champs = lectureLigneFichier.Split(';');

                Didacticiel QuestionReponse = new Didacticiel
                    (champs[0], champs[1], champs[2], champs[3], Convert.ToInt32(champs[4]), champs[5]);

                Didacticiel.AjoutQuestionDansListe(QuestionReponse);
                lectureLigneFichier = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        public static void ConverionListeQuestionEnListeQuestionAleatoire()
        {
            for (int i = 0; i < listeQuestion.Count; i++)
            {

                listeQuestionAleatoire.Add(listeQuestion[listeNombreAleatoire[i]]);
            }
        }

        public static void TirageNombreAleatoire()
        {
            Random random = new Random();

            int nombreQuestionReponse = listeQuestion.Count;

            listeNombreAleatoire.Add(random.Next(0, nombreQuestionReponse));

            for (int i = 1; i < nombreQuestionReponse; i++)
            {
                listeNombreAleatoire.Add(random.Next(0, nombreQuestionReponse));

                for (int j = i - 1; j >= 0; j--)
                {
                    if (listeNombreAleatoire[i] == listeNombreAleatoire[j])
                    {
                        listeNombreAleatoire.RemoveAt(i);  // Suopprimer la valeur de "i" ki est répété
                        i--;                              // Décrémonter "i"
                        break;                           // sortir de "j" si ya égalité

                    }//  Fin de la boucle "i"

                }// Fin de la boucle "i"

            }
        }

        public static void AffichageQuestionEtudiant(GroupBox grbQuestion, RadioButton radRep1,
            RadioButton radRep2, RadioButton radRep3, int indiceQuestion, PictureBox pibAffichageImage, int indexImage)
        {
            grbQuestion.Text = listeQuestionAleatoire[indiceQuestion].question;
            radRep1.Text = listeQuestionAleatoire[indiceQuestion].reponse1;
            radRep2.Text = listeQuestionAleatoire[indiceQuestion].reponse2;
            radRep3.Text = listeQuestionAleatoire[indiceQuestion].reponse3;

            pibAffichageImage.Image = Image.FromFile(image[indexImage]);
            pibAffichageImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        //-----------------------------------------------------------------------------------------------------
        //---- Méthode de test

        //1. Afficher la liste des questions
        public static void AfficherListeQuestionReponseTest(ListBox ListeAffichageQuestionReponseTest)
        {
            foreach (Didacticiel item in listeQuestion)
            {

                ListeAffichageQuestionReponseTest.Items.Add(item.question
                    + "   " + item.reponse1 + "   " + item.reponse2 + "   " + item.reponse3 + "   " +
                    item.bonneReponse + "   " + item.nomImage);
            }
        }

        //2.Afficher la liste des nombre Aléatoires

        public static void AfficherListeNombreAleatoireTest(ListBox AfficherListeNombreAleatoireTest)
        {
            foreach (int item in listeNombreAleatoire)
            {
                AfficherListeNombreAleatoireTest.Items.Add(item);

            }
        }

        //3.Afficher la liste des question aléatoires..................................

        public static void AfficherListeQuestionAleatoireTest(ListBox AfficherListeQuestionAleatoireTest)
        {
            foreach (Didacticiel item in listeQuestionAleatoire)
            {

                AfficherListeQuestionAleatoireTest.Items.Add(item.Question + "   " + item.Reponse1 + "   "
                   + item.Reponse2 + "   " + item.Reponse3 + "   " +
                    item.BonneReponse + "   " + item.NomImage);
            }
        }
        //-------------------Méthode pour comprarer la reponse avec la bonne réponse----------------------
        public static void ValiderReponse(int positionBouttonRadioSelectionne)
        {
            if (listeQuestionAleatoire[indexQuestion].bonneReponse == positionBouttonRadioSelectionne)
            {
                //MessageBox.Show("Bonne réponse");
                AjouterPoint();

            }
            else
            {

                //MessageBox.Show("Mauvaise réponse");
                DiminuerPoint();

            }
            indexQuestion++;
        }
        //-------------------Méthode pour Ajouter des points (qd la réponse est bonne)----------------------

        public static void AjouterPoint()
        {
            pointObtenu = pointObtenu + 10;
        }
        //-------------------Méthode pour Diminuer des points (qd la réponse est mauvaise)----------------------

        public static void DiminuerPoint()
        {
            //pointObtenu = pointObtenu-10;
        }
        //-----------------------------------------------------------------------------------------------
        public static void RazBoutonRadio(GroupBox grbQuestionEleve)
        {
            foreach (Control item in grbQuestionEleve.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)item).Checked = false;

                }
            }
        }
        //---------------------------------------Images---------------------------------------

        // Tableau contenant les images avec le chemin(suite de dossier)
        public static string[] image;

        // Liste contenant les images sans le chemin.
        public static List<string> listeImageSansChemain = new List<string>();

        public static string[] ChargerImage()
        {
            // je Lis le dossier courant

            // Environment.CurrentDirectory; c'est pour localiser le chemin de notre dossier
            string dossierCourant = Environment.CurrentDirectory;

            // je remonte d'un niveau (parent)
            // Directory.GetParent c'est pour retourner un sousdossier à la fois
            dossierCourant = Directory.GetParent(dossierCourant).ToString();
            //je remonte d'un autre niveau pour arriver au dossier contenant les images   
            dossierCourant = Directory.GetParent(dossierCourant).ToString();


            // Je place dans le tableau "image" le contenu du dossier "images"
            // Directory.GetFile c'est pour retourner un fichier.
            image = Directory.GetFiles(dossierCourant + "\\Images");
            Image2 = (dossierCourant + "\\Images");

            // Je retourn le tableau "image" qui contient les chemins + les images
            return image;
        }

        public static void TableauImageSansChemin()
        {
            ChargerImage();
            for (int i = 0; i < image.Length; i++)
            {
                int longueurCheminPlusImage = image[i].Length;

                // qu'il commande de compter apartir de "longueurCheminPlusImage-13 caractére" et qu'il compte 13 caractéres 
                string nomImageSansChemin = image[i].Substring(longueurCheminPlusImage - 13, 13);

                listeImageSansChemain.Add(nomImageSansChemin);
            }
        }
        //-------------------Méthode PositionImageDansListe--------------------------------------------

        public static int PositionImageDansListe()
        {
            string nomImageDansLaQuestionCourante = listeQuestionAleatoire[indexQuestion].nomImage;

            int indexImage = listeImageSansChemain.IndexOf(nomImageDansLaQuestionCourante);

            return indexImage;
        }

        //-------------------------------------------FrmAjouterDesQuestions----------------------------------------------

        public static void EffacerBoiteDeTexte(GroupBox grbAjoutQuestion)
        {
            foreach (Control controles in grbAjoutQuestion.Controls)
            {
                if (controles.GetType() == typeof(TextBox))
                {
                    ((TextBox)controles).Clear();
                }
            }
        }
        //-------------------------AffichageDansfrmAjouterDesQuestions --------------------------------------------

        public static void AffichageDansfrmAjouterDesQuestions
            (TextBox txtQuestion, TextBox txtReponse1, TextBox txtReponse2, TextBox txtReponse3, 
            TextBox txtLabonneReponse, PictureBox pibImage, int pointeurEnregistrement,int indexImage)
        {
            txtQuestion.Text = Didacticiel.listeQuestion[pointeurEnregistrement].Question;
           txtReponse1.Text= Didacticiel.listeQuestion[pointeurEnregistrement].Reponse1;
           txtReponse2.Text= Didacticiel.listeQuestion[pointeurEnregistrement].Reponse2;
           txtReponse3.Text= Didacticiel.listeQuestion[pointeurEnregistrement].Reponse3;
           txtLabonneReponse.Text = Didacticiel.listeQuestion[pointeurEnregistrement].BonneReponse.ToString();

           try
           {
               pibImage.Image = Image.FromFile(image[pointeurEnregistrement]);
               pibImage.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           catch (IndexOutOfRangeException)
           {
               MessageBox.Show("Une image n'est pas bien nommé...vérifier dans le fichier image");
           
           }
        
        }

        //-------------------------AffichagePointeurEnregistrement --------------------------------------------
        public static void AffichagePointeurEnregistrement(int pointeurEnregistrement, GroupBox grbAjoutQuestion)
        {
            grbAjoutQuestion.Text = pointeurEnregistrement + 1 + "/" + Didacticiel.listeQuestion.Count;
        
        
        }
        //--------------------------------ModifierUnEnregistrement---------------------------------------
        public static string ModifierUnEnregistrement
            (string Question,string Reponse1,string Reponse2,string Reponse3,int LaBonneReponse,string nomImage, int pointeurEnregistrement)
        {
            Didacticiel.listeQuestion[pointeurEnregistrement].Question = Question;
            Didacticiel.listeQuestion[pointeurEnregistrement].Reponse1 = Reponse1;
            Didacticiel.listeQuestion[pointeurEnregistrement].Reponse2 = Reponse2;
            Didacticiel.listeQuestion[pointeurEnregistrement].Reponse3 = Reponse3;
            Didacticiel.listeQuestion[pointeurEnregistrement].BonneReponse = LaBonneReponse;
            Didacticiel.listeQuestion[pointeurEnregistrement].NomImage = nomImage;

        
            // La remise dans le fichier
            AjoutQuestionDansFichier(FrmGestionDesQuestions.nomFichier);

            // Par mesure de sécurité,remettre le contenu du fichier dans la liste "listeQuestion" (optionnel)

            Didacticiel.LectureQuestionDansFichier(FrmGestionDesQuestions.nomFichier);


            return "modification réaliser avec succés";
        }
        //---------------------------------------SuppressionUnEnregistrement------------------------------------
        public static string SuppressionUnEnregistrement(int pointeurEnregistrement)
        {
            Didacticiel.listeQuestion.RemoveAt(pointeurEnregistrement);

            //La remise ajour dans le fichier

            Didacticiel.AjoutQuestionDansFichier(FrmGestionDesQuestions.nomFichier);

            // Par mesure de sécurité,remettre le contenu du fichier dans la liste "listeQuestion" (optionnel)

            Didacticiel.LectureQuestionDansFichier(FrmGestionDesQuestions.nomFichier);

            return "La suppression réaliser avec succés";
        
        }
        //-------------------------------------- Début ConfigCompteurTempsQuestion-------------------------------------
        public static void ConfigCompteurTempsQuestion(Panel pnlProgresse, Panel PnlBackground, Timer tmrCompteur)
        {
            int PositionRBselectionner = 0;
            pnlProgresse.Width += 3;

            if (pnlProgresse.Width == PnlBackground.Width)
            {
                tmrCompteur.Stop();
                MessageBox.Show("temps est écoulé");
                PositionRBselectionner = 0;
                Didacticiel.ValiderReponse(PositionRBselectionner);
                ConfigCompteurTempsQuestion(pnlProgresse, tmrCompteur);
            }      
        }
        //-------------------------------------- Fin ConfigCompteurTempsQuestion-------------------------------------
        //--------------------------------------Début BarreProgresse -------------------------------------------------
        public static void ConfigCompteurTempsQuestion(Panel pnlProgresse,Timer tmrCompteur)
        {
            pnlProgresse.Width = 22;
            tmrCompteur.Start();
        }
        //--------------------------------------Fin BarreProgresse----------------------------------------------------
        //-------------------------------------- Début DeconnecterDidactitiel-------------------------------------
        public static void DeconnecterDidactitiel(Timer tmrCompteur)
        {
            tmrCompteur.Stop();
            DialogResult dialogueResulat = MessageBox.Show("êtres vous sûr de fermer la session..?", "déconnexion", MessageBoxButtons.YesNo);
            if (dialogueResulat == DialogResult.Yes)
            {
                Didacticiel.listeQuestion.Clear();
                Didacticiel.listeQuestionAleatoire.Clear();
                Didacticiel.listeNombreAleatoire.Clear();
                Didacticiel.indexQuestion = 0;

                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            else if (dialogueResulat == DialogResult.No)
            {
                dialogueResulat = DialogResult.Cancel;
                tmrCompteur.Start();
            }
        }

        //-------------------------------------- Fin DeconnecterDidactitiel-------------------------------------
        //-------------------------------------- Début telechargerImage-------------------------------------
        public static void telechargerImage(TextBox txtCache, TextBox txtUpload, PictureBox pibImage)
        {
            OpenFileDialog maPhoto = new OpenFileDialog();
            maPhoto.Filter = "type d'images (*.jpg; *.png; *.gif;)|**.jpg; *.png; *.gif;";
            maPhoto.InitialDirectory = Directory.GetCurrentDirectory();

            if (maPhoto.ShowDialog() == DialogResult.OK)
            {
                maPhoto.InitialDirectory = Directory.GetCurrentDirectory();
                txtCache.Text = maPhoto.FileName;
                txtUpload.Text = maPhoto.SafeFileName;
                pibImage.Image = new Bitmap(maPhoto.FileName);
            }
        }
        //-------------------------------------- Fin telechargerImage-------------------------------------
        public static void AffichageReponses(ListBox lstAfficherReponse ,RadioButton radRep1,
            RadioButton radRep2, RadioButton radRep3, int positionBouttonRadioSelectionne)
        {
            if (listeQuestionAleatoire[indexQuestion-1].bonneReponse == positionBouttonRadioSelectionne)
            {
                lstAfficherReponse.Items.Add("Bonne reponse");
            }
            else
            {
                lstAfficherReponse.Items.Add("Mauvaise réponse");


                if (listeQuestionAleatoire[indexQuestion - 1].bonneReponse == 1)
                {
                    Didacticiel.reponse = radRep1.Text;
                }
                else if (listeQuestionAleatoire[indexQuestion - 1].bonneReponse == 2)
                {
                    Didacticiel.reponse = radRep2.Text;

                }
                else if (listeQuestionAleatoire[indexQuestion - 1].bonneReponse == 3)
                {

                    Didacticiel.reponse = radRep3.Text;

                }

                lstAfficherReponse.Items.Add(listeQuestionAleatoire[indexQuestion - 1].question + "--->" + Didacticiel.reponse);
            }

        }
        //---------------------------------------Début méthode findedidacticiel----------------------------------------------------------------
        public static void Findedidacticiel(Timer tmrCompteur, TextBox txtPoints, TextBox txtLogin, TextBox txtMotDePasse, GroupBox grbAffichageQuestion,
            Button btnValiderReponse, Button btnDebuterDidacticiel, ListBox lstAffichage, ListBox lstAffichageNombreAleatoireTest, ListBox lstAfficherListeQuestionAleatoireTest)

        {
                    tmrCompteur.Enabled = false;
                    MessageBox.Show("Fin du questionnaire ... tu as obtenus :" + Didacticiel.pointObtenu.ToString() + " / " +
                    (Didacticiel.listeNombreAleatoire.Count()) * 10);

                    int pObtenus = Didacticiel.pointObtenu;
                    txtPoints.Text = (Didacticiel.pointObtenu).ToString();
                    Utilisateurs.ModifierpointsObtenus(txtLogin, txtMotDePasse, pObtenus);

                    grbAffichageQuestion.Enabled = false;
                    btnValiderReponse.Enabled = false;
                    btnDebuterDidacticiel.Enabled = false;
                    //Didacticiel.pointObtenu = 0;
                    Didacticiel.listeQuestion.Clear();
                    Utilisateurs.listeUtilisateurs.Clear();
                    Didacticiel.listeQuestionAleatoire.Clear();
                    Didacticiel.listeNombreAleatoire.Clear();
                    Didacticiel.indexQuestion = 0;

                    lstAffichage.Items.Clear();
                    lstAffichageNombreAleatoireTest.Items.Clear();
                    lstAfficherListeQuestionAleatoireTest.Items.Clear();

    }
        //---------------------------------------Fin méthode findedidacticiel----------------------------------------------------------------
        //---------------------------------------Début méthode (Affichage)BonnesEtMauvausesReponses----------------------------------------------------------------
        public static void BonnesEtMauvausesReponses(ListBox lstAfficherReponse)
        {

            bonnesReponses = Didacticiel.pointObtenu / 10;
            mauvaisesReponse =Didacticiel.listeNombreAleatoire.Count - bonnesReponses;

            lstAfficherReponse.Items.Add("Bonnes réponses :   "+bonnesReponses.ToString()+"  Mauvaises réponses :   "+mauvaisesReponse.ToString());
 
        }
        //---------------------------------------Fin méthode (Affichage) BonnesEtMauvausesReponses----------------------------------------------------------------


    }
}