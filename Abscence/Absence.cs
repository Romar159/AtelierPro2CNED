using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AtelierPro2CNED
{
    public class Absence
    {
        public Absence() {

        }

        public void afficher(NpgsqlConnection connection, string nom, string prenom)
        {
            // Affiche l'absence
        }
        public void ajouter(DateTime deb, DateTime fin, string motif)
        {
            // Permet l'ajout d'une absence
        }
        public void modifier(DateTime deb, DateTime fin, string motif)
        {
            // permet la modification d'une absence
        }
        public void supprimer(NpgsqlConnection connection, string nom, string prenom)
        {
            // permet la supression d'une absence
        }
    }
}
