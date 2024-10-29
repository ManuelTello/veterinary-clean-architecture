using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinary.Clean.Infrastructure.Entities
{
    [Table("owners")]
    public class Owner
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id",Order = 0)]
        public Guid Id { get; set; }
        
        [Column("first_name", Order = 1)]
        public string FirstName { get; set; } = string.Empty;

        [Column("last_name", Order = 2)]
        public string LastName { get; set; } = string.Empty;
        
        [Column("email", Order = 3)]
        public string Email { get; set; } = string.Empty;
        
        [Column("main_phone_number", Order = 4)]
        public string MainPhoneNumber { get; set; } = string.Empty;
        
        [Column("alternative_phone_number", Order = 5)]
        public string AlternativePhoneNumber { get; set; } = string.Empty;
        
        [Column("date_added_to_system", Order = 6)]
        public DateTime DateAddedToSystem { get; set; }
       
        public IList<OwnerPet> OwnersPets { get; } = new List<OwnerPet>();
    }
}

