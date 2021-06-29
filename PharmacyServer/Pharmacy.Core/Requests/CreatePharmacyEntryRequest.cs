using System;

namespace Pharmacy.Domain.Requests
{
    public class CreatePharmacyEntryRequest
    {
        public int PharmacyId { get; set; }

        public int PriceId { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime EntryDate { get; set; }

        public int Count { get; set; }

        public string Provider { get; set; }
    }
}
