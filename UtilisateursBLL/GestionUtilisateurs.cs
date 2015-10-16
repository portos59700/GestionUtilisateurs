using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursDAL; // Référence la couche DAL

namespace UtilisateursBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }

        // Méthode qui créer un nouvel objet Utilisateur à partir de son id et de son nom et qui le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(string nom)
        {
            Utilisateur ut;
            ut = new Utilisateur(nom);
            return UtilisateurDAO.AjoutUtilisateur(ut);
        }

        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(int id, string nom)
        {
            Utilisateur ut;
            ut = new Utilisateur(id, nom);
            return UtilisateurDAO.UpdateUtilisateur(ut);
        }

        // Méthode qui supprime un Utilisateur avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerUtilisateur(int id)
        {
            return UtilisateurDAO.DeleteUtilisateur(id);
        }
    }
}
