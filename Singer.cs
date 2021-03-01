using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Singer : Person
    {
        private int Fan; 

        public Singer()
        {

        }

        public Singer(string name, DateTime birthday, bool sex, int Fan) : base(name, birthday, sex)
        {
            this.Fan = Fan;
        }

        public override void Output()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Birthday: " + Birthday);
            Console.WriteLine("Sex: " + IsMale);
            Console.WriteLine("Number of Fans: " + Fan);
        }

    }
}
