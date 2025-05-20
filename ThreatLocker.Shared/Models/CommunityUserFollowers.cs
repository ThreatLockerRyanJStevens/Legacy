using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class CommunityUserFollowers
    {
        public Guid CommunityUserFollowersId { get; set; }

        public Guid CommunityUserId { get; set; }

        public string Username { get; set; }

        public DateTime FollowerDate { get; set; }
    }
}
