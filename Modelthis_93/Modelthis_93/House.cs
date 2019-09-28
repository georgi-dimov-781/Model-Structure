using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelthis_93
{
    class House : Building
    {
        protected double plosht;
        protected double visochina;
        protected string cvqt;

        protected Person owner;
        protected List<Room_A> stai = new List<Room_A>();

        public House(double plosht, double visochina, string cvqt, Person owner)
          : base(plosht, visochina, cvqt)
        {
            this.owner = owner;
        }

        public void staq(Room_A staq)
        {
            this.stai.Add(staq);
        }

        public double ploshtcalculate()
        {
            double result = 0.0;

            foreach (Room_A staq in this.stai)
            {
                result += staq.getPlosht();
            }

            return result;
        }

        public void info()
        {

            Console.WriteLine("Притежател : " + this.ownername());
            foreach (Room_A staq in this.stai)
            {

                Console.WriteLine("Стая: " + staq.GetType().Name);
                Console.WriteLine("Площ: " + staq.getPlosht());
                Console.WriteLine("Цвят: " + staq.getCvqt());
                Console.WriteLine();
            }


        }


        public string ownername()
        {
            return this.owner.owner();
        }
    }
}
