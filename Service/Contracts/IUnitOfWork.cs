namespace Service.Contracts
{
    public interface IUnitOfWork
    {
        Task Save();

        ITournamentService Tournament { get; }
        ITeamService Team { get; }
        IPlayerService Player { get; }

    }
}
