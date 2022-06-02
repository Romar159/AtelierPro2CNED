using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using AtelierPro2CNED.Connexion;
using Npgsql;


namespace AtelierPro2CNED
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection sqlcon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On centre la fenêtre de connexion
            PANEL_Connexion.Location = new Point((this.Size.Width / 2) - PANEL_Connexion.Size.Width / 2, (this.Size.Height / 2) - PANEL_Connexion.Size.Height / 2);
            PANEL_AjoutPersonnel.Visible = false;
            PANEL_Absence.Visible = false;

            HideMainInterface();
        }

        private void HideMainInterface()
        {
            PANEL_Connexion.Show();
            PANEL_MainInterface.Hide();
        }
        private void ShowMainInterface(NpgsqlConnection sqlconnection)
        {
            PANEL_Connexion.Hide();
            PANEL_MainInterface.Show();
            // Afficher tous les personnels dans la liste dès l'affichage de l'application.
            showAllPersonnels(sqlconnection);
        }

        private void showAllPersonnels(NpgsqlConnection connection) {
           
            connection.Open();
            //récupère le nom de chaque personnel
            string sql = "SELECT nom FROM db.personnels";

            // execution de la requête et stockage dans une DataTable
            DataTable dt = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(command);
            ad.Fill(dt);

            NpgsqlDataReader dRead = command.ExecuteReader();

            while (dRead.Read()) {
                foreach (DataRow row in dt.Rows) {
                    for (int i = 0; i < dt.Rows.Count; i++) {
                        LB_Personnels.Items.Add(row[i].ToString());
                    }
                }
            }

            connection.Close();
        }

        

        private void BTN_Connect_Click_1(object sender, EventArgs e)
        {
            Connect connection = new Connect(TB_user.Text.ToString(), TB_pass.Text.ToString());
            sqlcon = connection.connexion();

            if (sqlcon != null) {
                ShowMainInterface(sqlcon);
            } else {
                MessageBox.Show("Erreur. Le mot de passe ou le nom d'utilisateur est incorrect.", "Erreur de connexion.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSM_AjouterPersonnel_Click(object sender, EventArgs e)
        {
            PANEL_AjoutPersonnel.Visible = true;

            BTN_AjoutPersonnel.Visible = true;
            BTN_Modifier.Visible = false;
        }

        private void TSM_modifierPersonnel_Click(object sender, EventArgs e)
        {
            //Vérification si un personnel est bien séléctionné dans la liste.
            if(LB_Personnels.SelectedItem != null)
            {
                PANEL_AjoutPersonnel.Visible = true;

                BTN_AjoutPersonnel.Visible = false;
                BTN_Modifier.Visible = true;
                TB_NomPersonnel.Text = /*BDD -> nom*/"";
                TB_PrenomPersonnel.Text = /*BDD -> prenom*/"";
                TB_mailPersonnel.Text = /*BDD -> mail*/"";
                TB_TelPersonnel.Text = /*BDD -> tel*/"";
            } else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.");
            }
            
        }

        private void TSM_SupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous vraiment supprimer ce personnel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                Personnel nouveauPersonnel = new Personnel();
                nouveauPersonnel.supprimer(sqlcon, /*BDD-> nom*/"", /*BDD-> prenom*/"");
            }
        }

        private void TSM_AjouterAbsence_Click(object sender, EventArgs e)
        {
            if (LB_Personnels.SelectedItem != null)
            {
                PANEL_Absence.Visible = true;

                BTN_AjoutAbsence.Visible = true;
                BTN_ModifierAbsence.Visible = false;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.");
            }

        }

        private void TSM_ModifierAbsence_Click(object sender, EventArgs e)
        {
            if (LB_Personnels.SelectedItem != null)
            {
                PANEL_Absence.Visible = true;

                BTN_AjoutAbsence.Visible = false;
                BTN_ModifierAbsence.Visible = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.");
            }
        }


        private void BTN_AjoutPersonnel_Click(object sender, EventArgs e)
        {
            //Ajouter un personnel dans la base de donnée.
            Personnel nouveauPersonnel = new Personnel();
            if(nouveauPersonnel.ajouter(sqlcon, TB_NomPersonnel.Text, TB_PrenomPersonnel.Text, TB_mailPersonnel.Text, TB_TelPersonnel.Text)) {
                // Efface le contenu du formulaire d'ajout/modification et le cache quand c'est terminé.
                TB_NomPersonnel.Text = "";
                TB_PrenomPersonnel.Text = "";
                TB_mailPersonnel.Text = "";
                TB_TelPersonnel.Text = "";
                PANEL_AjoutPersonnel.Visible = false;
            } else {
                MessageBox.Show("Erreur. Certains champs de texte ne sont pas complet.");
            }

            
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            //Modifie un personnel dans la base de donnée.
            Personnel nouveauPersonnel = new Personnel();
            if (nouveauPersonnel.modifier(sqlcon, TB_NomPersonnel.Text, TB_PrenomPersonnel.Text, TB_mailPersonnel.Text, TB_TelPersonnel.Text))
            {
                // Efface le contenu du formulaire d'ajout/modification et le cache quand c'est terminé.
                TB_NomPersonnel.Text = "";
                TB_PrenomPersonnel.Text = "";
                TB_mailPersonnel.Text = "";
                TB_TelPersonnel.Text = "";
                PANEL_AjoutPersonnel.Visible = false;
            }
            else
            {
                MessageBox.Show("Erreur. Certains champs de texte ne sont pas complet.");
            }
        }

        private void BTN_CancelAjoutPersonnel_Click(object sender, EventArgs e)
        {
            // Lors de l'annulation d'ajout/modification
            // Efface le contenu du formulaire d'ajout/modification et le cache.
            TB_NomPersonnel.Text = "";
            TB_PrenomPersonnel.Text = "";
            TB_mailPersonnel.Text = "";
            TB_TelPersonnel.Text = "";
            PANEL_AjoutPersonnel.Visible = false;
        }

        private void BTN_ModifierAbsence_Click(object sender, EventArgs e)
        {
            Absence nouvelleAbsence = new Absence();
            nouvelleAbsence.modifier(DATE_Deb.Value, DATE_End.Value, CB_Motif.Text);
            PANEL_Absence.Visible = false;
        }

        private void BTN_AjoutAbsence_Click(object sender, EventArgs e)
        {
            Absence nouvelleAbsence = new Absence();
            nouvelleAbsence.ajouter(DATE_Deb.Value, DATE_End.Value, CB_Motif.Text);
            PANEL_Absence.Visible = false;

        }

        private void BTN_cancelAjoutAbsence_Click(object sender, EventArgs e)
        {
            PANEL_Absence.Visible = false;
        }

        private void TSM_AfficherAbsence_Click(object sender, EventArgs e)
        {
            Absence nouvelleAbsence = new Absence();
            nouvelleAbsence.afficher(sqlcon, /*BDD-> nom personnel*/"", /*BDD-> prenom personnel*/"");
        }

        private void TSM_SupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer l'absence de ce personnel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Absence nouvelleAbsence = new Absence();
                nouvelleAbsence.supprimer(sqlcon, /*BDD-> nom personnel*/"", /*BDD-> prenom personnel*/"");
            }
        }
    }
}
