namespace BasesAlgo
{
    class Program
    {
        public static void Nombres()
        {
            Console.WriteLine("Entrez le premier nombre : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre le 2e nombre : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Nombre 1 plus grand");
            }
            else
            {
                Console.WriteLine("Nombre 2 plus grand");
            }
        }
        public static void Notes()
        {
            Console.WriteLine("Entrez votre note : ");
            int note = Convert.ToInt32(Console.ReadLine());

            if (note >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not pass");
            }
        }
        public static void NumberGuesser()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.Write("Devinez le nombre entre 1 et 100: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != randomNumber)
            {
                Console.WriteLine("Raté, Réessayer.");
                if (guess > randomNumber)
                {
                    Console.WriteLine("Trop grand");
                }
                else
                {
                    Console.WriteLine("Trop petit");
                }
                Console.Write("Devinez le nombre entre 1 et 100: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Correct!");
        }

        public static void TableMultiplication()
        {
            Console.Write("Entrez un nombre: ");

            int nombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Table de multiplication de " + nombre);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(nombre + " x " + i + " = " + nombre * i);
            }
        }

        public static void ProduitNombre()
        {
            int num1, num2, product;
            do
            {
                Console.WriteLine("Entrez le premier nombre:");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entrez le deuxième nombre:");
                num2 = Convert.ToInt32(Console.ReadLine());

                product = num1 * num2;

                Console.WriteLine("Le produit est: " + product);
            } while (product <= 1000);

            Console.WriteLine("Le produit est supérieur à 1000. Fin du programme.");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue, choisissez parmis les options suivantes :");
            Console.WriteLine("1) Question 1");
            Console.WriteLine("2) Question 2");
            Console.WriteLine("3) Question 3");
            Console.WriteLine("4) Question 4");
            Console.WriteLine("5) Question 5");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Nombres();
                    break;
                case "2":
                    Notes();
                    break;
                case "3":
                    NumberGuesser();
                    break;
                case "4":
                    TableMultiplication();
                    break;
                case "5":
                    ProduitNombre();
                    break;
                default:
                    Console.WriteLine("Veuillez choisir une option valide.");
                    break;
            }
        }

    }
}
