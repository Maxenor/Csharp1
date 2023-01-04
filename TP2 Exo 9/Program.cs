using System.ComponentModel.DataAnnotations.Schema;

namespace TP2_Exo_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Etudiant etu1 = new Etudiant("Michon", "Maxime", 24);
            Etudiant etu2 = new Etudiant("Koprulu", "Ilhan", 20);
            Console.WriteLine(etu1.GetNomComplet());
            
        }

        public class Etudiant
        {
            public string nom;
            public string prenom;
            public int age;

            public Etudiant(string nom, string prenom, int age)
            {
                this.nom = nom;
                this.prenom = prenom;
                this.age = age;
            }

            public string GetNomComplet()
            {
                return this.prenom + " " + this.nom;
            }

            public bool EstMajeur()
            {
                return this.age >= 18;
            }
        }

        public class Formation
        {
            public List<Etudiant> ListeEtudiants;

            public Formation()
            {
                ListeEtudiants = new List<Etudiant>();
            }

            public double GetMoyenneAge()
            {
                double moyenne = 0;
                foreach (Etudiant etudiant in ListeEtudiants)
                {
                    moyenne += etudiant.age;
                }
                return moyenne / ListeEtudiants.Count;
            }

            public Etudiant ChercheParNom(string nom)
            {
                foreach (Etudiant etudiant in ListeEtudiants)
                {
                    if (etudiant.nom == nom)
                    {
                        return etudiant;
                    }
                }
                return null;
            }

            public Etudiant ChercheParNomEtPrenom(string nom, string prenom)
            {
                foreach (Etudiant etudiant in ListeEtudiants)
                {
                    if (etudiant.nom == nom && etudiant.prenom == prenom)
                    {
                        return etudiant;
                    }
                }
                return null;
            }

            public void printMajeurs()
            {
                foreach (Etudiant etudiant in ListeEtudiants)
                {
                    if (etudiant.EstMajeur())
                    {
                        Console.WriteLine(etudiant.GetNomComplet());
                    }
                }
            }
        }
    }
}