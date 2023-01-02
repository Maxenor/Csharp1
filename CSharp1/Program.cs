using System;
Test C1 = new Test();

C1.booleen = true;

Test C2 = C1;
//type référence, ici C2 est égal a l'adresse mémoire de la valeur C1 pas a la valeur de C1
// on peut utiliser les mot-clés réseervé en mettant des @ devant par exemple
C1.booleen = false;

var test = new Test(); // le compilateur va deviner le type de la variable

//string myObject = obj?.foo?.bar;

//if (obj != null && obj.foo != null)
//{
//    myObject = obj.foo.bar;
//}
//même syntaxe entre les deux
int i = 20;

bool b = i >= 20 ? true : false;
Console.WriteLine(b);


short s = 300;
byte d = (byte)s;
Console.WriteLine(d);

const int heureParJour = 24;

joursDeLaSemaine Aujoudhui = joursDeLaSemaine.Lundi;
Console.WriteLine(joursDeLaSemaine);

enum joursDeLaSemaine
{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}

class Test
{
    public bool booleen;
}



namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");

        }
    }
}


