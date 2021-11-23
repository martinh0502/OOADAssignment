using BengansBowling.Models;
using BengansBowling.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BengansBowling.Services
{
    public class CompetitionService : ICompetitionService
    {
        private IRepo<Competition> _repo;

        //repos injectas bara i service lagret dvs här , inte via controllern
        public CompetitionService(IRepo<Competition> repo)
        {
            _repo = repo;
        }
        public List<Competition> GetCompetitions()
        {
            throw new NotImplementedException();
        }

        public void PlayCompetition(List<Member> participants)
        {
            Competition competition = new Competition(participants);

            for(int i = 0; i < participants.Count; i = i+2)
            {
                Match match = new Match(participants.ElementAt(i), participants.ElementAt(i+1), new Lane());

                match.PlayMatch();

                competition.Matches.Add(match);
            }

            competition.CalculateWinner();

            _repo.Add(competition);
        }
    }
}
