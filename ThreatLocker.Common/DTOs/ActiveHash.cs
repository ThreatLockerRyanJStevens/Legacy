using System;

namespace ThreatLockerCommon.DTOs
{
    public class ActiveHash
    {
        public long ActiveHashId { get; set; }
		public string Hash { get; set; }
	    public Guid ApplicationId { get; set; }
		public Guid? OrganizationId { get; set; }
		public string OS { get; set; }
		public DateTime DateTime { get; set; }
		public int TransactionTypeId { get; set; }
		public long? RelatedActiveHashId { get; set; }
		
	}
}
