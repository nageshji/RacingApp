using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using RacingApp.Models;

namespace dotnet_code_challenge.Repository
{
    internal interface IMeetingContext
    {
        Meeting Meeting { get; }
    }


}
