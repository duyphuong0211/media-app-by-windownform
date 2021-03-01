using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Author : Person
    {
        private int NoM;
        public override void Output()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Birthday: " + Birthday);
            Console.WriteLine("Sex: " + IsMale);
            Console.WriteLine("Number of musics: " + NoM);
        }
    }
}
