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
        public class SortClubMembersAfterLastName : IComparer<ClubMember>
        {
            public int Compare(ClubMember first, ClubMember second)
            {
                return string.Compare(first.LastName, second.LastName);
            }
        }

        public class SortClubMembersAfterGenderAndLastName : IComparer<ClubMember>
        {
            public int Compare(ClubMember first, ClubMember second)
            {
                if (first.Gender == second.Gender)
                {
                    return string.Compare(first.LastName, second.LastName);
                }
                else if (first.Gender == Gender.Male)
                {
                    return -1;
                }
                else
                    return 1;
            }

        }
        public static IComparer<ClubMember> GetComparer(int id)
        {
            switch (id)
            {
                case 1: return new SortClubMembersAfterLastName();
                        break;
                case 2: return new SortClubMembersAfterGenderAndLastName();
                    break;
                default: return null;
                    break;
            }
        }


        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }
    }
}
