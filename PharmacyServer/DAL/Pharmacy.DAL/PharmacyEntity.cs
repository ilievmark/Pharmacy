using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.DAL
{
    public class PharmacyEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public long Code { get; set; }

        [Required]
        public int PriceId { get; set; }

        [ForeignKey(nameof(PriceId))]
        public PriceEntity Price { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
