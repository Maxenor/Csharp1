namespace TP2_Exo_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Oiseau pigeon = new();
            Console.WriteLine(pigeon.Description());
            Avion avion = new();
            Console.WriteLine(avion.Description());
        }
        
        public interface IVolant
        {
            public string Voler()
            {
                return "Je suis en train de voler !";
            }
        }

        public class Oiseau : IVolant
        {
            public string nom;

            public Oiseau()
            {
                this.nom = "Pigeon";
            }

            public string Description()
            {
                return "Je suis un oiseau de nom "+ this.nom;
            }
        }

        public class Avion : Oiseau
        {
            public int nbMoteurs;

            public Avion()
            {
                this.nbMoteurs = 2;
                this.nom = "Avion";
            }
            public string Description()
            {
                return "Je suis un avion avec " + this.nbMoteurs + "moteurs de nom " + this.nom;
            }
        }
    }
}