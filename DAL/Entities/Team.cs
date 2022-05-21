namespace DAL.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Logo URL
        public string ImageUrl { get; set; }
        [Url]
        public string StorageUrl { get; set; }

        public string FoundationDate{ get; set; }
        public IList<Tournament> Tournaments { get; set; }
    }
}
