﻿using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class MemberController
    {
        private Dictionary<int, Member> actives = new Dictionary<int, Member>();
        private Dictionary<int, Member> passives = new Dictionary<int, Member>();

        public void AddMember(MemberType memberType, Member m)
        {
            if (IdAlreadyUsed(m.Id)) return;
            if (memberType == MemberType.active)
            {
                actives[m.Id] = m;
            }
            else if(memberType == MemberType.passive)
            {
                passives[m.Id] = m;
            }

            //Pre: "m" is a member-object, "m.Id" must not be present in "actives" or "passives"
            //Post: "m" is added to either "actives" or "passives" - which one is determined by "memberType"
        }

        public bool IdAlreadyUsed(int id)
        {
            if (passives.ContainsKey(id))
            {
                return true;
            }
            else if (actives.ContainsKey(id))
            {
                return true;
            }
            else
            {
                return false;
            }
            //Pre: None
            //Post: Returns true if "id" is used as "Id" by any object in either "actives" or "passives"
            
        }

        public IEnumerable<Member> Getmembers()
        {
            List<Member> list = new List<Member>();
            //Pre: None
            //Post: A list containing all members from "actives" and "passives" is returned
            return list;
        }

        public bool DeleteMember(int id)
        {
            bool result = false;

            result = (actives.Remove(id) || passives.Remove(id));

            //Pre: None
            //Post: No object having "id" as "Id" exist in either "actives" or "passives"
            //      If an object was removed from either "actives" or "passives" "True" is returned
            //      If no object was removed from either "actives" or "passives" "False" is returned

            return result;
        }
    }
}

