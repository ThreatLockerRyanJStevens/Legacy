using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class AntivirusResult
    {
        public string category = "";
        public string engine_name = "";
        public string engine_version = "";
        public string result = "";
        public string method = "";
        public string engine_update = "";

    }

    public class VT
    {
        public data data = new data();
    }

    public class data
    {
        public attributes attributes = new attributes();
    }

    public class attributes
    {

        public Dictionary<string, AntivirusResult> last_analysis_results = new Dictionary<string, AntivirusResult>();
        public int first_seen_itw_date { get; set; }
    }

    public class VirusTotalCacheItem
    {
        public DateTime LastCheckDateTime { get; set; }
        public DateTime? FirstSeenITWDate { get; set; }
        public VT VirusTotalResult { get; set; }
    }
}