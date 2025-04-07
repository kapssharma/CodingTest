using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coding_Challenge_dotnetapi.Entities
{
    public class CharacterTrait
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(CharacterTrait.CharacterId))]
        public int CharacterId { get; set; }
        [ForeignKey(nameof(CharacterTrait.TraitId))]
        public int TraitId { get; set; }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Trait> Traits { get; set; }
        public virtual DbSet<Stat> Stats { get; set; }
    }
}
