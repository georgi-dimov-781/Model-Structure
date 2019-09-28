using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelthis_93
{
    class Building
    {
         protected double plosht;
        protected double visochina;
        protected string cvqt;

        public Building(double plosht, double visochina, string cvqt)
        {
            this.setPlosht(plosht);
            this.setVisochina(visochina);
            this.setCvqt(cvqt);
        }


        private void setPlosht(double plosht)
        {
            if (plosht < 0)
            {
                throw new Exception("Площта не може да бъде 0");
            }
        }

        private void setVisochina(double height)
        {
            if (visochina < 0)
            {
                throw new Exception("Височината не може да бъде 0");
            }
        }

        private void setCvqt(string color)
        {
            if (cvqt == "")
            {
                throw new Exception("Няма цвят!");
            }
        }

        public double getPlosht()
        {
            return this.plosht;
        }

        public string getCvqt()
        {
            return this.cvqt;
        }

        public double getVisochina()
        {
            return this.visochina;
        }
    }
}
