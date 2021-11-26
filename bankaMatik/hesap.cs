using System;

namespace bankaMatik
{
    class hesap
    {
        private string adSoyad;
        private double bakiye;

        public hesap(string adSoyad, double bakiye)
        {
            this.adSoyad = adSoyad;//constratur ile classdan gelen verinin biribirine karışmaması için classdan gelen veriyi this ile ayırt ediyoruz.
            this.bakiye = bakiye;
            Console.WriteLine("Hoş geldin "+adSoyad);
        }

        public void paraCek(int miktar)
        {
            if (miktar>bakiye)
            {
                Console.WriteLine("para çekemezsiniz.");
            }
            else
            {
                Console.WriteLine("bakiyeniz :" + bakiye);
                bakiye = bakiye - miktar;
                Console.WriteLine("çekim gerçekleşti yeni bakiyeniz :" + bakiye);
            }
        }

        public void paraYatır(int miktar)
        {
            if (miktar>1500)
            {
                Console.WriteLine("günlük yatırma limitiniz 1500 tl ");
            }
            else
            {
                Console.WriteLine("bakiyeniz :" + bakiye);
                bakiye = bakiye + miktar;
                Console.WriteLine("yatırma gerçekleşti yeni bakiyeniz :" + bakiye);
            }
            
        }

        public void hesapSorgu()
        {
            Console.WriteLine("hesabın sahibi :" + adSoyad + "\n bakiyeniz: " + bakiye);
        }
    }
}