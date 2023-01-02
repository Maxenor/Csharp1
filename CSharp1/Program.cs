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
Console.WriteLine(Aujoudhui);

joursDeLaSemaine Weekend = joursDeLaSemaine.Samedi | joursDeLaSemaine.Dimanche;
Console.WriteLine(Weekend);

int[] Tableau;
Tableau = new int[10];

int[] TableauInt = new int[]
{
    34,45,1,34,43
};

int[,] Tableau2D = new int[1,2];
int[,,] Tableau3D = new int[5,2,3];
// tableau a 2 et 3 dimensions dans lesquels on ajoute les valeurs

int[][] Tableau2Dbis = new int[3][];
Tableau2Dbis[0] = new int[] { 45, 2 };
Tableau2Dbis[1] = new int[] { 34, 34, 4, 67 };

//foreach (int[] element in Tableau2Dbis)
//{
//    foreach (int value in element)
//    {
//        Console.WriteLine(value);
//    }
//}
//for (int i = 0; i < Tableau2Dbis; i++)
//{
//    Console.WriteLine(i);
//}




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



//namespace ConsoleApp
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("HelloWorld");

//        }
//    }
//}


