using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLockerCommon.Constants;

namespace ThreatLockerCommon.Models
{
    public class ServiceShorthandTLAction
    {
        public ServiceShorthandTLAction()
        {
        }

        public ServiceShorthandTLAction(ThreatLockerItemDTO dto)
        {
            t = dto.D;

            fp = dto.GetAttributeValue(ThreatLockerAttribute.FullPath);
            pn = dto.GetAttributeValue(ThreatLockerAttribute.ProcessPath);
            pyid = dto.PID.HasValue ? dto.PID.Value.ToSafeString() : "";
            u = dto.U;
            a = dto.AID;
            h = dto.GetAttributeValue(ThreatLockerAttribute.TLHash);
            c = dto.GetAttributeValues(ThreatLockerAttribute.Certificate)?.ToList() ?? new List<ThreatLockerCert>();
            aid = dto.GetAttributeValue(ThreatLockerAttribute.ApplicationId).ToSafeString();
            sn = dto.GetAttributeValue(ThreatLockerAttribute.SerialNumber);
            dt = dto.GetAttributeValue(ThreatLockerAttribute.DeviceType);
            at = ActionType.FindById(dto.AT).Value;
            s = dto.GetAttributeValue(ThreatLockerAttribute.FileSize);
            pid = dto.GetAttributeValue(ThreatLockerAttribute.ProcessID);
            rf = dto.GetAttributeValue(ThreatLockerAttribute.Ringfenced);
            p = dto.PN;
            ap = dto.GetAttributeValue(ThreatLockerAttribute.ApplicationName);
            e = dto.GetAttributeValue(ThreatLockerAttribute.EncryptionStatus);
            mo = dto.GetAttributeValue(ThreatLockerAttribute.MonitorOnly);
            n = dto.GetAttributeValue(ThreatLockerAttribute.Notes);
            cb = JsonConvert.SerializeObject(dto.GetAttributeValues(ThreatLockerAttribute.CreatedByProcess)?.ToList()) ?? "[]";
            d = dto.GetAttributeValue(ThreatLockerAttribute.Data);
            s256= dto.GetAttributeValue(ThreatLockerAttribute.SHA256);
            rp = dto.GetAttributeValue(ThreatLockerAttribute.RemotePresence);
            mid = dto.GetAttributeValue(ThreatLockerAttribute.MaintenanceModeId);
            hostname = dto.GetAttributeValue(ThreatLockerAttribute.Hostname).ToSafeString();

            string[] createdByProcesses = dto.GetAttributeValues(ThreatLockerAttribute.CreatedByProcess);
            
            cb = createdByProcesses.IsNotNullOrEmpty() ? JsonConvert.SerializeObject(createdByProcesses) : "[]";
        }

        public string fp = ""; //fullpath
        public string pyid = ""; //PolicyId
        public string u = ""; //username
        public int a; //actionid
        public string h = ""; //hash
        public List<ThreatLockerCert> c; //certs
        public string pn = ""; //process
        public string aid = ""; //appid
        public DateTime t = DateTime.UtcNow; //date and time
        public string sn = ""; //serial number
        public string dt = ""; //devicetype
        public string at = "execute"; //actiontype
        public long s = 0; //size
        public int pid = 0; //process id
        public bool rf = false; //ringfence
        public string p; //policyname
        public string ap; //application 
        public int e = 2;//encryption status
        public string organizationId = ""; // organizationid
        public string computerId = "";
        public string hostname = "";
        public bool mo = false; // monitor only
        public string n = ""; //notes for monitor only
        public string s256 = ""; //SHA 256 
        public string cb = ""; // CREATED BY Process CreatedByProcess
        public string d = ""; //data
        public bool rp = false; //remote presence
        public Guid mid = Guid.Empty; //MaintenanceId
        public string dan; // Deny Application name

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class ServiceShorthandActionRequest
    {
		public Guid ComputerId { get; set; }
		public Guid ComputerGroupId { get; set; }
		public Guid OrganizationId { get; set; }
		public string Hostname { get; set; }
        public string AuthKey { get; set; }
        public List<ServiceShorthandTLAction> Actions { get; set; }
	}

    public class Sha256LogItemRequest
    {
        public Sha256LogItemRequest(ServiceThreatLockerItemRequest serviceTLRequest, List<ThreatLockerItemDTO> itemDtos)
        {
            ComputerId = serviceTLRequest.ComputerId;
            OrganizationId = serviceTLRequest.OrganizationId;
            Items = itemDtos;
        }

        public Guid ComputerId { get; set; }
        public Guid OrganizationId { get; set; }
        public string CoreOS { get; set; }
        public string OperatingSystem { get; set; }
        public List<ThreatLockerItemDTO> Items { get; set; } = new List<ThreatLockerItemDTO>();

    }

    public class ServiceThreatLockerItemRequest
    {
        public Guid ComputerId { get; set; }
        public Guid ComputerGroupId { get; set; }
        public Guid OrganizationId { get; set; }
        public string Hostname { get; set; }
        public string AuthKey { get; set; }
        public List<ThreatLockerItemDTO> Items { get; set; } = new List<ThreatLockerItemDTO>();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    
    public class ServiceShorthandPutCoreFile
    {
        public string filePath { get; set; }
        public string hash { get; set; }
        public string os { get; set; }
        public string osBuild { get; set; }
    }
    public class ServiceTmpApplicationFile
    {
        public string appId;
        public string dbHash;
        public string dbCert;
        public string dbPath;
        public string notes;
        public int osType;
    }
    public class ServiceFailedQueueEntry
    {
        public string Json;
        public string ConnectionsString;
        public int ConnectionType;
        public string DatabaseName;
        public DateTime DateTime = DateTime.UtcNow;
    }
    public class ServiceThreatLockerLogger
    {
        public string FullPath;
        public string Username;
        public int ActionId;
        public string Hash;
        public List<ThreatLockerCert> Certs;
        public string ProcessName;
        public string ApplicationId;
        public string SerialNumber = "";
        public string DeviceType = "";
        public string ActionType = "execute";
        public string PolicyName = "";
        public string ApplicationName = "";
    }

    public class ThreatLockerKeyFile
    {
        public string Name { get; set; }
        public string Hash { get; set; }
        public Guid Applicationid { get; set; }
    }
}