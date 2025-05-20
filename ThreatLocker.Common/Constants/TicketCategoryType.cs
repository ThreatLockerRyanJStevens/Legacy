using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Constants
{
    public class TicketCategoryType
    {
        public static readonly TicketCategoryType GeneralSupport = new TicketCategoryType(1, "General Support");
        public static readonly TicketCategoryType PotentialBug = new TicketCategoryType(2, "Potential Bug");
        public static readonly TicketCategoryType NewBuiltinRequest = new TicketCategoryType(3, "New Built-in Request");
        public static readonly TicketCategoryType NewFeatureRequest = new TicketCategoryType(4, "New Feature Request");
        public static readonly TicketCategoryType NewCustomReportRequest = new TicketCategoryType(5, "New Custom Report Request");
        

        public TicketCategoryType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TicketCategoryType[] All =
        {
            GeneralSupport,
            PotentialBug,
            NewBuiltinRequest,
            NewFeatureRequest,
            NewCustomReportRequest
        };

        public static TicketCategoryType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TicketCategoryType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
