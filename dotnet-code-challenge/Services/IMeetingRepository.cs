using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.Repository;

namespace dotnet_code_challenge.Services
{
    interface IMeetingRepository
    {
        IEnumerable<Meeting> GetMeetings();
        Meeting GetMeeting(int meetingId);
        IEnumerable<Race> GetRaces(int meetingId);
        IEnumerable<Horse> GetHorses(int meetingId, int raceId);
    }
}
