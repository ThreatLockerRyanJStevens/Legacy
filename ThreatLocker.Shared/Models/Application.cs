using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Models
{
    public class Application
    {
		public string Name { get; set; }

		public Guid? ApplicationFamilyId { get; set; }

        public Guid OrganizationId { get; set; }

		public string? Hash { get; set; }

		public string? Signature { get; set; }

		public string? Path { get; set; }

        public DateTime DateCreated { get; set; }


        public string? PermitLibraries { get; set; }

		public bool? RequireLibraryCertificate { get; set; }

		public string? InstallerHash { get; set; }

		public int? AppVer { get; set; }

		public string? Json { get; set; }

		public int Status { get; set; }

		public string? Description { get; set; }

		public int? OSType { get; set; }

        public Guid ApplicationId { get; set; }
}
}
