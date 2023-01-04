namespace Loops_Array
{
    class Program
    {
        public static void TableauFor()
        {
            int[] entiers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < entiers.Length; i++)
            {
                Console.WriteLine(entiers[i]);
            }
        }
        public static void TableauForeach()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Veuillez saisir 10 nombres entiers");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public static void TableauChaînes()
        {
            string[] colors = { "Rouge", "Bleu", "Vert", "Jaune", "Violet" };

            int i = 0;

            while (i < colors.Length)
            {
                Console.WriteLine(colors[i]);
                i++;
            }
        }
        public static void TableauDoubles()
        {
            double[] tableau = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            double somme = 0;
            int i = 0;

            do
            {
                somme += tableau[i];
                i++;
            } while (i < tableau.Length);

            Console.WriteLine($"La somme des valeurs du tableau est {somme}");
        }
        public static void TableauEntiers()
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
                {
                    Console.WriteLine("Le premier nombre divisible par 3 et 5 est: " + numbers[i]);
                    break;
                }
            }
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
                    TableauFor();
                    break;
                case "2":
                    TableauForeach();
                    break;
                case "3":
                    TableauChaînes();
                    break;
                case "4":
                    TableauDoubles();
                    break;
                case "5":
                    TableauEntiers();
                    break;
                default:
                    Console.WriteLine("Veuillez choisir une option valide.");
                    break;
            }
        }

    }
}
