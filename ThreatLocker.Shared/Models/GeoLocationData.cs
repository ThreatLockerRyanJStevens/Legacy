using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class GeoLocationData
    {
		public string IPAddress { get; set; }

		public string CountryCode { get; set; }

		public string Region { get; set; }

		public string City { get; set; }

		public string ISP { get; set; }

		public decimal Latitude { get; set; }

		public decimal Longitude { get; set; }
    }
}
