using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class ResearchApplication
    {
        public Guid ResearchApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
    }
    public class ResearchSyncItem
    {
        public List<SyncResearchApplication> ResearchApplications { get; set; } = new List<SyncResearchApplication>();
        public List<ResearchAssociatedApplication> ResearchAssociatedApplications { get; set; } = new List<ResearchAssociatedApplication>();
        public List<ResearchInformation> ResearchInformations { get; set; } = new List<ResearchInformation>();
        public List<ResearchInformationType> ResearchInformationTypes { get; set; } = new List<ResearchInformationType>();
    }
    public class SyncResearchApplication
    {
        public Guid ResearchApplicationId { get; set; }
        public Guid ResearchCompanyID { get; set; }
        public string ApplicationName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Description { get; set; }
        public int ConcernRating { get; set; }
        public int BusinessRating { get; set; }
        public string RemediationText { get; set; }
        public string PotentialRiskStrategyText { get; set; }
        public bool IsDisabled { get; set; }
    }
    public class ResearchAssociatedApplication
    {
        public Guid ResearchApplicationId { get; set; }
        public Guid ApplicationId { get; set; }
    }
    public class ResearchInformation
    {
        public Guid ResearchInformationId { get; set; }
        public Guid ResearchInformationTypeId { get; set; }
        public string ResearchInformationValue { get; set; }
        public Guid RelatedObjectId { get; set; }
        public string RelatedObjectType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Source { get; set; }
        public string Text { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }
    public class ResearchInformationType
    {
        public Guid ResearchInformationTypeId { get; set; }
        public string ResearchInformationTypeValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsRequired { get; set; }
        public bool IsDropdown { get; set; }
    }
}
