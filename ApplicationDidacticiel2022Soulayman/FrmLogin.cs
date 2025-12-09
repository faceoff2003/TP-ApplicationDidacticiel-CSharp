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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtNomUtilisateur.Text = null;
            txtMotDePasse.Text = null;
        }

        private void pnlIdentification_Paint(object sender, PaintEventArgs e)
        {
            pnlIdentification.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txtNomUtilisateur_Enter(object sender, EventArgs e)
        {
            if (txtNomUtilisateur.Text == "nom d'utilisateur")
            {
                txtNomUtilisateur.Text = "";
            }
        }

        private void txtMotDePasse_Enter(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "Mot de passe")
            {
                txtMotDePasse.Text = "";
            }
        }

        private void txtNomUtilisateur_Leave(object sender, EventArgs e)
        {
            if (txtNomUtilisateur.Text == "")
            {
                txtNomUtilisateur.Text = "nom d'utilisateur";
            }
        }

        private void txtMotDePasse_Leave(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "")
            {
                txtMotDePasse.Text = "Mot de passe";
            }
        }

        private void cbAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfficherMotDePasse.Checked)
            {
                txtMotDePasse.UseSystemPasswordChar = true;

            }

            else
            {
                txtMotDePasse.UseSystemPasswordChar = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bool videOuPas = Utilisateurs.fichierVideOuPas(FrmGestionUtilisateur.nomFichier);
            if (videOuPas == true)
            {
                MessageBox.Show("Le Fichier est vide");

            }
            else
            {
                //MessageBox.Show("Le fichier n'est pas vide");
                Utilisateurs.LectureUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);


            }


        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Utilisateurs.Connexion(txtNomUtilisateur, txtMotDePasse);
        }

        private void txtNomUtilisateur_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }
    }

    public partial class CopyOfFrmLogin : Form
    {
        FrmQuiz adminTestes = new FrmQuiz();

        public CopyOfFrmLogin()
        {
            InitializeComponent();

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtNomUtilisateur.Text = null;
            txtMotDePasse.Text = null;
        }

        private void pnlIdentification_Paint(object sender, PaintEventArgs e)
        {
            pnlIdentification.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void txtNomUtilisateur_Enter(object sender, EventArgs e)
        {
            if (txtNomUtilisateur.Text == "nom d'utilisateur")
            {
                txtNomUtilisateur.Text = "";
            }
        }

        private void txtMotDePasse_Enter(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "Mot de passe")
            {
                txtMotDePasse.Text = "";
            }
        }

        private void txtNomUtilisateur_Leave(object sender, EventArgs e)
        {
            if (txtNomUtilisateur.Text == "")
            {
                txtNomUtilisateur.Text = "nom d'utilisateur";
            }
        }

        private void txtMotDePasse_Leave(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "")
            {
                txtMotDePasse.Text = "Mot de passe";
            }
        }

        private void cbAfficherMotDePasse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfficherMotDePasse.Checked)
            {
                txtMotDePasse.UseSystemPasswordChar = true;

            }

            else
            {
                txtMotDePasse.UseSystemPasswordChar = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bool videOuPas = Utilisateurs.fichierVideOuPas(FrmGestionUtilisateur.nomFichier);
            if (videOuPas == true)
            {
                MessageBox.Show("Le Fichier est vide");

            }
            else
            {
                //MessageBox.Show("Le fichier n'est pas vide");
                Utilisateurs.LectureUtilisateursDansFichier(FrmGestionUtilisateur.nomFichier);


            }


        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Utilisateurs.Connexion(txtNomUtilisateur, txtMotDePasse);

        }

        private void txtNomUtilisateur_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }

        private void txtMotDePasse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chiffreLettre = 'C';
            Utilisateurs.BlindageBoiteDeTexte(chiffreLettre, e);
        }
    }
}
