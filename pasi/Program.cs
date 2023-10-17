using System;

class Program
{
    static void Main()
    {
        // Task 1: Kullanıcıdan ad, doğum yılı ve geçerli yılı alın.
        Console.Write("Lütfen tam adınızı girin: ");
        string fullName = Console.ReadLine();

        Console.Write("Lütfen doğum yılınızı girin: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen geçerli yılı girin: ");
        int currentYear = Convert.ToInt32(Console.ReadLine());

        // Task 1 çıktısı
        Console.WriteLine("Merhaba, " + fullName + "!");
        Console.WriteLine("Siz " + (currentYear - birthYear) + " yaşındasınız.");

        // Task 2: Elmas şekli çizin
        Console.WriteLine("Elmas Şekli: ");
        int n = 5; // Elmasın yüksekliği
        char diamondChar = 'o'; // Kullanıcıdan alınan karakter

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(diamondChar);
            }

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(diamondChar);
            }

            Console.WriteLine();
        }

        // Task 3: Kullanıcıdan elmas şekli için karakter alın
        Console.Write("Elmas şeklinde kullanmak istediğiniz karakteri girin: ");
        diamondChar = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Elmas Şekli (" + diamondChar + " karakteri ile): ");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(diamondChar);
            }

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(diamondChar);
            }

            Console.WriteLine();
        }
    }
}
