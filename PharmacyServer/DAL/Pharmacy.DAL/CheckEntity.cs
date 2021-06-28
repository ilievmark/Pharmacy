using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.DAL
{
    public class CheckEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int PeriodId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public List<PharmacySelledEntity> SelledItems { get; set; }
    }
}
