namespace TP2_Exo_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cercle cercle = new();
            Console.WriteLine(cercle.Aire());
            Rectangle rect = new();
            Console.WriteLine(rect.Aire());
            Console.WriteLine(RetourneCarré(4));
        }

        private static int RetourneCarré(int numEntré)
        {
            return numEntré * numEntré;
        }

        public class Forme
        {
            public string couleur;

            public Forme()
            {
                this.couleur = "vert";
            }

            public int Aire()
            {
                return 0;
            }
        }

        public class Cercle : Forme
        {
            public float rayon;

            public Cercle()
            {
                this.rayon= 5;
            }
            
            public new double Aire()
            {
                return (3.14 * (this.rayon * this.rayon));
            }
        }

        public class Rectangle : Forme
        {
            public float largeur;
            public float hauteur;

            public Rectangle()
            {
                this.largeur= 5;
                this.hauteur = 10;
            }

            public new float Aire()
            {
                return this.largeur * this.hauteur;
            }
        }
    }
}