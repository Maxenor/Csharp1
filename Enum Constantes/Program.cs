namespace Enum_Constantes
{
    class Program
    {

        enum joursDeLaSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        };
        const int nombreJoursAnnées = 365;
        const int secondesParMinutes = 60;

        enum Saisons
        {
            Printemps,
            Été,
            Automne,
            Hiver
        };

        const int poucesDansPied = 12;
        public static void JoursSemaine()
        {
            Console.WriteLine("Entrez un nombre correspondant à un jour de la semaine :");
            int dayNumber = int.Parse(Console.ReadLine());

            joursDeLaSemaine dayName = (joursDeLaSemaine)dayNumber;
            Console.WriteLine("Le jour correspondant est {0}", dayName);
        }

        public static void CalculAge()
        {
            Console.WriteLine("Veuillez saisir votre âge :");
            int age = int.Parse(Console.ReadLine());

            int nombreJoursVecus = age * nombreJoursAnnées;
            Console.WriteLine("Vous avez vécu " + nombreJoursVecus + " jours.");
        }

        public static void ConversionTemps()
        {
            const int secondesParMinutes = 60;
            int minutes, secondes;

            Console.WriteLine("Veuillez entrer un temps en minutes et secondes :");
            Console.Write("Minutes : ");
            minutes = int.Parse(Console.ReadLine());
            Console.Write("Secondes : ");
            secondes = int.Parse(Console.ReadLine());

            int tempsEnSecondes = minutes * secondesParMinutes + secondes;

            Console.WriteLine($"Le temps entré correspond à {tempsEnSecondes} secondes.");
        }

        public static void SaisonsEnum()
        {
            Console.WriteLine("Veuillez entrer une température en Celsius : ");

            float temperature = float.Parse(Console.ReadLine());

            if (temperature > 30)
            {
                Console.WriteLine("La température est chaude !");
            }
            else if (temperature >= 21 && temperature <= 30)
            {
                Console.WriteLine("La température est tiède.");
            }
            else if (temperature >= 10 && temperature <= 20)
            {
                Console.WriteLine("La température est fraîche.");
            }
            else
            {
                Console.WriteLine("La température est froide !");
            }
        }

        public static void ConversionPieds()
        {
            int pied, pouces;
            int pouceTotal;

            Console.Write("Pieds: ");
            pied = int.Parse(Console.ReadLine());

            Console.Write("Pouces: ");
            pouces = int.Parse(Console.ReadLine());

            pouceTotal = pied * 12 + pouces;

            Console.WriteLine($"Pouces Totaux: {pouceTotal}");
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
                    JoursSemaine();
                    break;
                case "2":
                    CalculAge();
                    break;
                case "3":
                    ConversionTemps();
                    break;
                case "4":
                    SaisonsEnum();
                    break;
                case "5":
                    ConversionPieds();
                    break;
                default:
                    Console.WriteLine("Veuillez choisir une option valide.");
                    break;
            }
        }
    }
}
