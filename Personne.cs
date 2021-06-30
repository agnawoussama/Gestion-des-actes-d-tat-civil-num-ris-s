using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_actes_d_état_civil_numérisés
{
    class Personne
    {
        //Attributs
        int id;
        string nom;
        string prenom;
        string sexe;
        string pere;
        string mere;
        DateTime dateNaissance;       
        int nombreEnfants;
        //int[] idEnfants;

        //proprietes
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Sexe { get { return sexe; } set { sexe = value; } }
        public string Pere { get { return pere; } set { pere = value; } }
        public string Mere { get { return mere; } set { mere = value; } }
        public DateTime DateNaissance { get { return dateNaissance; } set { dateNaissance = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int NombreEnfants { get { return listEnfants.Count; } private set { nombreEnfants = value; } }
        //public int [] IdEnfants { get { return idEnfants; } set { idEnfants = value; } }

        public static List<Personne> listPersonnes = new List<Personne>();
        public List<Enfant> listEnfants = new List<Enfant>();

        public Personne()
        {

        }

        public Personne(int id,string nom,string prenom,string sexe, string pere,string mere,DateTime dateNaissance,int nombreEnfants/*,int [] idEnfants*/)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.pere = pere;
            this.mere = mere;
            this.dateNaissance = dateNaissance;           
            this.nombreEnfants = nombreEnfants;
            //this.idEnfants = idEnfants;
        }

        public override string ToString()
        {
            //StringBuilder result = new StringBuilder();

            //for (int i = 0; i < NombreEnfants; i++)
            //{
            //    result.Append($"    L'id de {i + 1} enfant: {idEnfants[i]}\n"); 
            //}
            return $"Le id: {id}\nLe nom: {nom}\nLe prenom: {prenom}\nLe sexe: {sexe}\nLe pere: {pere}\nLa mere: {mere}\nLa date de naissance: {dateNaissance}\n" /*+
                $"Le nombre d'enfants: {nombreEnfants}\nL'id des enfants: \n{result}"*/;
        }

        public void AjouterEnfant()
        {
            char q;
            do
            {
                Enfant enf = new Enfant();
                Console.WriteLine("Entrer le id de l'enfant:"); enf.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrer le nom de l'enfant:"); enf.Nom = Console.ReadLine();
                Console.WriteLine("Entrer le prenom de l'enfant:"); enf.Prenom = Console.ReadLine();
                Console.WriteLine("Entrer le sexe de l'enfant:"); enf.Sexe = Console.ReadLine();
                Console.WriteLine("Entrer la Date de naissance de l'enfant:"); enf.DateNaissance = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Voulez vous ajouter un nouveau enfant? (Appuyer sur Y pour ajouter / N pour quitter)");
                q = char.Parse(Console.ReadLine());
                listEnfants.Add(enf);
            } while (q != 'N');
        }

        public void AfficherEnfants()
        {
            foreach (Enfant e in listEnfants)
            {
                Console.WriteLine(e.ToString()); 
            }
        }
    }
}
