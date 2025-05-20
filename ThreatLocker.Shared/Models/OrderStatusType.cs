using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class OrderStatusType
    {
        public int OrderStatusTypeId { get; set; }

        public string DisplayName { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; }

    }
}
