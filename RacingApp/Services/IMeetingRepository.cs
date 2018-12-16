using System;
using System.Collections.Generic;
using System.Text;
using RacingApp.Models;
using dotnet_code_challenge.Repository;

namespace dotnet_code_challenge.Services
{
    interface IMeetingRepository
    {
        //IEnumerable<Meeting> GetMeetings();
        Meeting GetMeeting();
        Race GetRace();
        IEnumerable<Horse> GetHorses();
        decimal GetPrice(int horseNumber);
    }
}
