using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Constants
{
    public class ObjectIpAddressDeviceType
    {
        public static readonly ObjectIpAddressDeviceType Computer = new ObjectIpAddressDeviceType(1, "computer");
        public static readonly ObjectIpAddressDeviceType AccessDevice = new ObjectIpAddressDeviceType(2, "accessdevice");

        public ObjectIpAddressDeviceType(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; }
        public string Value { get; }

        public static readonly ObjectIpAddressDeviceType[] All =
        {
            Computer,
            AccessDevice,
        };

        public static ObjectIpAddressDeviceType FindById(int id)
        {
            return All.FirstOrDefault(x => x.Id == id) ?? Computer;
        }

        public static ObjectIpAddressDeviceType FindByValue(string value)
        {
            return All.FirstOrDefault(x => x.Value == value) ?? Computer;
        }
    }
}
