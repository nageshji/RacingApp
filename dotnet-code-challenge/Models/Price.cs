using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Models
{
    [XmlRoot(ElementName = "price")]
    public class Price
    {
        [XmlElement(ElementName = "priceType")]
        public string PriceType { get; set; }
        [XmlElement(ElementName = "horses")]
        public Horses Horses { get; set; }
    }
}
