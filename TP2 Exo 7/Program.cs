namespace TP2_Exo_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Chat chat = new();
            Console.WriteLine(chat.Description());
            Lion lion = new();
            Console.WriteLine(lion.Description());
        }

        public interface IAnimal
        {
            public string Crier()
            {
                return "Je suis en train de voler !";
            }
        }

        public class Chat : IAnimal
        {
            public string nom;

            public Chat()
            {
                this.nom = "Chat";
            }

            public string Description()
            {
                return "Je suis un chat de nom " + this.nom;
            }
        }

        public class Lion : Chat
        {
            public float poids;

            public Lion()
            {
                this.poids = 80;
                this.nom = "Lion";
            }
            public string Description()
            {
                return "Je suis un lion de poids " + this.poids + "kg et de nom " + this.nom;
            }
        }
    }
}