using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTitles
{
    public class Book
    {
        private string[] blacklist = { "the", "and", "in", "of", "or" };
        private string titel;
        public string Title { get
            {
                return this.titel;
            }
            set
            {
                this.titel = Titleize(value);
            } }

        public string Capitalize(string v)
        {
            string start;
            start = v.Substring(0, 1);
            start = start.ToUpper();
            start += v.Substring(1);
            return start;
        }
        public string Titleize(string msg)
        {
            StringBuilder builder = new StringBuilder();
            string[] holder = msg.Split(' ');

            for (int i = 0; i < holder.Length; i++)
            {
                if ((holder[i].Length > 2 || i == 0 || i == holder.GetUpperBound(0)) && (!blacklist.Contains(holder[i]) || i == 0) || holder[i] == "i")
                {
                    builder.Append(Capitalize(holder[i]));
                }
                else
                {
                    builder.Append(holder[i]);
                }
                if (i != holder.GetUpperBound(0))
                {
                    builder.Append(" ");
                }
            }
            return builder.ToString();

        }
    }
}
