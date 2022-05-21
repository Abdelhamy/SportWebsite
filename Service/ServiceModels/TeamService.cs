namespace Service.ServiceModels
{
    public class TeamService : ITeamService
    { 
        private readonly IRepositoryManager _repository;

        public TeamService(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}
