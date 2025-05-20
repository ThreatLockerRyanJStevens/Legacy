using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon.Models
{
    [Serializable]
    public class ConnectWiseIntegration
    {
        public CWValidation cwValidation { get; set; } = new CWValidation();
        public List<ConnectWiseCompanyMapping> cwCompanyMapping { get; set; } = new List<ConnectWiseCompanyMapping>();
        public List<ConnectWiseAgreementMapping> cwAgreementMapping { get; set; } = new List<ConnectWiseAgreementMapping>();
        public List<CWCompany> cwCompanyList { get; set; } = new List<CWCompany>();
        public List<CWAgreement> cwAgreementList { get; set; } = new List<CWAgreement>();
        public List<CWAdditions> cwAdditionList { get; set; } = new List<CWAdditions>();
        public List<string> CompanyTypes { get; set; } = new List<string>();
        public List<string> CompanyStatuses { get; set; } = new List<string>();
        public List<string> BoardStatuses { get; set; } = new List<string>();
        public string Board { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Item { get; set; }
        public string TicketCloseStatusId { get; set; }
        public string TicketEscalationStatusId { get; set; }
        public string TicketAutoCloseDelayValue { get; set; }
        public CWExecutiveSummary executiveSummary { get; set; } = new CWExecutiveSummary();
        public CWAPIInfo apiInfo { get; set; } = new CWAPIInfo();
        public List<CWCompanySite> CompanySites { get; set; } = new List<CWCompanySite>();

        [JsonIgnore]
        public int? SyncDay { get; set; }
    }

    [Serializable]
    public class ConnectWiseCompanyMapping
    {
        public string cwCompanyName { get; set; }
        public int CompanyId { get; set; }
        public string CWId { get; set; }
        public string OrganizationId { get; set; }
        public string CompanySiteId { get; set; }
        public string CompanySiteName { get; set; }
    }
    [Serializable]
    public class CWExecutiveSummary
    {
        public bool Top10permitted { get; set; }
        public bool Top10blocked { get; set; }
        public bool Secured { get; set; }
        public bool Unsecured { get; set; }
    }
    [Serializable]
    public class ConnectWiseAgreementMapping
    {
        public string OrganizationId { get; set; }
        public string AgreementId { get; set; }
        public string AgreementName { get; set; }
        public string cwCompanyName { get; set; }
        public string CompanyId { get; set; }
        public string CompanySiteId { get; set; }
        public string CompanySiteName { get; set; }
        public string ProductIdentifier { get; set; }
        public string ProductId { get; set; }
    }
    [Serializable]
    public class CWAPIInfo
    {
        public string CompanyName { get; set; }
        public string Codebase { get; set; }
        public string VersionCode { get; set; }
        public string VersionNumber { get; set; }
        public string CompanyID { get; set; }
        public bool IsCloud { get; set; }
        public string SiteUrl { get; set; }
        public string Region { get; set; }
        public List<string> AllowedOrigins { get; set; }
    }
    [Serializable]
    public class CWValidation
    {
        public string publicApiKey { get; set; }
        public string privateApiKey { get; set; }
        public string companyId { get; set; }
        public string clientId { get; set; }
        public string apiUrl { get; set; }
        public bool validated { get; set; }

    }
    [Serializable]
    public class CWTicketSetting
    {
        public string board { get; set; }
        public string source { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }

    }
    [Serializable]
    public class CWCompany
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public List<CWType> types { get; set; } = new List<CWType>();
        public CWStatus status { get; set; } = new CWStatus();
        public CWInfo _info { get; set; }
    }

    [Serializable]
    public class CWInfo
    {
        [JsonProperty("sites_href")]
        public string Sites_Href { get; set; }
    }

    [Serializable]
    public class CWCompanySite
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("company")]
        public CWCompany Company { get; set; }

    }

    [Serializable]
    public class CWType
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    [Serializable]
    public class CWStatus
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    [Serializable]
    public class CWAgreement
    {
        public int id { get; set; }
        public string name { get; set; }
        public CWCompany company { get; set; }
    }
    [Serializable]
    public class CWAdditions
    {
        public int id { get; set; }
        public CWProduct product { get; set; }
        public double quantity { get; set; }
    }
    [Serializable]
    public class CWProduct
    {
        public int id { get; set; }
        public string identifier { get; set; }
    }
    public class CWSource
    {
        public string name;
    }
    public class CWTicketSubtype
    {
        public int id;
        public string name;
        public List<int> typeAssociationIds;
    }
    public class CWItems
    {
        public CWNameAndId item = new CWNameAndId();
    }
    public class CWNameAndId
    {
        public int id;
        public string name;
        public string identifier = "";
    }
}
