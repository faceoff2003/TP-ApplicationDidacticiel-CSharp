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
    public partial class FrmTableauDeBord : Form
    {
        public FrmTableauDeBord()
        {
            InitializeComponent();
        }

        private void btnAjouterUnUtilisateur_Click(object sender, EventArgs e)
        {

            FrmGestionUtilisateur frmAjoutUtilisateur = new FrmGestionUtilisateur();
            frmAjoutUtilisateur.Show();
            this.Hide();
        }

        private void btnAjouterDesQuestions_Click(object sender, EventArgs e)
        {
            //lblTitre.Text = "Ajouter des questions";
            //btnAjouterDesQuestions.BackColor = Color.FromArgb(0, 150, 136);
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
                this.Hide();
            }
        }

        private void FrmTableauDeBord_Load(object sender, EventArgs e)
        {
            //btnRapportsQuestionnaires.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuiz adminTestes = new FrmQuiz();
            adminTestes.Show();
            this.Hide();

        }

        private void btnRapportsQuestionnaires_Click(object sender, EventArgs e)
        {
            FrmRapportDesQuestionnaires frmRapportDesQuestionnaires = new FrmRapportDesQuestionnaires();
            frmRapportDesQuestionnaires.Show();
            this.Hide();
        }
    }
}
