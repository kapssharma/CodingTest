using System.ComponentModel.DataAnnotations;

namespace Coding_Challenge_dotnetapi.Entities
{
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Stat Stat { get; set; }
        public virtual ICollection<Trait> Traits { get; set; }
        public bool DeletedAt { get; set; }
    }
}
