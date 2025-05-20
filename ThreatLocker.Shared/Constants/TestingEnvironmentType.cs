using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class TestingEnvironmentType
    {
        /// <summary>
        /// File should be checked in ThreatLocker Testing Environment
        /// </summary>
        public static readonly TestingEnvironmentType CheckRecommended = new TestingEnvironmentType(1, "File Check Recommended");
        /// <summary>
        /// File was previously executed within ThreatLocker Testing Environment
        /// </summary>
        public static readonly TestingEnvironmentType PreviouslyChecked = new TestingEnvironmentType(2, "File Previously Checked");
        /// <summary>
        /// File already has matching application and doesn't need to be checked in ThreatLocker Testing Environment
        /// </summary>
        public static readonly TestingEnvironmentType CheckAvailable = new TestingEnvironmentType(3, "File Check Available");
        /// <summary>
        /// File cannot run in ThreatLocker Testing Environment
        /// </summary>
        public static readonly TestingEnvironmentType CheckUnavailable = new TestingEnvironmentType(4, "File Check Unavailable");
        /// <summary>
        /// No machines are currently available to run the ThreatLocker Testing Environment
        /// </summary>
        public static readonly TestingEnvironmentType NoMachinesAvailable = new TestingEnvironmentType(5, "No TTE Machines Available");

        public TestingEnvironmentType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TestingEnvironmentType[] All =
        {
            CheckRecommended,
            PreviouslyChecked,
            CheckAvailable,
            CheckUnavailable
        };

        public static TestingEnvironmentType Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TestingEnvironmentType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
