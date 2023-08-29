using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Yonetici : ICalis, ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("Yonetici calisiyor");
        }

        public void MaasAl()
        {
            Console.WriteLine("Yonetici maas aliyor");
        }

        public void YemekYe()
        {
            Console.WriteLine("Yonetici yemek yiyiyor");
        }
    }
}
