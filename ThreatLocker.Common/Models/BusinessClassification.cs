using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class BusinessClassification
    {
        public int BusinessClassificationTypeId { get; set; }

        public string DisplayName { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; }
    }
}
