using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    public class LearnUponNewUser
    {
        public LearnUponUser User { get; set; }
    }
    public class LearnUponUser
    {
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string language { get; set; }
        public string user_type { get; set; }
        public List<LearnUponUser> user { get; set; }
    }
    public class LearnUponGroup
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<LearnUponGroup> groups { get; set; }

    }
    public class LearnUponGroupMembership
    {
        public int user_id { get; set; }
        public int group_id { get; set; }
    }
    public class LearnUponResponseId
    {
        public int id { get; set; }
    }
}
