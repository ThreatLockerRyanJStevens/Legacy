using System;

namespace ThreatLocker.Shared.Models
{
    public class SharepointEvents
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LocationCountry { get; set; }
        public string LocationState { get; set; }
        public string LocationCity { get; set; }
        public string LocationPostalCode { get; set; }
        public string LocationStreet { get; set; }
        public string LocationName { get; set; }

        public string Notes { get; set; }
        public bool Status { get; set; }
    }

    public class Location
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
    }

}
