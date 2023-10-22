using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                // Dış döngü: Bu döngü, i adında bir tamsayı değişkenini 1'den 10'a kadar artırarak çalışır.

                for (int j = 1; j <= 10; j++)
                {
                    // İç içe geçmiş bir döngü: j adında bir tamsayı değişkenini 1'den 10'a kadar artırarak çalışır.

                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                    // Console.WriteLine, ekrana bir metin çıktısı gönderir.
                    // Bu satırda i ve j değişkenlerinin değerleri çarpılır ve sonuç metin haline getirilir.
                    // Örneğin, i=2 ve j=3 için "2x3=6" gibi bir çıktı elde edilir.
                }
            }
            Console.ReadLine();

        }
    }
}
