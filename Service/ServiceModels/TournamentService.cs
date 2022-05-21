namespace Service.ServiceModels
{
    public class TournamentService : ITournamentService
    {
        private readonly IRepositoryManager _repository;

        public TournamentService(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}
