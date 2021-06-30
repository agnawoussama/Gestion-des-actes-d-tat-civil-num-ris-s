using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_actes_d_état_civil_numérisés
{
    class Enfant
    {
        //Attributs
        int id;
        string nom;
        string prenom;
        string sexe;
        DateTime dateNaissance;

        //proprietes
        public int Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Sexe { get { return sexe; } set { sexe = value; } }
        public DateTime DateNaissance { get { return dateNaissance; } set { dateNaissance = value; } }

        public Enfant()
        {

        }

        public Enfant(int id, string nom,string prenom,string sexe,DateTime dateNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNaissance = dateNaissance;      
        }


        public override string ToString()
        {
            return $"Le id: {id}\nLe nom: {nom}\nLe prenom: {prenom}\nLe sexe: {sexe}\nLa date de naissance: {dateNaissance}\n";
        }
    }
}
