using BengansBowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Services
{
    public interface IMemberService
    {
        //Självklart ska det finnas all CRUD här egentligen.
        List<Member> GetMembers();

        void CreateMember(string name, string phone, string email);

        Member GetChampion();
    }
}
