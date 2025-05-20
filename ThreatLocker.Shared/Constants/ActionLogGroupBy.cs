using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class ActionLogGroupBy
    {
        public static readonly ActionLogGroupBy FullPath = new ActionLogGroupBy("path", "FullPath");
        public static readonly ActionLogGroupBy Hash = new ActionLogGroupBy("hash", "Hash");
        public static readonly ActionLogGroupBy SourceIp = new ActionLogGroupBy("sourceip", "Hash");
        public static readonly ActionLogGroupBy Cert = new ActionLogGroupBy("cert", "Cert");
        public static readonly ActionLogGroupBy Hostname = new ActionLogGroupBy("hostname", "Hostname");
        public static readonly ActionLogGroupBy Username = new ActionLogGroupBy("username", "Username");
        public static readonly ActionLogGroupBy ProcessPath = new ActionLogGroupBy("process", "ProcessPath");
        public static readonly ActionLogGroupBy Port = new ActionLogGroupBy("port", "Size");
        public static readonly ActionLogGroupBy DestinationIp = new ActionLogGroupBy("destinationIPAddress", "DestinationIPAddress");

        public ActionLogGroupBy(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly ActionLogGroupBy[] All =
       {
            FullPath,
            Hash,
            SourceIp,
            Cert,
            Hostname,
            Username,
            ProcessPath,
            Port,
            DestinationIp
        };

        public static ActionLogGroupBy Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static ActionLogGroupBy FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
