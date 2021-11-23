using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BengansBowling.Models;

namespace BengansBowling.Services
{
    public interface ICompetitionService
    {
        void PlayCompetition(List<Member> participants);

        List<Competition> GetCompetitions();
    }
}
