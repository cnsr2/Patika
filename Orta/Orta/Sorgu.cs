using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orta
{
    public class Sorgu
    {
        
        public void Basla()
        {
            Console.WriteLine("*-*-* Geometrik Şekil Seçin *-*-* " );
            Console.WriteLine("1-) Kare");
            Console.WriteLine("2-) Dikdörtgen");
            Console.WriteLine("3-) Üçgen");
            Console.WriteLine("4-) Daire");
            
            int _secimCevap = Convert.ToInt32(Console.ReadLine());

            SecimCevap(_secimCevap);
        }
        public void SecimCevap(int _secimCevap)
        {
            Console.WriteLine("*-*-* Hangi İşlemi Yapmak İstiyorsunuz ? *-*-*");
            Console.WriteLine("1-) Çevre Hesabı");
            Console.WriteLine("2-) Alan Hesabı");

            int _islemCevap = Convert.ToInt32(Console.ReadLine());

            switch (_secimCevap)
            {
                case 1:
                    Console.Write("Kenar Uzunluğu :");
                    int kenarUzunlugu = Convert.ToInt32(Console.ReadLine());


                    DortgenCevap(_islemCevap, kenarUzunlugu, _secimCevap, kenarUzunlugu);
                    break;

                case 2:
                    Console.Write("Kısa Kenar Uzunluğu :");
                    int kısaKenarUzunlugu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Uzun Kenar Uzunluğu :");
                    int uzunKenarUzunlugu = Convert.ToInt32(Console.ReadLine());

                    DortgenCevap(_islemCevap, kısaKenarUzunlugu, _secimCevap, uzunKenarUzunlugu);
                    break;
                case 3:
                    
                    UcgenCevap(_islemCevap, _secimCevap);

                    break;
                case 4:
                    DaireCevap(_islemCevap);

                    break;
            }
        }
        public void DortgenCevap(int _islemCevap, int kısaKenarUzunlugu, int _secimCevap, int uzunKenarUzunlugu = 0)
        {
            switch (_islemCevap)
            {
                case 1:
                    int cevre = kısaKenarUzunlugu * 2 + uzunKenarUzunlugu * 2;
                    Console.WriteLine(" Çevresi : " + cevre );
                    break;
                case 2:
                    Console.WriteLine("Alanı : " + kısaKenarUzunlugu * uzunKenarUzunlugu);
                    break;

                default:
                    Console.WriteLine("Yanlıs Tuslama Yaptınız Lütfen Tekrar Deneyin.");
                    SecimCevap(_secimCevap);
                    break;
            }
            Console.WriteLine("Başka Bir İşlem Yapmak İster Misiniz ?");
            Console.WriteLine("1-) Evet "+ "2-) Hayır");
            int _tekrarSorgu = Convert.ToInt32(Console.ReadLine());
            TekrarSorgu(_tekrarSorgu);
        }
        public void UcgenCevap(int _islemCevap, int _secimCevap)
        {
            switch (_islemCevap)
            {
                case 1:
                    Console.WriteLine("1. Kenar Uzunluğunu Giriniz");
                    int ucgenKenarUzunlugu1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2. Kenar Uzunluğunu Giriniz");
                    int ucgenKenarUzunlugu2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("3. Kenar Uzunluğunu Giriniz");
                    int ucgenKenarUzunlugu3 = Convert.ToInt32(Console.ReadLine());

                    int ucgenCevre = ucgenKenarUzunlugu1 + ucgenKenarUzunlugu2 + ucgenKenarUzunlugu3;
                    Console.WriteLine("Üçgenin Çevresi : " + ucgenCevre);
                    break;
                case 2:
                    Console.WriteLine("Taban Uzunluğu Giriniz.");
                    int tabanUzunlugu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yükseklik Giriniz: ");
                    int yukseklik = Convert.ToInt32(Console.ReadLine());
                    int ucgenAlan = (tabanUzunlugu * yukseklik) / 2; 
                    Console.WriteLine("Ucgen Alanı : " + ucgenAlan );

                    break;
                default:
                    Console.WriteLine("Yanlıs Tuslama Yaptınız Lütfen Tekrar Deneyin.");
                    SecimCevap(_secimCevap);
                    break;
            }
            Console.WriteLine("Başka Bir İşlem Yapmak İster Misiniz ?");
            Console.WriteLine("1-) Evet " + "2-) Hayır");
            int _tekrarSorgu = Convert.ToInt32(Console.ReadLine());
            TekrarSorgu(_tekrarSorgu);
        }
        public void DaireCevap(int _islemCevap)
        {
            Console.WriteLine("Yarıçap Giriniz : ");
            Console.WriteLine("(Pi 3 olarak kabul edilecektir)");
            int _yarıCap = Convert.ToInt32(Console.ReadLine());
            int PI = 3;

            switch (_islemCevap)
            {

                case 1:
                    int daireCevresi = 2 * PI * _yarıCap;
                    Console.WriteLine("Dairenin Çevresi : " + daireCevresi);
                    break;
                case 2:
                    int daireAlan = PI * _yarıCap * _yarıCap;
                    Console.WriteLine("Dairenin Alanı : "+ daireAlan);
                    break;
            }
            Console.WriteLine("Başka Bir İşlem Yapmak İster Misiniz ?");
            Console.WriteLine("1-) Evet " + "2-) Hayır");
            int _tekrarSorgu = Convert.ToInt32(Console.ReadLine());
            TekrarSorgu(_tekrarSorgu);
        }
        public void TekrarSorgu(int _tekrarSorgu)
        {
            switch (_tekrarSorgu)
            {
                case 1:
                    Basla();
                    break;

                case 2:
                    Console.WriteLine("İyi Günler...");
                    break;

                default:
                    Console.WriteLine("Yanlıs Tuslama Yaptınız Lütfen Tekrar Deneyin.");
                    break;
            }
        }
    }
}
