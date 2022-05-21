using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Player : BaseEntity 
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Team))]
        public int Fk_Team { get; set; }
        Team Team { get; set; }

    }
}   
