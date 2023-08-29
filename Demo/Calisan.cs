using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Calisan : ICalis, ICalisan // (is a)
    {
        public void Calis()
        {
            Console.WriteLine("Calisan calisiyor");
        }

        public void MaasAl()
        {
            Console.WriteLine("Calisan maas alir");
        }

        public void YemekYe()
        {
            Console.WriteLine("Calisan yemek yer");
        }
    }
}
