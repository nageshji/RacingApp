using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft;
using Newtonsoft.Json;
using RacingApp.Models;

namespace dotnet_code_challenge.Repository
{
    internal class MeetingContext : IMeetingContext
    {
        //private readonly IEnumerable<Meeting> _meetings;

        public Meeting Meeting {
            get
            {
                var xml = File.ReadAllText(@"FeedData/Caulfield_Race1.xml");
                var xmldoc = new XmlDocument();
                xmldoc.LoadXml(xml);
                var fromXml = JsonConvert.SerializeXmlNode(xmldoc);
                var racing = JsonConvert.DeserializeObject<Racing>(fromXml);
                var meeting = racing.meeting;
                return meeting;
            }
        }
    }

}
