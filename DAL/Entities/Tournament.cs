namespace DAL.Entities
{
    public class Tournament : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Url]
        public string VideoURL  { get; set; }
        //Logo URL
        public string ImageUrl { get; set; }
        [Url]
        public string StorageUrl { get; set; }
        public IList<Team> Teams { get; set; }


    }
}
