using System;
using System.Collections.Generic;

namespace Xml2Sb.Models
{
    public interface IStoryboardElement
    {
        string GetHeader();
        string GetFooter();
        int IndentLevel { get; set; }
        List<IStoryboardElement> GetChildren();
        List<HeaderTag> GetHeaderTagsList();
        string GetHeaderTags(List<HeaderTag> tags);
    }
}
