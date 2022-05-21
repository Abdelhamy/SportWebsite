using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceModels
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepositoryManager _repository;
        private ITournamentService tournament;
        private IPlayerService player;
        private ITeamService team;

        public UnitOfWork(RepositoryManager repository)
        {
            _repository = repository;
        }

        public ITournamentService Tournament
        {
            get
            {
                if(tournament == null)
                {
                    tournament = new TournamentService(_repository);
                }
                return tournament;
            }
        }
        public ITeamService Team
        {
            get
            {
                if (team == null)
                {
                    team = new TeamService(_repository);
                }
                return team;
            }
        }

        public IPlayerService Player
        {
            get
            {
                if (player == null)
                {
                    player = new PlayerService(_repository);
                }
                return player;
            }
        }


        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
