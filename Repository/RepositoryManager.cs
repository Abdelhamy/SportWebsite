namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DbContext DBContext;

        public RepositoryManager(DbContext dBContext)
        {
            DBContext = dBContext;
        }

        public async Task Save()
        {
            await DBContext.SaveChangesAsync();
        }
    }
}
