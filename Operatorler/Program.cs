using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetiksel Operatörler

            ////Toplama +
            ////Çıkarma -
            ////Çarpma *
            ////Bölme /
            ////Atama =

            ////Özel Operatörler
            ////+=, -=, *=, /=
            ////++, --


            //int sayi1 = 15;
            //int sayi2 = 4;
            //int toplam = sayi1 + sayi2;
            //Console.Write("Toplam = ");
            //Console.WriteLine(toplam);

            //int fark = sayi1 - sayi2;
            //Console.Write("Fark = ");
            //Console.WriteLine(fark);

            //int carpim = sayi1 * sayi2;
            //Console.Write("Çarpım = ");
            //Console.WriteLine(carpim);

            //int bolum = sayi1 / sayi2;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum);

            ////Bölme işleminin ondalık sonuç vermesini istiyorsak:
            ////Bölme işleminde kullanılan değişkenlerin; double, float veya decimal olması gereklidir.

            //double sayi3 = 15;
            //double sayi4 = 4;

            //double bolum2 = sayi3 / sayi4;
            //Console.Write("Bölüm = ");
            //Console.WriteLine(bolum2);

            ////double, integer'dan daha büyük olduğundan, aşağıdaki işlem bir double sonuç çıkartır.
            //double bolum3 = sayi1 / sayi4;

            ////Mod = iki sayının bölümünden kalan
            //int mod = sayi1 % sayi2;    
            //Console.Write("Mod = ");
            //Console.WriteLine(mod);

            //Console.WriteLine(sayi1);
            //sayi1 += 10;
            ////sayi1 değişkeninin üzerine 10 ekle
            //Console.WriteLine(sayi1);

            //sayi1++;//sayi1'in değerini 1 arttır
            //Console.WriteLine(sayi1);

            #endregion

            #region Karşılaştırma Operatörleri

            //Karşılaştırma operatörleri, *HER ZAMAN* bool veri döndürür
            //Büyüktür     >
            //Küçüktür     <
            //Eşittir      ==
            //BüyükEşit    >=
            //KüçükEşit    <=
            //EşitDeğil    !=
            //Değil(Tersi) !  (boolean verinin tersini yazar. true'yu false, false'ı true olarak yazar.)

            //int sayi = 22;

            //Console.Write("Sayı 10'dan büyük mü = ");
            //Console.WriteLine(sayi > 10);
            //Console.Write("Sayı 10'dan küçük mü = ");
            //Console.WriteLine(sayi < 10);
            //Console.Write("Sayı 10'a eşit mi = ");
            //Console.WriteLine(sayi == 10);
            //Console.Write("Sayı 10'dan büyük eşit mi = ");
            //Console.WriteLine(sayi >= 10);
            //Console.Write("Sayı 10'dan küçük eşit mi = ");
            //Console.WriteLine(sayi <= 10);
            //Console.Write("Sayı 10'a eşit değil mi = ");
            //Console.WriteLine(sayi != 10);//Eşit değilse True getirir, eşitse False

            //Console.WriteLine(!true);
            //Console.Write("Sayı 10'dan büyük değil mi = ");
            //Console.WriteLine(!(sayi > 10));
            //Ünlem her zaman başa yazılır

            #endregion

            #region Mantıksal Operatörler

            //Mantıksal Operatörler ve veya komutlarına ihtiyaç duyduğumuzda kullanılır
            //Genellikle karşılaştırma operatörleri ile birlikte kullanılır
            //Bool veri türleri ile koşulları çoğaltmak veya aynı koşula birden çok değişken eklemek için tercih edilir.
            //Mantıksal Operatörlerin sağında ve solunda boolean veri olmalıdır.

            //&& ve anlamında kullanılan mantıksal operatördür.
            //true && true = true
            //false && true = false
            //true && false = false
            //false && false = false

            // || veya anlamında kullanılan mantıksal operatördür. (Alt Gr + küçüktür/büyüktür)
            //true || true = true
            //true || false = true
            //false || true = true
            //false || false = false

            int sayi = 15;

            //Sayı değişkeni içindeki veri 10 ile 20 arasında mı?
            Console.Write("Sayı = ");
            Console.WriteLine(sayi);
            Console.Write("Sayı 10'dan büyük mü = ");
            Console.WriteLine(sayi > 10);
            Console.Write("Sayı 20'den küçük mü = ");
            Console.WriteLine(sayi < 20);

            Console.Write("Sayı 10 ile 20 arasında mı ? = ");
            Console.WriteLine(sayi > 10 && sayi < 20);

            #endregion
        }
    }
}
