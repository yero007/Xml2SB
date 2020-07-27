using System;
using System.Collections.Generic;
using System.Linq;

namespace Xml2Sb.Models
{
    public class DocumentElement : IStoryboardElement
    {
        public int IndentLevel { get; set; }

        public List<IStoryboardElement> GetChildren()
        {
            var list = new List<IStoryboardElement>();
            var deviceElement = new DeviceElement(IndentLevel +1);
            list.Add(deviceElement);
            return list;
        }

        public string GetFooter()
        {
            return "</document>";
        }

        public string GetHeader()
        {
            return $"<document {GetHeaderTags(GetHeaderTagsList())}>";
        }

        public List<HeaderTag> GetHeaderTagsList()
        {
            var tagList = new List<HeaderTag>
            {
                new HeaderTag("type", "com.apple.InterfaceBuilder3.CocoaTouch.Storyboard.XIB"),
                new HeaderTag("version", "3.0"),
                new HeaderTag("toolsVersion", "16097"),
                new HeaderTag("targetRuntime", "iOS.CocoaTouch"),
                new HeaderTag("useAutolayout", "YES"),
                new HeaderTag("useTraitCollections", "YES"),
                new HeaderTag("colorMatched", "YES"),
                //todo:fix this
                new HeaderTag("initialViewController", "JpR-GN-ySC")
            };
            return tagList;
        }

        public string GetHeaderTags(List<HeaderTag> tags)
        {
            var text = string.Join(" ", tags);
            return text;
        }
    }
}
