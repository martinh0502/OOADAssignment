using BengansBowling.Models;
using BengansBowling.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Services
{
    public class MemberService : IMemberService
    {
        private IRepo<Member> _repo;

        public MemberService(IRepo<Member> repo)
        {
            _repo = repo;
        }
        public void CreateMember(string name, string phone, string email)
        {
            throw new NotImplementedException();
        }

        public Member GetChampion()
        {
            throw new NotImplementedException();
        }

        public List<Member> GetMembers()
        {
            return _repo.GetList();
        }
    }
}
