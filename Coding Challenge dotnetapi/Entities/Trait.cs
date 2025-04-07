using System.ComponentModel.DataAnnotations;

namespace Coding_Challenge_dotnetapi.Entities
{
    public class Trait
    {
        [Key]
        public int TraitId { get; set; }
        public string Name { get; set; }
        public int ModifierValue { get; set; }
    }
}
