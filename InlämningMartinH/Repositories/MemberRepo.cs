using BengansBowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Repositories
{
    public class MemberRepo : IRepo<Member>
    {
        public void Add(Member value)
        {
            throw new NotImplementedException();
        }

        public void Add(List<Member> value)
        {
            throw new NotImplementedException();
        }

        public void Delete(Member value)
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetList()
        {
            //Databaskod

            List<Member> members = new List<Member>()
            {
                new Member(){Name = "Kalle", Email = "kalle@gmail.com", Phone = "07012345667"},
                new Member(){Name = "Adam", Email = "adam@gmail.com", Phone = "07012345667"},
                new Member(){Name = "Margareta", Email = "margareta@gmail.com", Phone = "07012345667"},
                new Member(){Name = "Anna", Email = "anna@gmail.com", Phone = "07012345667"},
                new Member(){Name = "Nils", Email = "nils@gmail.com", Phone = "07012345667"},
                new Member(){Name = "Gustav", Email = "gustav@gmail.com", Phone = "07012345667"},
            };

            return members;
        }

        public void Update(Member value)
        {
            throw new NotImplementedException();
        }
    }
}
