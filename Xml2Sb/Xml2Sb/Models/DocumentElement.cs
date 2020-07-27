using System;
namespace Xml2Sb.Models
{
    public class DocumentElement : IStoryboardElement
    {
        public string GetHeader()
        {
            return "<document >";
        }
    }
}
