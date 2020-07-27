using System;
namespace Xml2Sb.Models
{
    public class HeaderTag
    {
        public HeaderTag(string key, string @value)
        {
            Key = key;
            Value = @value;
        }

        public string Key { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Key}=\"{Value}\"";
        }
    }
}
