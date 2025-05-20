using Ganss.Xss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ThreatLocker.Shared.Sanitize
{
    public class Sanitize
    {
        public static string CleanString(string dirtyString, params string[] allowedAttributes)
        {
            HtmlSanitizer sanitizer = new HtmlSanitizer();
            foreach (string allowedAttribute in allowedAttributes)
            {
                sanitizer.AllowedAttributes.Add(allowedAttribute);
            }
            return sanitizer.Sanitize(dirtyString);
        }

        public static string CleanString(string dirtyString, char[] allowCharacter)
        {
            HtmlSanitizer sanitizer = new HtmlSanitizer();
            string sanitizedString = sanitizer.Sanitize(dirtyString);

            var allowedChars = allowCharacter
                .Select(c => new { Char = c, Encoded = HttpUtility.HtmlEncode(c) });

            foreach (var item in allowedChars)
            {
                sanitizedString = sanitizedString.Replace(item.Encoded, item.Char.ToString());
            }

            return sanitizedString;
        }

        public static string CleanStringWithImage(string dirtyString, params string[] allowedAttributes)
        {
            HtmlSanitizer sanitizer = new HtmlSanitizer();
            foreach (string allowedAttribute in allowedAttributes)
            {
                sanitizer.AllowedAttributes.Add(allowedAttribute);
            }

            sanitizer.AllowedAttributes.Remove("src");
            sanitizer.RemovingAttribute += (s, e) =>
            {
                List<string> dataImage = new List<string> { "data:image/gif", "data:image/jpeg", "data:image/png", "data:image/jpg", "http://", "https://" };

                if (e.Tag.TagName == "IMG")
                {
                    if (dataImage.Any(x => e.Attribute.Value.StartsWith(x)))
                    {
                        e.Cancel = true;
                    }
                }
            };

            return sanitizer.Sanitize(dirtyString);
        }
    }
}
