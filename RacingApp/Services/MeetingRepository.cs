using RacingApp.Models;
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
        public Meeting GetMeeting()
        {
            return _context.Meeting;
        }

        public decimal GetPrice(int horseNumber)
        {
            return _context.Meeting.races.race.prices.price.HorsePrices.HorsePrice.FirstOrDefault(h => h.HorseNumber == horseNumber).Price;
        }

        public Race GetRace()
        {
            return _context.Meeting.races.race;
        }

        IEnumerable<Horse> IMeetingRepository.GetHorses()
        {
            var horses = _context.Meeting.races.race.horses.horse;
            foreach(var horse in horses)
            {
                horse.Price = GetPrice(horse.number);
            }
            return horses.OrderBy(h => h.Price);
        }
    }
}
