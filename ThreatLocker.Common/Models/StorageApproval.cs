using System;

namespace ThreatLockerCommon.Models
{
    public class StorageApproval
    {
        public StorageDevice StorageDevice { get; set; }
        public string PermitFor { get; set; }
        public string Permission { get; set; }
        public string Method { get; set; }
        public Guid ComputerId { get; set; }
        public string AuthKey { get; set; }
        public int ExpireMinutes { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid ExistingPolicyId { get; set; }
        public string TicketInfo { get; set; }
        public string Requestor { get; set; }
        public string RequestorReason { get; set; }
        public string Comments { get; set; }
        public string Users { get; set; }
        public string PolicyName { get; set; }
        public string Interface { get; set; }
        public string Json { get; set; }
    }

    [Serializable]
    public class StorageDevice
    {
        public Guid StorageDeviceId { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Owner { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Path { get; set; }
        public Guid OrganizationId { get; set; }
    }

    public class StorageDevicePolicyList
    {
        public Guid StoragePolicyId { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
    }
}
