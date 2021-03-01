using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Music 
    {
        private Singer NameS;
        private Author NameA;
        private int Time;
        private String NameM;
        private String link;
        
        public Music()
        {

        }

        public Music(Singer nameS, Author nameA, int time, string nameM, string link)
        {
            NameS1 = nameS;
            NameA = nameA;
            Time = time;
            NameM1 = nameM;
            Link = link;
        }

        public string NameM1 { get => NameM; set => NameM = value; }
        public Singer NameS1 { get => NameS; set => NameS = value; }
        public string Link { get => link; set => link = value; }
    }
    
}
