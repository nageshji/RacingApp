using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotnet_code_challenge.Repository;

namespace dotnet_code_challenge.Services
{
    class MeetingRepository : IMeetingRepository
    {
        private readonly IMeetingContext _context;
        public MeetingRepository(IMeetingContext context)
        {
            _context = context;
        }
        public Meeting GetMeeting(int meetingId)
        {
            return _context.Meetings.FirstOrDefault(m => m.Meetingid == meetingId);
        }

        public IEnumerable<Meeting> GetMeetings()
        {
            return _context.Meetings;
        }

        public IEnumerable<Race> GetRaces(int meetingId)
        {
            return _context.Meetings.FirstOrDefault(m => m.Meetingid == meetingId)?.Races.Race;
        }

        IEnumerable<Horse> IMeetingRepository.GetHorses(int meetingId, int raceId)
        {
            return _context.Meetings.FirstOrDefault(m => m.Meetingid == meetingId)?.Races.Race.FirstOrDefault(r => r.Id == raceId)?.Horses.Horse;
        }
    }
}
