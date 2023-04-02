using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculate
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int loop = 0;
            int islem1 = 0;
            int islem2 = 0;
            int islem3 = 0;

            while(loop==0){ 

            Console.WriteLine("\nYapmak istediğiniz işlemin kodunu giriniz");
            Console.WriteLine("1 - Toplama\n2 - Çıkarma\n3 - Bölme\n4 - Çarpma\n5 - Karesini alma\n6 - 1'e göre tersini alma\n7 - Çıkış\n");
            int islem=Convert.ToInt32(Console.ReadLine());

            if(islem==5) { Console.WriteLine("İşlemi yapacağınız ilk sayıyı giriniz");
                islem3 = Convert.ToInt32(Console.ReadLine()); }
            else if(islem==7){
                    loop++;
                }
            else if (islem == 6)
                {
                    Console.WriteLine("İşlemi yapacağınız ilk sayıyı giriniz");
                    islem3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("sonuç: " + (1/Convert.ToDouble(islem3)));
                }

                else { 
            Console.WriteLine("İşlemi yapacağınız ilk sayıyı giriniz");
            islem1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlemi yapacağınız ilk sayıyı giriniz");
            islem2 = Convert.ToInt32(Console.ReadLine());
            }

            if (islem==1) { toplama(islem1, islem2); }
            else if (islem == 2) { cıkarma(islem1, islem2); }
            else if (islem == 3) { bolme(islem1, islem2); }
            else if (islem == 4) { carpma(islem1, islem2); }
            else if (islem == 5) { karesi(islem3); }

            }

        }
        static void toplama(int n1, int n2)
        {
            Console.WriteLine("\nsonuç: "+(n1 + n2));
            
        }
        static void cıkarma(int n1, int n2)
        {
            Console.WriteLine("\nsonuç: " + (n1 - n2));
            
        }
        static void bolme(int n1, int n2)
        {
            Console.WriteLine("\nsonuç: " + (n1 / n2));
            
        }
        static void carpma(int n1, int n2)
        {
            Console.WriteLine("\nsonuç: " + (n1 * n2));
            
        }
        static void karesi(int n1)
        {
            Console.WriteLine("\nsonuç: " + (n1 * n1));
           
        }
    }
}
