using System;
using System.Collections.Generic;

namespace Xml2Sb.Models
{
    public class DependenciesElement : IStoryboardElement
    { 
    //        <dependencies>
    //    <plugIn identifier="com.apple.InterfaceBuilder.IBCocoaTouchPlugin" version="16087"/>
    //    <capability name="documents saved in the Xcode 8 format" minToolsVersion="8.0"/>
    //</dependencies>
        public DependenciesElement(int indent)
        {
            IndentLevel = indent;
        }

        public int IndentLevel { get; set; }

        public List<IStoryboardElement> GetChildren()
        {
            var list = new List<IStoryboardElement>();
            list.Add(new PluginElement(IndentLevel + 1));
            list.Add(new CapabilityElement(IndentLevel + 1));
            return list;
        }

        public string GetFooter()
        {
            return "</dependencies>";
        }

        public string GetHeader()
        {
            return "<dependencies>";
        }

        public string GetHeaderTags(List<HeaderTag> tags)
        {
            return string.Empty;
        }

        public List<HeaderTag> GetHeaderTagsList()
        {
            return null;
        }
    }
}
