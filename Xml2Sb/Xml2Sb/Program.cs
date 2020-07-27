using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Xml2Sb.Models;

namespace Xml2Sb
{
    class MainClass
    {
        private const string FILE_PATH = @"../../layout.xml";

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var reader = new XmlTextReader(FILE_PATH);
            while (reader.Read())
            {
                var name = reader.Name;
            }

            var element = new DocumentElement();

            var writer = new StoryboardWriter();
            writer.Write(element);
        }
    }
}
