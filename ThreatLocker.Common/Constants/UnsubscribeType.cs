using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Constants
{
    public class UnsubscribeType
    {
        public static readonly UnsubscribeType Marketing = new UnsubscribeType("2533CB3E-0106-454F-8F5D-99BBC04E0F13".ToSafeGuid(), "Marketing");
        public static readonly UnsubscribeType ReleaseNotes = new UnsubscribeType("44AE8EE4-07B2-4504-AC25-A47DE269D7F5".ToSafeGuid(), "Release Notes");
        public static readonly UnsubscribeType Updates = new UnsubscribeType("5FF477FA-23CB-4E4C-B0D0-C8448417E8FD".ToSafeGuid(), "Updates");
        public static readonly UnsubscribeType DirectSalesCommunication = new UnsubscribeType("55A54A21-DF8A-4387-8ED1-96206BF198AD".ToSafeGuid(), "Direct Sales Communication");
        public static readonly UnsubscribeType DirectSupportCommunication = new UnsubscribeType("4FC38252-86D9-491D-B8C8-4CAC844A57AB".ToSafeGuid(), "Direct Support Communication");
        public static readonly UnsubscribeType Training = new UnsubscribeType("2E7C9E70-09AA-4C46-B293-3549840176A1".ToSafeGuid(), "Training");

        public UnsubscribeType(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly UnsubscribeType[] All =
        {
            Marketing,
            ReleaseNotes,
            Updates,
            DirectSalesCommunication,
            DirectSupportCommunication,
            Training
        };

        public static UnsubscribeType Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static UnsubscribeType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
