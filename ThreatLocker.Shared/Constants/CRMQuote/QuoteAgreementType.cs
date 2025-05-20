using System.Linq;

namespace ThreatLocker.Shared.Constants.CRMQuote
{
    public class QuoteAgreementType
    {
        public static readonly QuoteAgreementType New = new QuoteAgreementType("new", "New");
        public static readonly QuoteAgreementType Replace = new QuoteAgreementType("replace", "Replace");
        public static readonly QuoteAgreementType Append = new QuoteAgreementType("append", "Append");
        public static readonly QuoteAgreementType Onetime = new QuoteAgreementType("onetime", "One-time");

        public QuoteAgreementType(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }

        public static readonly QuoteAgreementType[] All =
        {
            New,
            Replace,
            Append,
            Onetime,
        };

        public static QuoteAgreementType Find(string value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static QuoteAgreementType FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
