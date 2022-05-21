namespace Repository.RepositoryModels
{
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {
        public TeamRepository(DbContext dBContext) : base(dBContext)
        {
        }
      
    }
}
