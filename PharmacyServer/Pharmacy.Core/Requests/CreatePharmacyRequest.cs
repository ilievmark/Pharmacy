using System;

namespace Pharmacy.Domain.Requests
{
    public class CreatePharmacyRequest
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal IncomePrice { get; set; }

        public decimal Percent { get; set; }

        public DateTime PriceStart { get; set; }
    }
}
