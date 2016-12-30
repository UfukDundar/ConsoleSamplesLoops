using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSamplesLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1'den N'ye kadar sayıların toplamı
            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam = toplam + i;
            //    Console.WriteLine("Toplam = {0}", toplam);
            //}
            //Console.ReadKey();
            #endregion
            #region Sonsuz Döngü Şablonu


            //int k = 0;
            //for(;;)
            //{
            //    Console.WriteLine(k);
            //    ++k;
            //}
            //Console.ReadKey();
            #endregion
            #region Sample
            //int adet = 0, toplam = 0;
            //for(int i=1;i<=1000;i++)
            //{
            //    if((i%5==0) && (i%7==0))
            //    {
            //        Console.WriteLine(i);
            //        toplam += i;
            //        adet++;
            //    }
            //}
            //Console.ReadKey();
            #endregion
            #region Sample2
            //int adet = 0;
            //for(int i=0;i<=100;i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //    adet++;
            //}
            //Console.ReadKey();
            #endregion
            #region Sample3
            //int satir, sutun;
            //Console.Write("Satır Sayısı :");
            //satir = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sütun Sayısı : ");
            //sutun = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < sutun; i++)
            //{
            //    for (int j = 0; j < satir; ++j)
            //        Console.Write("*");
            //        Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion
            #region BitCounter
            //byte sayi;
            //Console.Write("Sayı Giriniz (0-255) :");
            //sayi = Convert.ToByte(Console.ReadLine());

            //for(byte j=8;j>=1;j--)
            //{
            //    byte and = 1;
            //    for (int k = 1; k <= j - 1; k++)
            //        and *= 2;

            //    byte bit = (byte)((sayi & and) >> j - 1);
            //    Console.Write(bit);
            //}
            //Console.ReadKey();
            #endregion
            #region OrtalamaNot
            //int max = 100, min = 0, Toplam = 0;
            //int Adet = 10;
            //int Not;

            //for (int i = 0; i < Adet;)
            //{
            //    Console.Write("Notunuzu Giriniz :");
            //    Not = Convert.ToInt32(Console.ReadLine());
            //    if (Not < 0 || Not > 100)
            //        Console.Write("Hatalı Not Girdiniz");
            //    else
            //    {
            //        if (Not > max)
            //            max = Not;
            //        else if (Not < max)
            //            min = Not;

            //        Toplam += Not;
            //        i++;
            //    }
            //}
            //Console.WriteLine("En Yüksek Not : {0}", max);
            //Console.WriteLine("En Düşük Not : {0}", min);
            //float Ortalama = (float)Toplam / (float)Adet;
            //Console.WriteLine("Ortalama : {0}", Ortalama);

            //Console.ReadKey();
            #endregion
            #region WhileSample
            //int k = 1;
            //while(k<=20)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}
            //Console.ReadKey();
            #endregion
            #region Sample4
            //int n = 0;
            //int toplam = 0;
            //while(n<=100)
            //{
            //    toplam += n;
            //    n += 2;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadKey();
            #endregion
            #region DoWhile
            //string yazi;
            //do
            //{
            //    Console.Write("Şifrenizi Giriniz : ");
            //    yazi = Console.ReadLine();
            //}
            //while (yazi != "sifre");
            //Console.WriteLine("Şifreyi Bildiniz");
            //Console.ReadKey();
            #endregion
            #region Sample5
            //char ch;

            //do
            //{
            //    Console.Write("Bir Karakter Giriniz : ");
            //    ch = Convert.ToChar(Console.ReadLine());
            //    if (ch == 'q' || ch == 'Q')
            //        break;
            //    else
            //        Console.WriteLine("Döngüye Devam..");
            //}
            //while (true);
            //Console.WriteLine("Döngü Dışı");
            //Console.ReadKey();
            #endregion
            #region Sample6
            
            //int sayi;
            //int toplam = 0;
            //int BironcekiSayi=0;

            //for(;;)
            //{
            //    Console.Write("Bir Sayı Giriniz : ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //        break;
            //    if (sayi == BironcekiSayi)
            //    {
            //        Console.WriteLine("Farklı Bir Sayı giriniz..");
            //        continue;
            //    }
            //    toplam += sayi;
            //    Console.WriteLine("toplam= {0}", toplam);
            //    BironcekiSayi = sayi;
            //}
            //Console.WriteLine("Döngü Bitti..");
            //Console.WriteLine("toplam= {0}", toplam);
            //Console.ReadKey();
            #endregion
        }
    }
}
