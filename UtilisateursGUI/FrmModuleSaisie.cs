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
    public partial class FrmModuleSaisie : Form
    {
        public FrmModuleSaisie()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

        }

        // Code exécuté sur l'évènement Click du bouton Enregistrer
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Appel de la méthode CreerUtilisateur de la couche BLL
            GestionUtilisateurs.CreerUtilisateur(txtNom.Text);
        }


        private void FrmModuleLecture_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
