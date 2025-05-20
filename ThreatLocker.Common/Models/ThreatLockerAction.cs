using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLockerCommon.Constants;

namespace ThreatLockerCommon.Models
{
    public class ThreatLockerAction
    {
        public ThreatLockerAction()
        {
        }

        public ThreatLockerAction(ThreatLockerItemDTO dto)
        {
            fullpath = dto.GetAttributeValue(ThreatLockerAttribute.FullPath).ToSafeString();
            policyid = dto.PID.ToSafeString();
            username = dto.U.ToSafeString();
            actionid = dto.AID.ToSafeInt();
            hash = dto.GetAttributeValue(ThreatLockerAttribute.TLHash).ToSafeString();
            certs = dto.GetAttributeValues(ThreatLockerAttribute.Certificate)?.ToList() ?? new List<ThreatLockerCert>();
            applicationId = dto.GetAttributeValue(ThreatLockerAttribute.ApplicationId).ToSafeString();
            datetime = dto.D.ToSafeDateTime();
            serialNumber = dto.GetAttributeValue(ThreatLockerAttribute.SerialNumber).ToSafeString();
            deviceType = dto.GetAttributeValue(ThreatLockerAttribute.DeviceType).ToSafeString();
            actionType = ActionType.FindById(dto.AT)?.Value ?? "execute";
            size = dto.GetAttributeValue(ThreatLockerAttribute.FileSize).ToSafeLong();
            processName = dto.GetAttributeValue(ThreatLockerAttribute.ProcessPath).ToSafeString();
            processId = dto.GetAttributeValue(ThreatLockerAttribute.ProcessID).ToSafeInt();
            ringFence = dto.GetAttributeValue(ThreatLockerAttribute.Ringfenced).ToSafeBool();
            policyName = dto.PN.ToSafeString();
            applicationName = dto.GetAttributeValue(ThreatLockerAttribute.ApplicationName).ToSafeString();
            encryptionStatus = dto.GetAttributeValue(ThreatLockerAttribute.EncryptionStatus).ToSafeInt();
            monitorOnly = dto.GetAttributeValue(ThreatLockerAttribute.MonitorOnly).ToSafeBool();
            notes = dto.GetAttributeValue(ThreatLockerAttribute.Notes).ToSafeString();
            sha256 = dto.GetAttributeValue(ThreatLockerAttribute.SHA256).ToSafeString();
            remotePresence = dto.GetAttributeValue(ThreatLockerAttribute.RemotePresence).ToSafeBool();
            installedBy = dto.GetAttributeValues(ThreatLockerAttribute.CreatedByProcess)?.ToList() ?? new List<string>();
            data = dto.GetAttributeValue(ThreatLockerAttribute.Data).ToSafeString();
            maintenanceModeId = dto.GetAttributeValue(ThreatLockerAttribute.MaintenanceModeId).ToSafeGuid();
            hostname = dto.GetAttributeValue(ThreatLockerAttribute.Hostname).ToSafeString();
        }

        public ThreatLockerAction(ServiceShorthandTLAction ta)
        {
            fullpath = ta.fp.ToSafeString();
            policyid = ta.pyid.ToSafeString();
            username = ta.u.ToSafeString();
            actionid = ta.a.ToSafeInt();
            hash = ta.h.ToSafeString();
            certs = ta.c ?? new List<ThreatLockerCert>();
            applicationId = ta.aid.ToSafeString();
            datetime = ta.t.ToSafeDateTime();
            serialNumber = ta.sn.ToSafeString();
            deviceType = ta.dt.ToSafeString();
            actionType = ta.at ?? "execute";
            size = ta.s.ToSafeLong();
            processName = ta.pn.ToSafeString();
            processId = ta.pid.ToSafeInt();
            ringFence = ta.rf.ToSafeBool();
            policyName = ta.p.ToSafeString();
            applicationName = ta.ap.ToSafeString();
            encryptionStatus = ta.e.ToSafeInt();
            monitorOnly = ta.mo.ToSafeBool();
            notes = ta.n.ToSafeString();
            sha256 = ta.s256.ToSafeString();
            remotePresence = ta.rp.ToSafeBool();
            installedBy = JsonConvert.DeserializeObject<List<string>>(ta.cb) ?? new List<string>();
            data = ta.d.ToSafeString();
            maintenanceModeId = ta.mid.ToSafeGuid();
            hostname = ta.hostname.ToSafeString();
            computerId = ta.computerId;
            organizationId= ta.organizationId;
        }

        public string fullpath { get; set; }
        public string destinationIP { get; set; }
        public string policyid { get; set; }
        public string username { get; set; }
        public int actionid { get; set; }
        public string hash { get; set; } = string.Empty;
        public string processName { get; set; } = string.Empty;
        public List<ThreatLockerCert> certs { get; set; } = new List<ThreatLockerCert>();
        public string applicationId { get; set; }
        public DateTime datetime { get; set; }
        public bool logAction { get; set; } = true;
        public string serialNumber { get; set; } = string.Empty;
        public string deviceType { get; set; } = string.Empty;
        public string actionType { get; set; } = ActionType.Execute.Value;
        public long size { get; set; }
        public int processId { get; set; }
        public bool ringFence { get; set; }
        public string policyName { get; set; } = string.Empty;
        public string applicationName { get; set; } = string.Empty;
        public int encryptionStatus { get; set; } = 2;
        public bool monitorOnly { get; set; }
        public string notes { get; set; } = string.Empty;
        public string sha256 { get; set; } = string.Empty;
        public string md5 { get; set; } = string.Empty;
        public string sha1 { get; set; } = string.Empty;
        public string ringfencePolicyId { get; set; }
        public bool remotePresence { get; set; }
        public List<string> installedBy { get; set; } = new List<string>();
        public string data { get; set; } = string.Empty;
        public int elevationStatus { get; set; } = PolicyElevationStatus.DoNotElevate;
        public Guid maintenanceModeId { get; set; } = Guid.Empty;
        public bool killRunningProcess { get; set; }
        public string CmdLine { get; set; } = string.Empty;
        public bool skipProcessing { get; set; }
        public bool IsDotNetDll { get; set; }
        public bool IsOCX { get; set; }
        public string DomainName { get; set; } = string.Empty;
        public string organizationId { get; set; }
        public string hostname { get; set; }
        public string computerId { get; set; }
        public int OSType { get; set; } = OperatingSystemType.Windows.Id;
    }
}
