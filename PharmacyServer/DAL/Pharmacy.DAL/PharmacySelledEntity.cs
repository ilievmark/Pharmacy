using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.DAL
{
    public class PharmacySelledEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CheckId { get; set; }

        [Required]
        public int PharmacyEntryId { get; set; }

        [ForeignKey(nameof(PharmacyEntryId))]
        public PharmacyEntryEntity PharmacyEntry { get; set; }

        [Required]
        public int PriceId { get; set; }

        [ForeignKey(nameof(PriceId))]
        public PriceEntity Price { get; set; }

        public int Count { get; set; }
    }
}
