using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class MissingHashAction
    {
        public static readonly MissingHashAction NotPartOfThisApplication = new MissingHashAction(1, "Not Part of This Application");
        public static readonly MissingHashAction UserError = new MissingHashAction(2, "User Error");
        public static readonly MissingHashAction AlreadyInApplication = new MissingHashAction(3, "Already in Application");
        public static readonly MissingHashAction FoundUsingNormalProcedure = new MissingHashAction(4, "Found Using Normal Procedure");
        public static readonly MissingHashAction FoundUsingNewMethod = new MissingHashAction(5, "Found Using New Method");
        public static readonly MissingHashAction CantFindHash = new MissingHashAction(6, "Can't Find Hash");

        public MissingHashAction(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public static readonly MissingHashAction[] All =
        {
            NotPartOfThisApplication,
            UserError,
            AlreadyInApplication,
            FoundUsingNormalProcedure,
            FoundUsingNewMethod,
            CantFindHash
        };

        //Optional Find method
        public static MissingHashAction Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        //Optional Find method
        public static MissingHashAction FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
