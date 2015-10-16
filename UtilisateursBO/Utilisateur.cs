using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Utilisateur
    {
        private int Id_Utilisateur;
        private string Nom_Utilisateur;

        public Utilisateur(string NomUti)
        {
            Nom_Utilisateur = NomUti;
        }

        public Utilisateur( int IdUti, string NomUti)
        {
            Nom_Utilisateur = NomUti;
            Id_Utilisateur = IdUti;
        }

        public string Nom
        {
            get { return Nom_Utilisateur; }
            set { Nom_Utilisateur = value; }
        }

        public int Id
        {
            get { return Id_Utilisateur; }
            set { Id_Utilisateur = value; }
        }
    }
}
