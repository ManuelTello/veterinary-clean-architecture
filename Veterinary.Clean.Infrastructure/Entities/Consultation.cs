using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinary.Clean.Infrastructure.Entities
{
    [Table("consultations")]
    public class Consultation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id",Order = 0)]
        public Guid Id { get; set; }
        
        [Column("pet_id",Order = 1)]
        public Guid PetId { get; set; }
        
        [Column("date_created", Order = 2)]
        public DateTime DateCreated { get; set; }

        [Column("content", Order = 3)]
        public string? Content { get; set; }

        [Column("annotations", Order = 4)]
        public string? Annotations { get; set; }
        
        [ForeignKey("consultation_type")]
        [Column("type_of_consultation", Order = 5)]
        public int ConsultationTypeId { get; set; }
        
        public Pet Pet { get; set; }
        
        public ConsultationType ConsultationType { get; set; }
    }
}

