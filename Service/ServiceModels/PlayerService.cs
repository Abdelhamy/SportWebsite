namespace Service.ServiceModels
{
    public class PlayerService : IPlayerService
    { 
        private readonly IRepositoryManager _repository;

        public PlayerService(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}
