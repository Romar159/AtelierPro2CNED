using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AtelierPro2CNED
{
    public class Personnel
    {
        public Personnel() {

        }

        public bool ajouter(NpgsqlConnection connection, string nom, string prenom, string mail, string tel)
        {
            // Ajout du personnel dans la base de donnée.

            //Verification des champs
            if (nom == null || prenom == null || mail == null || tel == null) return false;
            else return true;
        }

        public bool modifier(NpgsqlConnection connection, string nom, string prenom, string mail, string tel)
        {
            // Modification des informations du personnel dans la base de donnée.
            //Verification des champs
            if (nom == null || prenom == null || mail == null || tel == null) return false;
            else return true;
        }

        public bool supprimer(NpgsqlConnection connection, string nom, string prenom)
        {
            // Suppression du personnel en recherchant son nom et son prénom.

            //Verification des champs
            if (nom == null || prenom == null) return false;
            else return true;
        }
    }
}
