namespace Programmes
{
    class Program
    {
        public static void AfficheUtilisateur()
        {
            Console.Write("Quel est votre nom? ");
            string name = Console.ReadLine();

            Console.Write("Quel âge avez-vous? ");
            int age = int.Parse(Console.ReadLine());

            int yearsRemaining = 100 - age;
            Console.WriteLine($"{name}, tu as encore {yearsRemaining} ans avant d'avoir 100 ans!");
        }

        public static void TableMultiplication()
        {
            Console.WriteLine("Table de multiplication de 1 à 10:");
            Console.WriteLine("");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(String.Format("{0,3}", i * j));
                }
                Console.WriteLine();
            }
        }

        public static void SommeNombres()
        {
            Console.WriteLine("Entrez une série de nombres séparés par des virgules: ");
            string input = Console.ReadLine();

            string[] nums = input.Split(',');

            int sum = 0;

            foreach (string s in nums)
            {
                int n;
                int.TryParse(s, out n);
                sum += n;
            }

            Console.WriteLine($"La somme est {sum}.");
        }

        public static void MotALenvers()
        {
            Console.Write("Veuillez entrer un mot: ");
            string mot = Console.ReadLine();

            char[] motInversé = mot.ToCharArray();
            Array.Reverse(motInversé);

            Console.WriteLine("Le mot à l'envers est: ");
            Console.WriteLine(motInversé);

            Console.ReadLine();
        }

        public static void NumAleatoire()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Le nombre aléatoire est: {0}", randomNumber);
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
                    AfficheUtilisateur();
                    break;
                case "2":
                    TableMultiplication();
                    break;
                case "3":
                    SommeNombres();
                    break;
                case "4":
                    MotALenvers();
                    break;
                case "5":
                    NumAleatoire();
                    break;
                default:
                    Console.WriteLine("Veuillez choisir une option valide.");
                    break;
            }
        }
    }
}