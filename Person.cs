using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public abstract class Person
    {
        protected String name;
        protected DateTime Birthday;
        protected bool IsMale;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 3)
                    name = value;
                else
                    name = "invalid";
            }
        }
        // vi du cua tinh dong goi - khong cho tru cap tru tiep chi cho phep truy cap thong qua 1 phuong thuc hay q casi gi dos 
        //public void setname(String name)
        //{
        //    if (name.Length > 3)
        //        this.name = name;
        //}

        public abstract void Output(); // PT ảo
        
        public Person() // deafault contructor
        {

        }

        protected Person(string name, DateTime birthday, bool isMale) // vi khong co 1 cai new person nao car nen public protected nhu nhau
        {
            Name = name;
            Birthday = birthday;
            IsMale = isMale;
        }
    }
}
