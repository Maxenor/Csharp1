namespace TP2_Exo1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Voiture megane = new();
            Console.WriteLine(megane.Description());
        }
        public class Voiture
        {
            private string marque;
            private string modele;
            private int nbPortes;
            public string couleur;

            public Voiture()
            {
                marque = "Renault";
                modele = "Megane 3";
                couleur = "Gris";
                nbPortes = 5;
            }
            public string Description()
            {
                return $"La voiture est une {marque} {modele} avec {nbPortes} portes de couleur {couleur}.";
            }
        }
    }
}