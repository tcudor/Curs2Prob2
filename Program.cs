namespace Curs2Prob2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Deimpartit;
            int Impartitor;
            bool DeimpartitValid = false;
            do
            {
                Console.Write("Introduceti numarul deimpartit: ");
                if (int.TryParse(Console.ReadLine(), out Deimpartit))
                {
                    DeimpartitValid = true;
                }
                else
                {
                    Console.WriteLine("Introduceti un numar valid");
                }
            } while (!DeimpartitValid);

            bool ImpartitorValid = false;
            do
            {
                Console.Write("Introduceii impartitorul: ");
                if (int.TryParse(Console.ReadLine(), out Impartitor))
                {
                    ImpartitorValid = true;
                    if (Impartitor == 0)
                    {
                        Console.WriteLine("Impartitorul nu poate fi zero.");
                        ImpartitorValid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Introduceti un numar valid");
                }
            } while (!ImpartitorValid);


            if (Deimpartit % Impartitor == 0)
            {
                int rezultat = Deimpartit / Impartitor;
                Console.WriteLine($"Rezultatul este: {rezultat}");
            }
            else
            {
                int cat = Deimpartit / Impartitor;
                int rest = Deimpartit % Impartitor;
                Console.WriteLine($"Impartire poate fi facuta doar cu rest: catul este {cat} restul este {rest}");
            }
        }
    }
}