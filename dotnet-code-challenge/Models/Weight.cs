using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Models
{
    [XmlRoot(ElementName = "weight")]
    public class Weight
    {
        [XmlAttribute(AttributeName = "allocated")]
        public string Allocated { get; set; }
        [XmlAttribute(AttributeName = "total")]
        public string Total { get; set; }
    }
}
