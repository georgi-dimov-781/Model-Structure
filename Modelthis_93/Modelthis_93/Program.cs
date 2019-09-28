using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelthis_93
{
    class Program
    {
        static void Main(string[] args)
        {
            Bathroom staq1 = new Bathroom(19, "Червена баня");

            Kitchen staq2 = new Kitchen(14.5, "Зелена кухня");

            Bedroom staq3 = new Bedroom(25.5, "Синя спалня");

            Person owner = new Person("Георги Димов");

            House house = new House(70, 55, "Оранжева къща", owner);

            house.staq(staq1);
            house.staq(staq2);
            house.staq(staq3);

            Console.WriteLine(house.ownername());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");

            house.info();
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Сумата от всички площи е " + house.ploshtcalculate());


        }
    }
    
}
