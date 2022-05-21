namespace DAL.Entities
{
    public interface IBaseEntity
    {
        public int ID { get; set; }
    }
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DisplayName(nameof(ID))]
        public int ID { get; set; }
    }
}
