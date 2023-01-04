namespace TP2_Exo_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(15, 30);
            Console.WriteLine(rect.Aire());
            Console.WriteLine(rect.Perimètre());
            
        }
        public class Rectangle
        {
            public float largeur;
            public float hauteur;
            public Rectangle(int hauteur, int largeur)
            {
                this.hauteur = hauteur;
                this.largeur = largeur;
            }
            public float Aire()
            {
                return hauteur * largeur;
            }

            public float Perimètre()
            {
                return (hauteur * 2) + (largeur *2);
            }
        }
    }
}