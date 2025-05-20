using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class TaskType
    {
        public Guid TaskTypeId { get; set; }

        public string TypeName { get; set; }

        public bool IsActive { get; set; }
    }
}
