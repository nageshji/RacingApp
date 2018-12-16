using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Repository
{
    internal interface IMeetingContext
    {
        IEnumerable<Meeting> Meetings { get; }
    }


}
