using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 müşteri instance al. Console dan girdiğin datalarla müşteriyi doldur ve metoda yolla.
            Console.WriteLine("Müşterinin tipinin adını giriniz");
            Tip tip = new Tip();
            tip.Ad = Console.ReadLine();
            
            Console.WriteLine("Müşterinin ad, soyad ve doğum tarihini adını giriniz");
            Musteri musteri = new Musteri();
            musteri.Ad = Console.ReadLine();
            musteri.Soyad = Console.ReadLine();
            musteri.DogumTarih = Convert.ToDateTime(Console.ReadLine());
            musteri.tip = tip;
            Musteri.MusteriEkle(musteri);

        }
    }
}
