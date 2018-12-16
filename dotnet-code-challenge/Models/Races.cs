using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Models
{
    [XmlRoot(ElementName = "races")]
    public class Races
    {
        [XmlElement(ElementName = "race")]
        public IEnumerable<Race> Race { get; set; }
    }
}
