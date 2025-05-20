using System;
using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class ResearchInformationType
    {
        public static readonly ResearchInformationType CountriesOfOperation = new ResearchInformationType(Guid.Parse("3BBE7A26-9482-4219-93ED-CD3524DB5495"));
        public static readonly ResearchInformationType Category = new ResearchInformationType(Guid.Parse("7CAEE11B-2791-41F4-B45C-7E130DC484AD"));

        public ResearchInformationType(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
        public string Name { get; }
        
        public static readonly ResearchInformationType[] All =
        {
            CountriesOfOperation,
            Category,
        };

        public static ResearchInformationType Find(Guid id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }
    }
}
