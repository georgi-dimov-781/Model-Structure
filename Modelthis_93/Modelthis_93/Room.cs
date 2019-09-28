using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelthis_93
{
    class Room : Room_A
    {
        protected double plosht;
        protected string cvqt;

        public Room(double plosht, string cvqt)
        {
            this.setPlosht(plosht);

            this.setCvqt(cvqt);
        }

        private void setPlosht(double plosht)
        {
            if (plosht < 0)
            {
                throw new Exception("Площта трябва да е повече от 0");
            }
            this.plosht = plosht;
        }

        private void setCvqt(string cvqt)
        {
            if (cvqt == "")
            {
                throw new Exception("Цветът е празен");
            }
            this.cvqt = cvqt;
        }


        public double getPlosht()
        {
            return this.plosht;
        }

        public string getCvqt()
        {
            return this.cvqt;
        }
    }
}
