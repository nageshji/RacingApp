using System;
using System.Collections.Generic;
using System.Text;

namespace RacingApp.Models
{
    public class Meeting
    {
        public string date { get; set; }
        public string MeetingType { get; set; }
        public Track track { get; set; }
        public string Meetingid { get; set; }
        public Races races { get; set; }
    }
}
