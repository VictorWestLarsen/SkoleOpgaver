using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex60ExtensionMethods
{
    public enum Gender { Male, Female };
    public class ClubMember : IComparable<ClubMember>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public int CompareTo(ClubMember other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }

        private class SortClubMembersAfterLastName : IComparer<ClubMember>
        {
            public int Compare(ClubMember first, ClubMember second)
            {
                return first.LastName.CompareTo(second.LastName);
            }
        }

        private class SortClubMembersAfterGenderAndLastName : IComparer<ClubMember>
        {
            public int Compare(ClubMember first, ClubMember second)
            {
                int result = first.Gender.CompareTo(second.Gender);

                if (result == 0)
                    result = first.LastName.CompareTo(second.LastName);

                return result;
            }
        }

        public static IComparer<ClubMember> GetComparer(int code)
        {
            IComparer<ClubMember> ic = null;
            switch (code)
            {
                case 1: ic = new SortClubMembersAfterLastName(); break;
                case 2: ic = new SortClubMembersAfterGenderAndLastName(); break;
            }
            return ic;
        }
    }

}
