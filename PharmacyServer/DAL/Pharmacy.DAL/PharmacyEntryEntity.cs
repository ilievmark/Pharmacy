﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy.DAL
{
    public class PharmacyEntryEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int PharmacyId { get; set; }

        [ForeignKey(nameof(PharmacyId))]
        public PharmacyEntity Pharmacy { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public EntryStatus Status { get; set; }
    }
}
