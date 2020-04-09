using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex53
{
    public enum Gender { Male, Female };
    public class ClubMember : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {

            ClubMember member = (ClubMember)obj;

            return this.FirstName.CompareTo(member.FirstName);
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }
    }

}
