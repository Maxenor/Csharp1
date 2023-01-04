namespace TP2_Exo_3

{
    class Program
    {
        public static void Main(string[] args)
        {
            CompteBancaire CompteCourant = new();
            Console.WriteLine(CompteCourant.Déposer(100));
            Console.WriteLine(CompteCourant.GetSolde());
            Console.WriteLine(CompteCourant.Déposer(1));
            Console.WriteLine(CompteCourant.GetSolde());
            Console.WriteLine(CompteCourant.Retirer(100));
            Console.WriteLine(CompteCourant.GetSolde());
            Console.WriteLine(CompteCourant.Retirer(100));
            Console.WriteLine(CompteCourant.GetSolde());
        }
        public class CompteBancaire
        {
            public string nomTitulaire;
            protected float solde;

            public CompteBancaire()
            {
                this.nomTitulaire = "Koprulu";
                this.solde = 0;
            }
            public string Déposer(int montant)
            {
                if (montant < 0)
                {
                    return "Impossible d'ajouter un montant inférieur à 0.";
                }
                else
                {
                    this.solde += montant;
                    return "Le montant a bien été déposé.";
                }
            }

            public string Retirer(int montantARetirer)
            {
                if (this.solde > montantARetirer)
                {
                    this.solde -= montantARetirer;
                    return "Le montant a bien été retiré";
                }
                else
                {
                    return "Le montant n'a pas pu être retiré car le solde n'est pas disponible.";
                }
            }

            public string GetSolde()
            {
                return "Votre solde actuel est de " + this.solde +"€";
            }
        }
    }
}