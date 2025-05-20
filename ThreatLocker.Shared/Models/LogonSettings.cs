using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace ThreatLocker.Shared.Models
{
    public class LogonSettings
    {
        public Guid LogonSettingsId { get; set; }

        public Guid ObjectId { get; set; }

        public int Priority { get; set; }

        public string? MFAMethods { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public int? Inactivity { get; set; }

        public List<string> GetMFA()
        {
            List<string> MFA = new List<string>();
            try
            {
                if (string.IsNullOrEmpty(MFAMethods))
                    return MFA;

                MFA = JsonConvert.DeserializeObject<List<string>>(MFAMethods);
            }
            catch
            {
                if (MFAMethods.Contains(","))
                    MFA = MFAMethods.Split(',').ToList();
                else if (!string.IsNullOrEmpty(MFAMethods))
                    MFA.Add(MFAMethods);
            }

            return MFA;
        }

    }
}
