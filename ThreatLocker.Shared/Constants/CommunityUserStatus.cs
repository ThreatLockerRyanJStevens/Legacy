using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants
{
    // CP - 2024/1/17 - No longer in use
    public class CommunityUserStatus
    {
        public static readonly CommunityUserStatus Awaiting = new CommunityUserStatus(0, "Awaiting");
        public static readonly CommunityUserStatus Approved = new CommunityUserStatus(1, "Approved");
        public static readonly CommunityUserStatus Denied = new CommunityUserStatus(2, "Denied");
        
        public CommunityUserStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CommunityUserStatus[] All =
       {
            Awaiting,
            Approved,
            Denied
       };

        public static CommunityUserStatus Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CommunityUserStatus FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
