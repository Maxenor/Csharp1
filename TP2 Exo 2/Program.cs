namespace TP2_Exo_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Etudiant Ilhan = new();
            Console.WriteLine(Ilhan.Saluer());
        }
        public class Etudiant
        {
            public string nom;
            public string prenom;
            private int age;

            public Etudiant()
            {
                nom = "Koprulu";
                prenom = "Ilhan";
                age = 20;

            }
            public string Saluer()
            {
                return $"Bonjour, je m'appelle {nom} {prenom} et j'ai {age} ans.";
            }
        }
    }
}