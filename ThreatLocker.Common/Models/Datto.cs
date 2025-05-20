using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class DattoIntegration
    {
        public PSAValidation psaValidation { get; set; }
        public DattoRMMValidation rmmValidation { get; set; }
        public bool PSAEnabled { get; set; }
        public bool RMMEnabled { get; set; }
        public DattoPSATicket ticket { get; set; }
        public List<DattoCompanyMapping> dattoCompanyMapping { get; set; } = new List<DattoCompanyMapping>();
        public List<PSASite> DattoPSACompanyList { get; set; } = new List<PSASite>();
        public List<DattoRMMSite> DattoRMMCompanyList { get; set; } = new List<DattoRMMSite>();
        public bool UpToDate { get; set; } = false;
        public TicketSettings ticketSettings { get; set; }
        public TicketFields dattoTicketFields { get; set; }
        public List<DattoComponent> dattoComponents { get; set; } = new List<DattoComponent>();
        public List<DattoRMMSite> dattoAutoPushRMMSites { get; set; } = new List<DattoRMMSite>();
        public List<string> dattoAutoPushRMMSiteIds { get; set; } = new List<string>();
        public DattoComponent AutoPushDattoComponent { get; set; }
        public DateTime? LastDeployedDate { get; set; }
        public bool DattoAutoPushEnabled { get; set; }
    }

    public class PSAZoneInformation
    {
        public string zoneName { get; set; }
        public string url { get; set; }
        public string webUrl { get; set; }
        public int ci { get; set; }
    }
    [Serializable]
    public class DattoCompanyMapping
    {
        public string psaCompanyName;
        public int CompanyId;
        public string PSAId;
        public string RMMId;
        public string OrganizationId;
    }
    [Serializable]
    public class PSAValidation
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool validated { get; set; }
        public string apiUrl { get; set; }

    }
    [Serializable]
    public class DattoRMMValidation
    {
        public string apiKey { get; set; }
        public string apiSecretKey { get; set; }
        public bool validated { get; set; }
        public string apiUrl { get; set; }
        public DattoAuthToken dattoToken { get; set; }
    }
    [Serializable]
    public class DattoRMMSite
    {
        public string name { get; set; }
        public string uid { get; set; }
        public int numberOfDevices { get; set; }
        public List<string> devices { get; set; }
        public List<Device> devices0 { get; set; }

    }
    [Serializable]
    public class PSASite
    {
        public string CompanyName { get; set; }
        public int Id { get; set; }

        public string identifier = "";
    }
    [Serializable]
    public class DattoQuickJob
    {
        public string jobName { get; set; }
        public JobComponent jobComponent { get; set; }

    }
    [Serializable]
    public class JobComponent
    {
        public string name { get; set; }
        public string uid { get; set; }
        public string componentUid { get; set; }
        public List<Variable> variables { get; set; }
    }
    [Serializable]
    public class TicketSettings
    {
        public Queue queue { get; set; }
        public Status status { get; set; }
        public Priority priority { get; set; }
    }
    [Serializable]
    public class DattoPSATicket
    {
        public int QueueID { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public int CompanyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class DattoDevice
    {
        public string hostname { get; set; }
        public string uid { get; set; }
    }
    [Serializable]
    public class DattoAuthToken
    {
        // Authentication token string.
        public string token { get; set; }
        // Authentication token expiration date/time.
        public DateTime expiring { get; set; }
        public string apiUrl { get; set; }
        public bool success { get; set; }
    }
    public class ResponseDevices
    {
        public List<Device> devices { get; set; }
        public PageDetails pageDetails { get; set; }
    }
    public class ResponseComponents
    {
        public List<Component> components { get; set; }
        public PageDetails pageDetails { get; set; }
    }
    [Serializable]
    public class DattoComponent
    {
        public int id { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
    }
    /// <summary>ResponseSites class used for Json deserialization.</summary>
    public class ResponseSites
    {
        public PageDetail pageDetails { get; set; }
        public List<Site> sites { get; set; }
        public DeviceStatus devicesStatus { get; set; }
        public List<Device> devices { get; set; }
    }
    public class Component
    {
        public string categoryCode { get; set; }
        public bool? credentialsRequired { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public List<Variable> variables { get; set; }
    }
    public class Variable
    {
        public string defaultVal { get; set; }
        public string description { get; set; }
        public bool direction { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int variablesIdx { get; set; }
    }
    /// <summary>PageDetail class used for Json deserialization.</summary>
    public class PageDetail
    {
        public int count { get; set; }
        public string nextPageUrl { get; set; }
        public string prevPageUrl { get; set; }
    }

    /// <summary>Site class used for Json deserialization.</summary>
    public class Site
    {
        public string autotaskCompanyId { get; set; }
        public string autotaskCompanyName { get; set; }
        public DeviceStatus devicesStatus { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
    }

    [Serializable]
    public class Device
    {
        //public bool a64Bit { get; set; }
        public string hostname { get; set; }
        public double id { get; set; }
        public double siteId { get; set; }
        public string siteName { get; set; }
        public string siteUid { get; set; }
        public string uid { get; set; }
        public string operatingSystem { get; set; }
    }

    /// <summary>DeviceStatus class used for Json deserialization.</summary>
    public class DeviceStatus
    {
        public int numberOfDevices { get; set; }
    }

    public class ResponseCompanies
    {
        public List<Item> Items { get; set; }
        public PageDetails pageDetails { get; set; }

        // Remove after datto changes are made live 03/08/22.
        public PageDetails PageDetails { get; set; }

    }
    public class UserDefinedField
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        //public string AdditionalAddressInformation { get; set; }
        //public string Address1 { get; set; }
        //public string Address2 { get; set; }
        //public string AlternatePhone1 { get; set; }
        //public string AlternatePhone2 { get; set; }
        //public int ApiVendorID { get; set; }
        //public int AssetValue { get; set; }
        //public int BillToCompanyLocationID { get; set; }
        //public string BillToAdditionalAddressInformation { get; set; }
        //public string BillingAddress1 { get; set; }
        //public string BillingAddress2 { get; set; }
        //public int BillToAddressToUse { get; set; }
        //public string BillToAttention { get; set; }
        //public string BillToCity { get; set; }
        //public int BillToCountryID { get; set; }
        //public string BillToState { get; set; }
        //public string BillToZipCode { get; set; }
        //public string City { get; set; }
        //public int Classification { get; set; }
        public string CompanyName { get; set; }
        //public string CompanyNumber { get; set; }
        //public int CompanyType { get; set; }
        //public int CompetitorID { get; set; }
        //public int CountryID { get; set; }
        //public DateTime CreateDate { get; set; }
        //public int CreatedByResourceID { get; set; }
        //public int CurrencyID { get; set; }
        //public string Fax { get; set; }
        //public int ImpersonatorCreatorResourceID { get; set; }
        //public int InvoiceEmailMessageID { get; set; }
        //public int InvoiceMethod { get; set; }
        //public bool InvoiceNonContractItemsToParentCompany { get; set; }
        //public int InvoiceTemplateID { get; set; }
        public bool IsActive { get; set; }
        //public bool IsClientPortalActive { get; set; }
        //public bool IsEnabledForComanaged { get; set; }
        //public bool IsTaskFireActive { get; set; }
        //public bool IsTaxExempt { get; set; }
        //public DateTime LastActivityDate { get; set; }
        //public DateTime LastTrackedModifiedDateTime { get; set; }
        //public int MarketSegmentID { get; set; }
        //public int OwnerResourceID { get; set; }
        //public int ParentCompanyID { get; set; }
        //public string Phone { get; set; }
        //public string PostalCode { get; set; }
        public int QueueID { get; set; }
        //public int QuoteEmailMessageID { get; set; }
        //public int QuoteTemplateID { get; set; }
        //public int ResourceID { get; set; }
        //public string SICCode { get; set; }
        //public string State { get; set; }
        //public string StockMarket { get; set; }
        //public string StockSymbol { get; set; }
        //public int SurveyCompanyRating { get; set; }
        //public string TaxID { get; set; }
        //public int TaxRegionID { get; set; }
        //public int TerritoryID { get; set; }
        public string WebAddress { get; set; }
        public List<UserDefinedField> UserDefinedFields { get; set; }
    }

    public class PageDetails
    {
        public int count { get; set; }
        public int RequestCount { get; set; }
        public string prevPageUrl { get; set; }
        public string nextPageUrl { get; set; }

        // Remove after datto changes are made live 03/08/22.
        public int Count { get; set; }
        public string PrevPageUrl { get; set; }
        public string NextPageUrl { get; set; }
    }

    public class TicketInfo
    {
        public List<Item> Items { get; set; }
        public PageDetails PageDetails { get; set; }
    }

    public class PicklistValue
    {
        public string value { get; set; }
        public string label { get; set; }
        public bool isDefaultValue { get; set; }
        public int sortOrder { get; set; }
        public string parentValue { get; set; }
        public bool isActive { get; set; }
        public bool isSystem { get; set; }
    }

    public class Field
    {
        public string name { get; set; }
        public string dataType { get; set; }
        public int length { get; set; }
        public bool isRequired { get; set; }
        public bool isReadOnly { get; set; }
        public bool isQueryable { get; set; }
        public bool isReference { get; set; }
        public string referenceEntityType { get; set; }
        public bool isPickList { get; set; }
        public List<PicklistValue> picklistValues { get; set; }
        public string picklistParentValueField { get; set; }
        public bool isSupportedWebhookField { get; set; }
    }

    public class UserAccessForCreate
    {
    }

    public class UserAccessForDelete
    {
    }

    public class UserAccessForQuery
    {
    }

    public class UserAccessForUpdate
    {
    }

    public class ResponseInfo
    {
        public List<Field> fields { get; set; }
    }
    [Serializable]
    public class Queue
    {
        public string label { get; set; }
        public string value { get; set; }
    }
    [Serializable]
    public class Priority
    {
        public string label { get; set; }
        public string value { get; set; }
    }
    [Serializable]
    public class Status
    {
        public string label { get; set; }
        public string value { get; set; }
    }
    [Serializable]
    public class TicketFields
    {
        public string Name { get; set; }
        public List<Queue> queues { get; set; } = new List<Queue>();
        public List<Status> statuses { get; set; } = new List<Status>();
        public List<Priority> priorities { get; set; } = new List<Priority>();
    }
}
