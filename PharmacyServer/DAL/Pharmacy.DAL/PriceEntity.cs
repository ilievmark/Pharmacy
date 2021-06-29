using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.DAL
{
    public class PriceEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int PharmacyId { get; set; }

        [Required]
        public decimal IncomePrice { get; set; }

        [Required]
        public decimal Percent { get; set; }

        [Required]
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }
    }
}
