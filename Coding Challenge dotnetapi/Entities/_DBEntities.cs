using Microsoft.EntityFrameworkCore;

namespace Coding_Challenge_dotnetapi.Entities
{
    public class _DBEntities : DbContext
    {
        public _DBEntities(DbContextOptions<_DBEntities> options)
        : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterTrait> CharacterTraits { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Trait> Traits { get; set; }
    }
}
