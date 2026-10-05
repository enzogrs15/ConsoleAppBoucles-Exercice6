namespace ConsoleAppBoucles_Exercice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un montant en euros : ");
            int montant = int.Parse(Console.ReadLine());
            int restant = montant;
            do
            {
                if (restant >= 500)
                {
                    Console.WriteLine("500€ : " + restant / 500);
                    restant = restant % 500;
                }
                else if (restant >= 200)
                {
                    Console.WriteLine("200€ : " + restant / 200);
                    restant = restant % 200;
                }
                else if (restant >= 100)
                {
                    Console.WriteLine("100€ : " + restant / 100);
                    restant = restant % 100;
                }
                else if (restant >= 50)
                {
                    Console.WriteLine("50€ : " + restant / 50);
                    restant = restant % 50;
                }
                else if (restant >= 20)
                {
                    Console.WriteLine("20€ : " + restant / 20);
                    restant = restant % 20;
                }
                else if (restant >= 10)
                {
                    Console.WriteLine("10€ : " + restant / 10);
                    restant = restant % 10;
                }
                else if (restant >= 5)
                {
                    Console.WriteLine("5€ : " + restant / 5);
                    restant = restant % 5;
                }
            } while (restant > 0);

        }
    }
}
