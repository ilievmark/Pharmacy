using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.DAL
{
    public class PeriodEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        public DateTime? End { get; set; }

        [Required]
        public List<CheckEntity> ClosedChecks { get; set; }
    }
}
