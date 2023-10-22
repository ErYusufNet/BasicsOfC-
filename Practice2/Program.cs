using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the variable LogInTimes to 3.
            // LogInTimes değişkenini 3'e başlatır.
            int LogInTimes = 3;

            // Start an infinite while loop.
            // Sonsuz bir while döngüsü başlatılır.
            while (true)
            {
                // Prompt the user for their ID.
                // Kullanıcıdan kimlik bilgisini iste.
                Console.WriteLine("What is your id= ");

                // Read the user's input and store it in the 'id' variable.
                // Kullanıcının girdisini oku ve 'id' değişkenine kaydet.
                string id = Console.ReadLine();

                // Prompt the user for their password.
                // Kullanıcıdan şifresini iste.
                Console.WriteLine("What is your password?");

                // Read the user's input and store it in the 'password' variable.
                // Kullanıcının girdisini oku ve 'password' değişkenine kaydet.
                string password = Console.ReadLine();

                // Check if the entered 'id' and 'password' match specific values.
                // Girilen 'id' ve 'password' değerlerinin belirli değerlerle eşleşip eşleşmediğini kontrol et.
                if (id == "yusuf" && password == "123")
                {
                    // If the ID and password match, display a successful login message and exit the loop.
                    // Eğer ID ve şifre eşleşiyorsa, başarılı bir giriş mesajı göster ve döngüden çık.
                    Console.WriteLine("Successfully logged in ");
                    break;
                }
                else
                {
                    // If the ID or password is incorrect, display an error message.
                    // Eğer ID veya şifre yanlışsa, hata mesajı göster.
                    Console.WriteLine("Id or password is wrong");

                    // Check if there are login attempts left.
                    // Giriş deneme hakkı kaldı mı diye kontrol et.
                    if (LogInTimes > 0)
                    {
                        // Decrement the login attempts counter.
                        // Giriş deneme hakkı sayacını azalt.
                        LogInTimes -= 1;
                    }
                    // Check if there are no more login attempts left.
                    // Giriş deneme hakkı kalmadı mı diye kontrol et.
                    if (LogInTimes == 0)
                    {
                        // Display a message indicating that there are no more login attempts, and exit the loop.
                        // Artık giriş deneme hakkı olmadığını belirten bir mesajı göster ve döngüden çık.
                        Console.WriteLine("Can't try to enter anymore");
                        break;
                    }
                }
            }

            // Wait for user input before exiting the program.
            // Programdan çıkmadan önce kullanıcının giriş yapmasını bekleyin.
            Console.ReadLine();
        }
    }
}
