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
    class RapportQuestionnaire
    {
        //La zone des variables-------------------------------------------

        public static string FichierRapport = "RapportQuestionnaire.did";

       public static List<RapportQuestionnaire> listeRapportQuestionnaire = new List<RapportQuestionnaire>();

       // Tableau contenant les champs de la ligne du fichier

       private static string[] champs;


       public static string dureeExam;

       public static int positionValeurRechercher;



        // Attribus--------------------------
        private string nom;
        private string prenom;
        private int bonnesReponses;
        private int mauvaisesReponses;
        private int pointsObtenus;
        private string dureeExamen;
        private DateTime datePassage;

        // Constructeur paramétré-------------------------------------

       public RapportQuestionnaire(string nom, string prenom, int pointsObtenus, int bonneReponses, int mauvaisesReponses, string dureeExamen, DateTime datePassage)

        {
            this.nom = nom;
            this.prenom = prenom;
            this.pointsObtenus = pointsObtenus;
            this.bonnesReponses = bonneReponses;
            this.mauvaisesReponses = mauvaisesReponses;
            this.dureeExamen = dureeExamen;
            this.datePassage = datePassage;
        }

        // Constructeur par défaut--------------------------------------

       public RapportQuestionnaire() { }

        // Les memebres------------------------------------------------------


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public int BonnesReponses
        {
            get { return bonnesReponses; }
            set { bonnesReponses = value; }
        }

        public int MauvaisesReponses
        {
            get { return mauvaisesReponses; }
            set { mauvaisesReponses = value; }
        }

        public int PointsObtenus
        {
            get { return pointsObtenus; }
            set { pointsObtenus = value; }
        }

        public string DureeExamen
        {
            get { return dureeExamen; }
            set { dureeExamen = value; }
        }

        public DateTime DatePassage
        {
            get { return datePassage; }
            set { datePassage = value; }
        }

        // La zone des méthodes------------------------------------------------------------------------------------------------

        //-----------------------Début méthode FichierRapportVideOuPas--------------------------------------------------------
        public static bool FichierRapportVideOuPas()
        {
            StreamReader streamReader = new StreamReader(FichierRapport);
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
        //-----------------------Fin méthode FichierRapportVideOuPas--------------------------------------------------------
        //-----------------------Début méthode AjoutRapportDansListe--------------------------------------------------------
        public static void AjoutRapportDansListe(RapportQuestionnaire rapport)
        {

            listeRapportQuestionnaire.Add(rapport);
 
        }
        //-----------------------Fin méthode AjoutRapportDansListe--------------------------------------------------------
        //-----------------------Début méthode AjoutRapportDansFichier--------------------------------------------------------
        public static void AjoutRapportDansFichier()
        {
            StreamWriter streamWriter = new StreamWriter(FichierRapport);
            for (int i = 0; i < listeRapportQuestionnaire.Count; i++)
            {
                streamWriter.WriteLine(listeRapportQuestionnaire[i].Nom + ";" + listeRapportQuestionnaire[i].Prenom + ";" + listeRapportQuestionnaire[i].PointsObtenus + ";"
                    + listeRapportQuestionnaire[i].BonnesReponses + ";"+ listeRapportQuestionnaire[i].MauvaisesReponses 
                    + ";" + listeRapportQuestionnaire[i].DureeExamen + ";" + listeRapportQuestionnaire[i].DatePassage + ";");
            }
            streamWriter.Close();     
        }
        //-----------------------Fin méthode AjoutRapportDansFichier--------------------------------------------------------
        //----------------------------Début de Méthode LectureRapportDansFichier------------------------

        public static void LectureRapportDansFichier()
        {
            listeRapportQuestionnaire.Clear();
            StreamReader streamReader = new StreamReader(FichierRapport);

            string lectureLigneFichier = streamReader.ReadLine();

            while (lectureLigneFichier != null)
            {
                champs = lectureLigneFichier.Split(';');

                RapportQuestionnaire rapport = new RapportQuestionnaire
                    (champs[0], champs[1], Convert.ToInt32(champs[2]), Convert.ToInt32(champs[3]), Convert.ToInt32(champs[4]), champs[5], Convert.ToDateTime(champs[6]));

                RapportQuestionnaire.AjoutRapportDansListe(rapport);
                lectureLigneFichier = streamReader.ReadLine();
            }
            streamReader.Close();
        }
        //----------------------------Fin de Méthode LectureRapportDansFichier------------------------
        //----------------------------Début de Méthode AfficherRapportQuestionnaire------------------------
        public static void AfficherRapportQuestionnaire(TextBox txtNom, TextBox txtPrenom, TextBox txtpointsObtenus, TextBox txtBonnesReponses,
            TextBox txtmauvaiseReponses, TextBox txtdureeExamen, TextBox txtdatePassage,int indexRapport)
        {
            try
            {
                txtNom.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].Nom;
                txtPrenom.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].Prenom;
                txtpointsObtenus.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].PointsObtenus.ToString();
                txtBonnesReponses.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].BonnesReponses.ToString();
                txtmauvaiseReponses.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].MauvaisesReponses.ToString();
                txtdureeExamen.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].DureeExamen;
                txtdatePassage.Text = RapportQuestionnaire.listeRapportQuestionnaire[indexRapport].DatePassage.ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Le rapport n'existe pas,il faut passer le questionnaire d'abord....");
            
            }
        }

        //----------------------------Fin de Méthode AfficherRapportQuestionnaire------------------------
        //----------------------------Début de Méthode AffichagePointeurEnregistrementRapport------------------------
        public static void AffichagePointeurEnregistrementRapport(int pointeurEnregistrement, GroupBox GrbRapportsQuestions)
        {
            GrbRapportsQuestions.Text = pointeurEnregistrement + 1 + "/" + RapportQuestionnaire.listeRapportQuestionnaire.Count();

        }
        //----------------------------Fin de Méthode AffichagePointeurEnregistrementRapport------------------------
        //----------------------------Début de Méthode CalculerLaDureeDeQuiz----------------------
        public static void CalculerLaDureeDeQuiz(DateTime debutExamen, DateTime finExamen)
        {
            TimeSpan CalculeTemps;

            CalculeTemps = finExamen - debutExamen;

            dureeExam = CalculeTemps.Seconds.ToString();
        }

        //----------------------------Fin de Méthode AffichagePointeurEnregistrementRapport------------------------
        //----------------------------Début de Méthode ChercherRapport---------------------------------- 
        public static int RechercheRapport(string nomPrenomARechercher)
        {
            string[] nomPrenom = nomPrenomARechercher.Split(' ');
            positionValeurRechercher = -1;

            for (int i = 0; i <  listeRapportQuestionnaire.Count; i++)
            {
                if (listeRapportQuestionnaire[i].Nom == nomPrenom[0] &&
                    listeRapportQuestionnaire[i].Prenom == nomPrenom[1])
                {
                    positionValeurRechercher = i;
                    break;

                }
            }
            return positionValeurRechercher;
        }
        //----------------------------Fin de Méthode ChercherRapport---------------------------------- 
        //--------------------------------------- Début suppressionUnEnregistrement------------------------------------
        public static string SuppressionUnEnregistrement(int pointeurEnregistrement)
        {
            RapportQuestionnaire.listeRapportQuestionnaire.RemoveAt(pointeurEnregistrement);

            RapportQuestionnaire.AjoutRapportDansFichier();

            RapportQuestionnaire.LectureRapportDansFichier();

            return "La suppression réaliser avec succés";

        }
        //--------------------------------------- Fin suppressionUnEnregistrement------------------------------------

    }
}
