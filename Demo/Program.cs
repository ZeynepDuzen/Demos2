using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Robot robot = new Robot();
            robot.Calis();
            

            Yonetici yonetici = new Yonetici();
            yonetici.Calis();
            yonetici.YemekYe();
            yonetici.MaasAl();
            

            
            


            Console.Read();
        }
    }
}
