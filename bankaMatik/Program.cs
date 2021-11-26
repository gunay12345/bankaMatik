using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaMatik
{
    class Program
    {
        static void Main(string[] args)
        {
            hesap hesap1 = new hesap("gunay gül", 5000);
            int secim=Convert.ToInt32(Console.ReadLine());
            int miktar;
            Console.WriteLine("seçiminizi yapınız: 1-para çek \n 2-para yatır \n 3-hesap sorgu ");
            if (secim==1)
            {
                miktar= Convert.ToInt32(Console.ReadLine());
                hesap1.paraCek(miktar);
            }
            else if (secim==2)
            {
                miktar = Convert.ToInt32(Console.ReadLine());
                hesap1.paraYatır(miktar);
            }
            else if (secim == 3)
            {
                hesap1.hesapSorgu();
            }


            Console.ReadLine();
        }
    }
}
