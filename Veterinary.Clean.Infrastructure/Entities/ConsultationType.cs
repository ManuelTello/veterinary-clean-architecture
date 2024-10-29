using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinary.Clean.Infrastructure.Entities
{
    [Table("consultation_type")]
    public class ConsultationType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id",Order = 0)]
        public int Id { get; set; }

        [Column("type", Order = 1)]
        public string Type { get; set; } = string.Empty;

        public ICollection<Consultation> Consultations { get; } = new List<Consultation>();
    }
}

