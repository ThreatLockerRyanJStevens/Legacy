using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants
{
    public class ActionLogEncryption
    {
        public static readonly ActionLogEncryption NotEncrypted = new ActionLogEncryption(0, "Not Encrypted");
        public static readonly ActionLogEncryption Encrypted = new ActionLogEncryption(1, "Encrypted");
        
        public ActionLogEncryption(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ActionLogEncryption[] All =
       {
            NotEncrypted,
            Encrypted
       };

        public static ActionLogEncryption Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ActionLogEncryption FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
