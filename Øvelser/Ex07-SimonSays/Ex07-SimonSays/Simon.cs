using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_SimonSays
{
    public class Simon
    {
        public string Echo(string v)
        {
            return v.ToLower();
        }

        public string Shout(string v)
        {
           return v.ToUpper();
        }

        public string Repeat(string v)
        {
            return v += " " + v;
            
        }
        public string Repeat(string v, int v1)
        {
            int i = 0;
            string holder = v;
            for (i = 0; i < v1 -1; i++)
            {
             holder += " " + v;
             
            }
            return holder;

        }

        public string StartOfWord(string s, int v)
        {
            string start;
            start = s.Substring(0, v);
            return start;
        }

        public string FirstWord(string v)
        {
            string first;
            first = v.Split(' ').First();
            return first;
        }

        public string Titleize(string v)
        {
        
        }
    }
}
