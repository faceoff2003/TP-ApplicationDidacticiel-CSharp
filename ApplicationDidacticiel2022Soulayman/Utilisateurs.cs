using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace ApplicationDidacticiel2022Soulayman
{
    class Utilisateurs
    {
        // Liste<> contenant les utilisateurs

        public static List<Utilisateurs> listeUtilisateurs = new List<Utilisateurs>();

        // Tableau contenant les champs de la ligne du fichier

        private static string[] champs;

        public static int nombreEssai;

        public static string nomUtilisateur;
        public static string PrenomUtilisateur;
        public static int points;

        // Attribus--------------------------

        private string nom;
        private string prenom;
        private string login;
        private string motDePasse;
        private int pointsObtenus;
        private bool admin;
        private DateTime dateExamen;

        // Constructeurs Paramétré-----------------------------------------------

        public Utilisateurs(string nom, string prenom, string login, string motDePasse, int pointsObtenus,bool admin,DateTime dateExamen)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.MotDePasse = motDePasse;
            this.PointsObtenus = pointsObtenus;
            this.admin = admin;
            this.dateExamen = dateExamen;
        }

        public Utilisateurs(string nom, string prenom, string login, string motDePasse, bool admin, DateTime dateExamen)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = login;
            this.MotDePasse = motDePasse;
            this.admin = admin;
            this.dateExamen = dateExamen;
        }

        // Constructeurs Par défaut----------------------------------------

        public Utilisateurs() { }

        // les membres------------------------------------------

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

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string MotDePasse
        {
            get { return motDePasse; }
            set { motDePasse = value; }
        }

        public int PointsObtenus
        {
            get { return pointsObtenus; }
            set { pointsObtenus = value; }
        }

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        public DateTime DateExamen
        {
            get { return dateExamen; }
            set { dateExamen = value; }
        }


        // les méthodes-------------------------------------------------------------------------

        //----------------------------Début de Méthode AjoutUtilisateurDansListe-------------------------

        public static void AjoutUtilisateursDansListe(Utilisateurs utilisateurs)
        {
            // On ajoute les objets de type "Didacticiel"dans la liste "listeQuestion"

            listeUtilisateurs.Add(utilisateurs);

        }
        //----------------------------Fin de Méthode AjoutUtilisateurDansListe-------------------------

        //----------------------------Début de Méthode AjoutUtilisateurDansFichier-------------------------

        public static void AjoutUtilisateursDansFichier(string nomDuFichier)
        {
            StreamWriter streamWriter = new StreamWriter(nomDuFichier);

            for (int i = 0; i < listeUtilisateurs.Count; i++)
            {

                streamWriter.WriteLine(listeUtilisateurs[i].nom + ";" + listeUtilisateurs[i].prenom + ";" + listeUtilisateurs[i].login + ";" +
                    listeUtilisateurs[i].motDePasse + ";" + listeUtilisateurs[i].pointsObtenus + ";" + listeUtilisateurs[i].admin + ";" +
                    listeUtilisateurs[i].dateExamen + ";");
            }

            streamWriter.Close();

        }
        //----------------------------Fin de Méthode AjoutUtilisateurDansFichier-------------------------
        //----------------------------Début de Méthode LectureUtilisateurDansFichier------------------------

        public static void LectureUtilisateursDansFichier(string nomDuFichier)
        {
            listeUtilisateurs.Clear();
            StreamReader streamReader = new StreamReader(nomDuFichier);

            string lectureLigneFichier = streamReader.ReadLine();

            while (lectureLigneFichier != null)
            {
                champs = lectureLigneFichier.Split(';');

                Utilisateurs utilisateurslogin = new Utilisateurs
                    (champs[0], champs[1], champs[2], champs[3], Convert.ToInt32(champs[4]),Convert.ToBoolean(champs[5]),Convert.ToDateTime(champs[6]));

                Utilisateurs.AjoutUtilisateursDansListe(utilisateurslogin);
                lectureLigneFichier = streamReader.ReadLine();
            }
            streamReader.Close();
        }
        //----------------------------Fin de Méthode LectureUtilisateurDansFichier------------------------
        //----------------------------Début de Méthode AffichageUtilisateurslogin------------------------
        public static void AffichageUtilisateurslogin(TextBox nom, TextBox prenom,
            TextBox login, TextBox motdepasse, TextBox pointsObtenus,CheckBox admin,TextBox dateExamen, int pointeurEnregistrement)
        {

            nom.Text = Utilisateurs.listeUtilisateurs[pointeurEnregistrement].nom;
            prenom.Text = Utilisateurs.listeUtilisateurs[pointeurEnregistrement].prenom;
            login.Text = Utilisateurs.listeUtilisateurs[pointeurEnregistrement].login;
            motdepasse.Text = Utilisateurs.listeUtilisateurs[pointeurEnregistrement].motDePasse;
            pointsObtenus.Text = (Utilisateurs.listeUtilisateurs[pointeurEnregistrement].pointsObtenus).ToString();
            admin.Checked =Utilisateurs.listeUtilisateurs[pointeurEnregistrement].admin;
            dateExamen.Text=(Utilisateurs.listeUtilisateurs[pointeurEnregistrement].dateExamen).ToString();

        }
        //----------------------------Début de Méthode AffichagePointeurEnregistrement------------------------
        public static void AffichagePointeurEnregistrement(int pointeurEnregistrement, GroupBox GrbFicheEtudiant)
        {
            GrbFicheEtudiant.Text = pointeurEnregistrement + 1 + "/" + Utilisateurs.listeUtilisateurs.Count();

        }
        //----------------------------Fin de Méthode AffichageUtilisateurslogin------------------------
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
        //----------------------------Début de Méthode EffacerBoiteDeTexte-------------------------
        public static void EffacerBoiteDeTexte(GroupBox grbAjoutUtilisateur)
        {
            foreach (Control controles in grbAjoutUtilisateur.Controls)
            {
                if (controles.GetType() == typeof(TextBox))
                {
                    ((TextBox)controles).Clear();
                }
            }

        }
        //----------------------------Fin de Méthode EffacerBoiteDeTexte-------------------------
        //----------------------------Début de Méthode Connexion-------------------------

        public static void Connexion(TextBox txtNomUtilisateur, TextBox txtMotDePasse)
        {
            string login = txtNomUtilisateur.Text;
            string motDePasse = txtMotDePasse.Text;
            FrmLogin frmLogin = new FrmLogin();
            FrmTableauDeBord frmTableauDeBord = new FrmTableauDeBord();
            List<Utilisateurs> listeLoginMotDePasse = Utilisateurs.listeUtilisateurs;
            FrmQuiz adminTestes = new FrmQuiz();

            Utilisateurs.nombreEssai++;
            bool trouve = false;

            if ((txtNomUtilisateur.Text == "admin") && (txtMotDePasse.Text == "admin"))
            {
                trouve = true;
                FrmLogin.ActiveForm.Hide();
                frmTableauDeBord.Show();
                txtNomUtilisateur.Clear();
                txtMotDePasse.Clear();
            }
            else
            {
                foreach (Utilisateurs item in listeLoginMotDePasse)
                {
                    if ((item.Login == login) && (item.MotDePasse == motDePasse)
                        && (item.Admin == true) && (Utilisateurs.nombreEssai <= 3))
                    {
                        MessageBox.Show("Bienvenue : " + item.Nom + " " + item.Prenom);

                        trouve = true;
                        FrmLogin.ActiveForm.Hide();
                        frmTableauDeBord.Show();
                        txtNomUtilisateur.Clear();
                        txtMotDePasse.Clear();
                        Utilisateurs.nombreEssai = 0;
                        FrmLogin.ActiveForm.Hide();

                        break;
                    }
                    if ((item.Login == login) && (item.MotDePasse == motDePasse)
                        && (item.Admin == false) && (item.PointsObtenus==0) && (Utilisateurs.nombreEssai <= 3))
                    {
                        MessageBox.Show("Bienvenue : " + item.Nom + " " + item.Prenom);

                        nomUtilisateur = item.Nom;
                        PrenomUtilisateur = item.Prenom;
                        points = item.PointsObtenus;
                        trouve = true;
                        FrmLogin.ActiveForm.Hide();
                        adminTestes.Show();
                        txtNomUtilisateur.Clear();
                        txtMotDePasse.Clear();

                        Utilisateurs.nombreEssai = 0;
                        break;
                    }

                    if ((item.Login == login) && (item.MotDePasse == motDePasse) && (item.PointsObtenus != 0)
                            && (item.Admin == false) && (Utilisateurs.nombreEssai <= 3))
                        {
                            trouve = true;
                            MessageBox.Show("Bienvenue : " + item.Nom + " " + item.Prenom +" Vous avez déja fait le questionnaire");
                           
                            txtNomUtilisateur.Clear();
                            txtMotDePasse.Clear();
                            txtNomUtilisateur.Focus();

                            //Utilisateurs.nombreEssai = 0;
                            break;
                        }
                    }
                    }
                    //}
                    if ((trouve == false) && (Utilisateurs.nombreEssai <= 3))
                    {

                        MessageBox.Show("Le mot de passe ou le login est érronés....");

                        txtNomUtilisateur.Clear();
                        txtMotDePasse.Clear();
                        txtNomUtilisateur.Focus();

                    }

                    if (Utilisateurs.nombreEssai >= 3)
                    {

                        MessageBox.Show("Contactez l'administrateur....");
                        FrmLogin.ActiveForm.Close();
                    }

                } 
        
        //----------------------------Fin de Méthode Connexion-------------------------
        //----------------------------Début de Méthode ChercherUtilisateurDansFichier-------------------------
        public static void ChercherUtilisateurDansFichier(TextBox txtLogin, TextBox txtMotDePasse, TextBox PointsObtenus)
        {

            string login = txtLogin.Text;
            string motDePasse = txtMotDePasse.Text;
            List<Utilisateurs> listeLoginMotDePasse = Utilisateurs.listeUtilisateurs;


            foreach (Utilisateurs item in listeLoginMotDePasse)
            {
                if ((item.Login == login) && (item.MotDePasse == motDePasse))
                {
                    txtLogin.Text = item.Nom;
                    txtMotDePasse.Text = item.Prenom;
                    PointsObtenus.Text = item.pointsObtenus.ToString();
                    break;
                }
            }
        }
        //----------------------------Fin de Méthode ChercherUtilisateurDansFichier-------------------------
        //----------------------------Début de Méthode ModifierUtilisateur---------------------------------- 
        public static string ModifierUtilisateur(string nom, string prenom, string login, string motDePasse, int pointsObtenus,
            bool admin,DateTime dateExamen,int pointeurEnregistrement)
    {
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].Nom = nom;
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].Prenom = prenom;
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].login = login;
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].MotDePasse = motDePasse;
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].PointsObtenus = pointsObtenus;
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].Admin=admin;
            Utilisateurs.listeUtilisateurs[pointeurEnregistrement].DateExamen=dateExamen;

            // remise ajour du fichier

            Utilisateurs.AjoutUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);

             // par sécurité remettre le contenu dans la liste

            Utilisateurs.LectureUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);

            return "Modifications réaliser avec succés";
    }

        //----------------------------Fin de Méthode ModifierUtilisateur---------------------------------------
        //----------------------------Début de Méthode ChercherUtilisateur---------------------------------- 
        public static int Recherche(string nomPrenomARechercher)
        {
            string[] nomPrenom = nomPrenomARechercher.Split(' ');
            int positionValeurRechercher = -1;

            for (int i = 0; i < listeUtilisateurs.Count; i++)
            {
                if (listeUtilisateurs[i].Nom == nomPrenom[0] &&
                    listeUtilisateurs[i].Prenom == nomPrenom[1])
                {
                    positionValeurRechercher = i;
                    break;
                
                }
            
            
            }
            return positionValeurRechercher;
        }
        //----------------------------Fin de Méthode ChercherUtilisateur---------------------------------- 
        //--------------------------------------- Début suppressionUnEnregistrement------------------------------------
        public static string SuppressionUnEnregistrement(int pointeurEnregistrement)
        {
            Utilisateurs.listeUtilisateurs.RemoveAt(pointeurEnregistrement);

            //La remise ajour dans le fichier

            Utilisateurs.AjoutUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);

            // Par mesure de sécurité,remettre le contenu du fichier dans la liste "listeQuestion" (optionnel)

            Utilisateurs.LectureUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);

            return "La suppression réaliser avec succés";
        
        }
        //--------------------------------------- Fin suppressionUnEnregistrement------------------------------------
        //----------------------------Début Méthode ModifierpointsObtenus----------------------------
        public static void ModifierpointsObtenus(TextBox nom, TextBox prenom, int pointsObtenus)
        { 
            string lenom = nom.Text;
            string leprenom = prenom.Text;
            DateTime dateExam = DateTime.Now;

            List<Utilisateurs> listeLoginMotDePasse = Utilisateurs.listeUtilisateurs;

            foreach (Utilisateurs item in listeLoginMotDePasse)
            {
                if ((item.Nom == lenom) && (item.Prenom == leprenom))
                {
                    item.pointsObtenus = pointsObtenus;
                    item.dateExamen = dateExam;

                    Utilisateurs.AjoutUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);

                    // par sécurité remettre le contenu dans la liste

                    Utilisateurs.LectureUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);
                    break;
                }
            }
        }
            //---------------------Début Methode desactiverBouttonsPourUtilisateurs----------------------------------------
        public static void desactiverBouttonsPourUtilisateurs
            (TextBox txtnom, TextBox txtprenom, Button gUtilisateurs, Button gQuestions, Button testes, Button autres, Button Raz, ListBox un, ListBox deux, ListBox trois)
        {
            if ((string.IsNullOrEmpty(txtnom.Text)) && (string.IsNullOrEmpty(txtprenom.Text)))
            {
            }
            else 
            {
                gUtilisateurs.Hide();
                gQuestions.Hide();
                testes.Hide();
                autres.Hide();
                Raz.Hide();
                un.Hide();
                deux.Hide();
                trois.Hide();
            }
        }
        //--------------------------------Début blindageTextBox----------------------------------------
        public static void BlindageBoiteDeTexte(char chiffreLettre, KeyPressEventArgs e)
        {
            string lettreChiffre;


            if (chiffreLettre == 'L')
            
                lettreChiffre = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrestuvwxyzéèê" + (char)8;
            
                else if  (chiffreLettre == 'C')
                    lettreChiffre = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrestuvwxyzéèê0123456789*-_.@" + (char)8;
                //lettreChiffre = "0123456789*-_." + (char)8;
            
            else
                lettreChiffre = "0123456789" + (char)8;

            //--------------------------------------------------------------------
            if (lettreChiffre.IndexOf(char.ToString(e.KeyChar)) == -1)

                e.KeyChar = (char)0;

        }
        //-----------------------------------------------------------------------------------------
    }



    }