namespace Repository.RepositoryModels
{
    public class TournamentRepository : RepositoryBase<Tournament>, ITournamentRepository
    {
        public TournamentRepository(DbContext dBContext) : base(dBContext)
        {
        }
    }
}
