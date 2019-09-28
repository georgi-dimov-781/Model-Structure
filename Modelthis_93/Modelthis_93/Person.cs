using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelthis_93
{
    class Person
    {
                private string name;

        public Person(string name)
        {
            this.owner(name);
        }


        private void owner(string name)
        {
            if (name == "")
            {
                throw new Exception("Въведете валидно име!");
            }
            this.name = name;
        }

        public string owner()
        {
            return this.name;
        }
    }
}
