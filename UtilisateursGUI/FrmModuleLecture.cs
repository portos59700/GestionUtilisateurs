using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursBLL; // Référence la couche BLL
using UtilisateursBO; // Référence la couche BO


namespace UtilisateursGUI
{
    public partial class FrmModuleLecture : Form
    {
        public FrmModuleLecture()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Blocage de la génération automatique des colonnes
            dgv.AutoGenerateColumns = false;


            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Identifiant";


            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom de l'utilisateur";


            // Ajout des 2 en-têtes de colonne au datagridview
            dgv.Columns.Add(IdColumn);
            dgv.Columns.Add(NomColumn);


            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Utilisateur> liste = new List<Utilisateur>();
            liste = GestionUtilisateurs.GetUtilisateurs();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

        }

        private void btnActualiser_click(object sender, EventArgs e)
        {
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Utilisateur> liste = new List<Utilisateur>();
            liste = GestionUtilisateurs.GetUtilisateurs();

            // Rattachement de la List à la source de données du datagridview
            //dgv.DataSource = liste;

            //// CI-DESSOUS - CODE ALTERNATIF DE REMPLISSAGE DU DATAGRIDVIEW MAIS MOINS "PROPRE"

            //// Effacement de toutes les lignes
            //dgv.Rows.Clear();

            //// On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
            //dgv.Rows.Add(GestionUtilisateurs.GetUtilisateurs().Count);

            //// remplissage des lignes du datagridview
            //for (int i = 0; i < GestionUtilisateurs.GetUtilisateurs().Count; i++)
            //{
                //dgv[0, i].Value = GestionUtilisateurs.GetUtilisateurs()[i].GetIdUtilisateur();
                //dgv[1, i].Value = GestionUtilisateurs.GetUtilisateurs()[i].GetNomUtilisateur();
            //}

            //// CI-DESSUS - CODE ALTERNATIF DE REMPLISSAGE DU DATAGRIDVIEW MAIS MOINS "PROPRE"

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
