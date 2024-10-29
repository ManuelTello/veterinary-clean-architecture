using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinary.Clean.Infrastructure.Entities
{
    [Table("owers_pets")]
    public class OwnerPet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id",Order = 0)]
        public int Id { get; set; } 
        
        [ForeignKey("owners")]
        [Column("owner_id", Order = 1)]
        public Guid OwnerId { get; set; }
        
        [ForeignKey("pets")]
        [Column("pet_id", Order = 2)]
        public Guid PetId { get; set; }

        public Pet Pet { get; set; } = null!;

        public Owner Owner { get; set; } = null!;
    }
}

