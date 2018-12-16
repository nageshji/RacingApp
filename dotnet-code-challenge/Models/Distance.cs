using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Models
{
    [XmlRoot(ElementName = "distance")]
    public class Distance
    {
        [XmlAttribute(AttributeName = "metres")]
        public string Metres { get; set; }
    }
}
