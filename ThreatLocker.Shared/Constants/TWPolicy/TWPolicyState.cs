using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants.TWPolicy
{
    public class TWPolicyState
    {
        public static readonly TWPolicyState NotMonitored = new TWPolicyState(0, "Not Monitored");
        public static readonly TWPolicyState Monitor = new TWPolicyState(1, "Monitor");
        public static readonly TWPolicyState UndoPolicy = new TWPolicyState(-1, " Undo Policy");
        public static readonly TWPolicyState ExceptPolicyFromMonitoring  = new TWPolicyState(-2, "Except Policy From Monitoring ");


        public TWPolicyState(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TWPolicyState[] All =
       {
            NotMonitored,
            Monitor,
            UndoPolicy,
            ExceptPolicyFromMonitoring
       };

        public static TWPolicyState Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TWPolicyState FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
