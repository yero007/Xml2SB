using System;
using System.Collections.Generic;

namespace Xml2Sb.Models
{
    public class DeviceElement : IStoryboardElement
    {
        //<device id = "retina6_1" orientation="portrait" appearance="light"/>
        public DeviceElement(int indent)
        {
            IndentLevel = indent;
        }

        public int IndentLevel { get; set; }

        public List<IStoryboardElement> GetChildren()
        {
            return null;
        }

        public string GetFooter()
        {
            return "/>";
        }

        public string GetHeader()
        {
            return $"<device {GetHeaderTags(GetHeaderTagsList())}";
        }

        public string GetHeaderTags(List<HeaderTag> tags)
        {
            var text = string.Join(" ", tags);
            return text;
        }

        public List<HeaderTag> GetHeaderTagsList()
        {
            var tagList = new List<HeaderTag>
            {
                new HeaderTag("id", "retina6_1"),
                new HeaderTag("orientation", "portrait"),
                new HeaderTag("appearance", "light")
            };
            return tagList;
        }
    }
}
