using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Repository
{
    internal class MeetingContext : IMeetingContext
    {
        //private readonly IEnumerable<Meeting> _meetings;

        public IEnumerable<Meeting> Meetings {
            get
            {
                XmlSerializer xml = new XmlSerializer(typeof(IEnumerable<Meeting>));
                FileStream xmlStream = new FileStream(@"/FeedData/Caulfield_Race1.xmlFile.xml", FileMode.Open);
                return (IEnumerable<Meeting>) xml.Deserialize(xmlStream);
            }
        }
    }

}
