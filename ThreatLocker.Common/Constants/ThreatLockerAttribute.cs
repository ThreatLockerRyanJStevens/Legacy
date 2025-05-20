using System;
using System.Collections.Generic;
using System.Linq;
using ThreatLockerCommon.Models;

namespace ThreatLockerCommon.Constants
{
    //TODO: keep *_old classes until there are no services with version 1666 or below
    public class ThreatLockerAttribute_old
    {
        public static readonly AttributeType_old<string> Username = new AttributeType_old<string>(1, "Username");
        public static readonly AttributeType_old<string> ProcessPath = new AttributeType_old<string>(2, "ProcessPath");
        public static readonly AttributeType_old<int> ProcessID = new AttributeType_old<int>(3, "ProcessID");
        public static readonly AttributeType_old<string> CreatedByProcess = new AttributeType_old<string>(4, "CreatedByProcess");
        public static readonly AttributeType_old<Guid> PolicyId = new AttributeType_old<Guid>(5, "PolicyId");
        public static readonly AttributeType_old<string> PolicyName = new AttributeType_old<string>(6, "PolicyName");
        public static readonly AttributeType_old<Guid> ApplicationId = new AttributeType_old<Guid>(7, "ApplicationId");
        public static readonly AttributeType_old<string> ApplicationName = new AttributeType_old<string>(8, "ApplicationName");
        public static readonly AttributeType_old<int> ActionType = new AttributeType_old<int>(9, "ActionType");
        public static readonly AttributeType_old<string> FullPath = new AttributeType_old<string>(10, "FullPath");
        public static readonly AttributeType_old<string> TLHash = new AttributeType_old<string>(11, "TLHash");
        public static readonly AttributeType_old<string> SHA256 = new AttributeType_old<string>(12, "SHA256");
        public static readonly AttributeType_old<long> FileSize = new AttributeType_old<long>(13, "FileSize");
        public static readonly AttributeType_old<string> DeviceType = new AttributeType_old<string>(14, "DeviceType");
        public static readonly AttributeType_old<List<ThreatLockerCert>> Certificates = new AttributeType_old<List<ThreatLockerCert>>(15, "Certificates");
        public static readonly AttributeType_old<string> SourceIPAddress = new AttributeType_old<string>(16, "SourceIPAddress");
        public static readonly AttributeType_old<string> Hostname = new AttributeType_old<string>(17, "Hostname");
        public static readonly AttributeType_old<string> SourcePort = new AttributeType_old<string>(18, "SourcePort");
        public static readonly AttributeType_old<int> DestinationPort = new AttributeType_old<int>(19, "DestinationPort");
        public static readonly AttributeType_old<string> Notes = new AttributeType_old<string>(20, "Notes");
        public static readonly AttributeType_old<string> Data = new AttributeType_old<string>(21, "Data");
        public static readonly AttributeType_old<bool> RemotePresence = new AttributeType_old<bool>(22, "RemotePresence");
        public static readonly AttributeType_old<int> EventLogSourceId = new AttributeType_old<int>(23, "EventLogSourceId");
        public static readonly AttributeType_old<string> NetworkDirection = new AttributeType_old<string>(24, "NetworkDirection");
        public static readonly AttributeType_old<string> DestinationIPAddress = new AttributeType_old<string>(25, "DestinationIPAddress");
        public static readonly AttributeType_old<int> ActionId = new AttributeType_old<int>(26, "ActionId");
        public static readonly AttributeType_old<string> CmdLineParameters = new AttributeType_old<string>(27, "CmdLineParameters");
        public static readonly AttributeType_old<int> ElevationStatus = new AttributeType_old<int>(28, "ElevationStatus");
        public static readonly AttributeType_old<int> EncryptionStatus = new AttributeType_old<int>(29, "EncryptionStatus");
        public static readonly AttributeType_old<bool> IsDotNetDLL = new AttributeType_old<bool>(30, "IsDotNetDLL");
        public static readonly AttributeType_old<bool> KillRunningProcess = new AttributeType_old<bool>(31, "KillRunningProcess");
        public static readonly AttributeType_old<Guid> MaintenanceModeId = new AttributeType_old<Guid>(32, "MaintenanceModeId");
        public static readonly AttributeType_old<string> MD5Hash = new AttributeType_old<string>(33, "MD5Hash");
        public static readonly AttributeType_old<bool> MonitorOnly = new AttributeType_old<bool>(34, "MonitorOnly");
        public static readonly AttributeType_old<bool> Ringfenced = new AttributeType_old<bool>(35, "Ringfenced");
        public static readonly AttributeType_old<Guid> RingfencePolicyId = new AttributeType_old<Guid>(36, "RingfencePolicyId");
        public static readonly AttributeType_old<string> HarddriveSerialNumber = new AttributeType_old<string>(37, "HarddriveSerialNumber");
        public static readonly AttributeType_old<string> VolumeSerialNumber = new AttributeType_old<string>(38, "VolumeSerialNumber");
        public static readonly AttributeType_old<string> SHA1 = new AttributeType_old<string>(39, "SHA1");
        public static readonly AttributeType_old<string> EventLogDescription = new AttributeType_old<string>(40, "EventLogDescription");
        public static readonly AttributeType_old<int> EventLogOccurrences = new AttributeType_old<int>(41, "EventLogOccurrences");
        public static readonly AttributeType_old<int> CurrentThreatLevel = new AttributeType_old<int>(42, "CurrentThreatLevel");
        public static readonly AttributeType_old<int> ActionOccurrences = new AttributeType_old<int>(43, "ActionOccurrences");

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly ThreatLockerAttribute_old[] All =
        {
                Username,
                ProcessPath,
                ProcessID,
                CreatedByProcess,
                PolicyId,
                PolicyName,
                ApplicationId,
                ApplicationName,
                ActionType,
                FullPath,
                TLHash,
                SHA256,
                FileSize,
                DeviceType,
                Certificates,
                SourceIPAddress,
                Hostname,
                SourcePort,
                DestinationPort,
                Notes,
                Data,
                RemotePresence,
                EventLogSourceId,
                NetworkDirection,
                DestinationIPAddress,
                ActionId,
                CmdLineParameters,
                ElevationStatus,
                EncryptionStatus,
                IsDotNetDLL,
                KillRunningProcess,
                MaintenanceModeId,
                MD5Hash,
                MonitorOnly,
                Ringfenced,
                RingfencePolicyId,
                HarddriveSerialNumber,
                VolumeSerialNumber,
                SHA1,
                EventLogDescription,
                EventLogOccurrences,
                CurrentThreatLevel,
                ActionOccurrences
            };

        public static ThreatLockerAttribute_old Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ThreatLockerAttribute_old FindByAttribute(ThreatLockerAttribute_old id)
        {
            return All.FirstOrDefault(x => x == id);
        }
    }

    public class ThreatLockerAttribute
    {
        public static readonly AttributeType<int> ActionOccurrences = new AttributeType<int>(43, "ActionOccurrences");
        public static readonly AttributeType<Guid> ApplicationId = new AttributeType<Guid>(7, "ApplicationId");
        public static readonly AttributeType<string> ApplicationName = new AttributeType<string>(8, "ApplicationName");
        public static readonly AttributeType<ThreatLockerCert> Certificate = new AttributeType<ThreatLockerCert>(15, "Certificate", true);
        public static readonly AttributeType<string> CmdLineParameters = new AttributeType<string>(27, "CmdLineParameters");
        public static readonly AttributeType<string> CreatedByProcess = new AttributeType<string>(4, "CreatedByProcess", true);
        public static readonly AttributeType<int> CurrentThreatLevel = new AttributeType<int>(42, "CurrentThreatLevel");
        public static readonly AttributeType<string> Data = new AttributeType<string>(21, "Data");
        public static readonly AttributeType<string> DestinationIPAddress = new AttributeType<string>(25, "DestinationIPAddress");
        public static readonly AttributeType<int> DestinationPort = new AttributeType<int>(19, "DestinationPort");
        public static readonly AttributeType<string> DeviceType = new AttributeType<string>(14, "DeviceType");
        public static readonly AttributeType<int> ElevationStatus = new AttributeType<int>(28, "ElevationStatus");
        public static readonly AttributeType<int> EncryptionStatus = new AttributeType<int>(29, "EncryptionStatus");
        public static readonly AttributeType<string> EventLogDescription = new AttributeType<string>(40, "EventLogDescription");
        public static readonly AttributeType<int> EventLogOccurrences = new AttributeType<int>(41, "EventLogOccurrences");
        public static readonly AttributeType<long> EventLogSourceId = new AttributeType<long>(23, "EventLogSourceId");
        public static readonly AttributeType<long> FileSize = new AttributeType<long>(13, "FileSize");
        public static readonly AttributeType<string> FullPath = new AttributeType<string>(10, "FullPath");
        public static readonly AttributeType<string> Hostname = new AttributeType<string>(17, "Hostname");
        public static readonly AttributeType<bool> IsDotNetDLL = new AttributeType<bool>(30, "IsDotNetDLL");
        public static readonly AttributeType<bool> KillRunningProcess = new AttributeType<bool>(31, "KillRunningProcess");
        public static readonly AttributeType<Guid> MaintenanceModeId = new AttributeType<Guid>(32, "MaintenanceModeId");
        public static readonly AttributeType<bool> MonitorOnly = new AttributeType<bool>(34, "MonitorOnly");
        public static readonly AttributeType<string> NetworkDirection = new AttributeType<string>(24, "NetworkDirection");
        public static readonly AttributeType<string> Notes = new AttributeType<string>(20, "Notes");
        public static readonly AttributeType<ThreatLockerCert> ParentProcessCertificate = new AttributeType<ThreatLockerCert>(49, "ParentProcessCertificate", true);
        public static readonly AttributeType<long> ParentProcessFileSize = new AttributeType<long>(48, "ParentProcessFileSize");
        public static readonly AttributeType<string> ParentProcessSHA256 = new AttributeType<string>(47, "ParentProcessSHA256");
        public static readonly AttributeType<string> ParentProcessTLHash = new AttributeType<string>(46, "ParentProcessTLHash");
        public static readonly AttributeType<int> ProcessID = new AttributeType<int>(3, "ProcessID");
        public static readonly AttributeType<string> ProcessPath = new AttributeType<string>(2, "ProcessPath");
        public static readonly AttributeType<bool> RemotePresence = new AttributeType<bool>(22, "RemotePresence");
        public static readonly AttributeType<bool> Ringfenced = new AttributeType<bool>(35, "Ringfenced");
        public static readonly AttributeType<string> SerialNumber = new AttributeType<string>(37, "SerialNumber");
        public static readonly AttributeType<string> SHA256 = new AttributeType<string>(12, "SHA256");
        public static readonly AttributeType<string> SourceIPAddress = new AttributeType<string>(16, "SourceIPAddress");
        public static readonly AttributeType<string> TLHash = new AttributeType<string>(11, "TLHash");
        public static readonly AttributeType<string> DestinationDomain = new AttributeType<string>(45, "DestinationDomain");

        public int Id { get; set; }
        public bool IsArray { get; set; }
        public string Name { get; set; }

        public static readonly ThreatLockerAttribute[] All =
        {
            ActionOccurrences,
            ApplicationId,
            ApplicationName,
            Certificate,
            CmdLineParameters,
            CreatedByProcess,
            CurrentThreatLevel,
            Data,
            DestinationDomain,
            DestinationIPAddress,
            DestinationPort,
            DeviceType,
            ElevationStatus,
            EncryptionStatus,
            EventLogDescription,
            EventLogOccurrences,
            EventLogSourceId,
            FileSize,
            FullPath,
            Hostname,
            IsDotNetDLL,
            KillRunningProcess,
            MaintenanceModeId,
            MonitorOnly,
            NetworkDirection,
            Notes,
            ParentProcessCertificate,
            ParentProcessFileSize,
            ParentProcessSHA256,
            ParentProcessTLHash,
            ProcessID,
            ProcessPath,
            RemotePresence,
            Ringfenced,
            SerialNumber,
            SHA256,
            SourceIPAddress,
            TLHash,
        };

        public static ThreatLockerAttribute Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static ThreatLockerAttribute FindByAttribute(ThreatLockerAttribute id)
        {
            return All.FirstOrDefault(x => x == id);
        }
    }
}
