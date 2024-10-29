using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinary.Clean.Infrastructure.Entities
{
    [Table("pets")]
    public class Pet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id",Order = 0)]
        public Guid Id { get; set; }

        [Column("name", Order = 1)]
        public string Name { get; set; } = string.Empty;

        [Column("breed", Order = 2)]
        public string? Breed { get; set; } = null!;
     
        [Column("date_of_birth", Order = 3)]
        public DateOnly DateOfBirth { get; set; }
        
        [Column("weight", Order = 4)]
        public int Weight { get; set; }
        
        [Column("date_added_to_system", Order = 5)]
        public DateTime DateAddedToSystem { get; set; }

        public IList<OwnerPet> OwnersPets { get; } = new List<OwnerPet>();
        
        public ICollection<Consultation> Consultations { get; } = new List<Consultation>();
    }
}

