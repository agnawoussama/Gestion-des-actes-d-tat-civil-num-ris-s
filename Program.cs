using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_actes_d_état_civil_numérisés
{
    class Program
    {
        static void Main(string[] args)
        {


            //gestion des personnes
            int choice;
            do
            {
                Console.WriteLine("**************************Gestion des Personnes**********************");              
                Console.WriteLine("**                                                                 **");
                Console.WriteLine("**  Entrez 1 pour Ajouter un Personne                              **");
                Console.WriteLine("**  Entrez 2 pour Supprimer un Personne                            **");
                Console.WriteLine("**  Entrez 3 pour Mofifier un Personne                             **");
                Console.WriteLine("**  Entrez 4 pour Consulter la liste des Personnes                 **");
                Console.WriteLine("**  Entrez 5 pour Rechercher un Personne                           **");
                Console.WriteLine("**  Entrez 6 pour Retourner le nom de Pere et Mere d'un Personne   **");
                Console.WriteLine("**  Entrez 7 pour Retourner l'Age d'un Personne                    **");
                Console.WriteLine("**  Entrez 8 pour Trier la liste des Personnes                     **");
                Console.WriteLine("**  Entrez 9 pour Sauvegarder les donnes                           **");
                Console.WriteLine("**                                                                 **");
                Console.WriteLine("**************************Gestion des Enfants************************");
                Console.WriteLine("**                                                                 **");
                Console.WriteLine("**  Entrez 10 pour Aficher les infos des enfants                   **");
                Console.WriteLine("**  Entrez 11 pour Ajouter un enfant                               **");
                Console.WriteLine("**  Entrez -1 Quittez                                              **");
                Console.WriteLine("**                                                                 **");
                Console.WriteLine("*********************************************************************");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Ajouter(); break;
                    case 2: Supprimer(); break;
                    case 3: Modifier(); break;
                    case 4: Afficher(); break;
                    case 5: Rechercher(); break;
                    case 6: RetournerPereMere(); break;
                    case 7: RetournerAge(); break;                  
                    case 10: AffchEnf(); break;
                    case 11: AjtEnf(); break;                   
                }
            } while (choice != -1);             
        }


        static void Ajouter()
        {
            Console.Clear();
            Personne p = new Personne();
            Console.Write("Entree le Id: "); p.Id = int.Parse(Console.ReadLine());
            Console.Write("Entree le nom: "); p.Nom = Console.ReadLine();
            Console.Write("Entree le prenom: "); p.Prenom = Console.ReadLine();
            Console.Write("Entree le sexe: "); p.Sexe = Console.ReadLine();
            Console.Write("Entree le nom de pere: "); p.Pere = Console.ReadLine();
            Console.Write("Entree le nom de mere: "); p.Mere = Console.ReadLine();
            Console.Write("Entree la date de naissance: "); p.DateNaissance = DateTime.Parse(Console.ReadLine());
            
            if (p.NombreEnfants == 0)
            {
                char c;
                Console.WriteLine("La liste des enfants et vides! voulez vous ajouter un nouveau enfant (O / N)?");
                c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case 'O': p.AjouterEnfant(); break;
                    default: break;
                }
            }
            //else
            //{
            //    Console.WriteLine("Entrer les id de votre enfant/s");
            //    p.IdEnfants = new int[p.NombreEnfants];
            //    for (int i = 0; i < p.NombreEnfants; i++)
            //    {
            //        Console.WriteLine($"L'id de {i + 1} enfant: "); p.IdEnfants[i] = int.Parse(Console.ReadLine()); ;
            //    }
            //}
            Personne.listPersonnes.Add(p);
        }

        //supprimer personne
        static void Supprimer()
        {
            Console.Clear();
            Console.WriteLine("Entrez l'id pour Supprimer: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Personne p in Personne.listPersonnes.ToList())
            {
                if (p.Id == id)
                    Personne.listPersonnes.Remove(p);
            }
        }


        static void Modifier()
        {
            Console.Clear();
            Console.WriteLine("Entrez l'id pour Modifier: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Personne p in Personne.listPersonnes)
            {
                if (p.Id == id)
                {
                    Console.Write("Entree le nouveau Id: "); p.Id = int.Parse(Console.ReadLine());
                    Console.Write("Entree le nouveau nom: "); p.Nom = Console.ReadLine();
                    Console.Write("Entree le nouveau prenom: "); p.Prenom = Console.ReadLine();
                    Console.Write("Entree le nouveau sexe: "); p.Sexe = Console.ReadLine();
                    Console.Write("Entree le nouveau nom de pere: "); p.Pere = Console.ReadLine();
                    Console.Write("Entree le nouveau nom de mere: "); p.Mere = Console.ReadLine();
                    Console.Write("Entree la nouveau date de naissance: "); p.DateNaissance = DateTime.Parse(Console.ReadLine());
                    //Console.Write("Entree le nouveau nombre d'enfants "); p.NombreEnfants = int.Parse(Console.ReadLine());
                    
                    if (p.NombreEnfants == 0)
                    {
                        char c;
                        Console.WriteLine("La liste des enfants et vides! voulez vous ajouter un nouveau enfant (O / N)?");
                        c = char.Parse(Console.ReadLine());
                        switch (c)
                        {
                            case 'O':
                                AjtEnf();
                                break;
                            default:
                                break;                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nombre d'enfants");
                    }

                }
            }
        }

        static void RetournerPereMere()
        {
            Console.Clear();
            Console.WriteLine("Entrez l'id du personne que vous voulez connaiser leur nom pere et mere: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Personne p in Personne.listPersonnes.ToList())
            {
                if (p.Id == id)
                {
                    Console.WriteLine($"Le pere de {p.Nom} est {p.Pere}");
                    Console.WriteLine($"La mere de {p.Nom} est {p.Mere}");
                }
            }
        }

        static void Afficher()
        {
            Console.Clear(); Personne.listPersonnes.ForEach(Console.WriteLine);
        }

        static void RetournerAge()
        {
            Console.Clear();
            Console.WriteLine("Entrez l'id du personne que vous voulez connaiser leur age: ");
            int id = int.Parse(Console.ReadLine());
            
            foreach (Personne p in Personne.listPersonnes)
            {
                if (p.Id == id)
                {
                    var today = DateTime.Today;
                    var age = today.Year - p.DateNaissance.Year;
                    Console.WriteLine($"L'age de {p.Nom} est: {age} ");
                }
            }
        }


        static void AjtEnf()
        {
            Console.Clear();
            Console.WriteLine("Entrez l'id du personne que vous voulez ajouter leur enfant/s: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Personne p in Personne.listPersonnes)
            {
                if (p.Id == id)
                {
                    p.AjouterEnfant();
                }
            }
        }

        static void AffchEnf()
        {
            Console.Clear();
            Console.WriteLine("Entrez l'id du personne que vous voulez afficher leur enfant/s: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Personne p in Personne.listPersonnes)
            {
                if (p.Id == id)
                {
                    p.AfficherEnfants();
                }
            }
        }

        static void Rechercher()
        {
            char c;
            Console.Clear();
            Console.WriteLine("Si vous voulez Rechercher par id Tappez (i)");
            Console.WriteLine("Si vous voulez Rechercher par nom Tappez (n)");
            Console.WriteLine("Si vous voulez Rechercher par prenom Tappez (p)");
            c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case 'i':
                    Console.WriteLine("Entrez l'id du personne que vous voulez afficher leur enfant/s: ");
                    int id = int.Parse(Console.ReadLine());
                    foreach (Personne p in Personne.listPersonnes) {if (p.Id == id) Console.WriteLine(p.ToString()); break; } break;
                case 'n':
                    Console.WriteLine("Entrez le nom du personne que vous voulez afficher leur enfant/s: ");
                    string nom = Console.ReadLine();
                    foreach (Personne p in Personne.listPersonnes) { if (p.Nom == nom) Console.WriteLine(p.ToString());} break;
                case 'p':
                    Console.WriteLine("Entrez le prenom du personne que vous voulez afficher leur enfant/s: ");
                    string prenom = Console.ReadLine();
                    foreach (Personne p in Personne.listPersonnes) {if (p.Prenom == prenom) Console.WriteLine(p.ToString()); } break;
                default: break;
            }
        }





    }
}
