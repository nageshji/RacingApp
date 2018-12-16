using System;
using RacingApp.Models;
using dotnet_code_challenge.Repository;
using dotnet_code_challenge.Services;

namespace dotnet_code_challenge
{
    class Program
    {
        private IMeetingRepository _meetingRepository;
        void InitializeMeetings()
        {
            _meetingRepository = new MeetingRepository(new MeetingContext());
        }

        static void Main(string[] args)
        {
            IMeetingRepository meetingRepository = new MeetingRepository(new MeetingContext());
            var horses = meetingRepository.GetHorses();
            Console.WriteLine("List of Horses order by Prices are");
            Console.WriteLine("==================================");
            foreach (var horse in horses)
            {
                Console.WriteLine(horse.name + "-" + horse.Price);
            }
            Console.Write("Press any key to exit:");
            Console.Read();
        }
    }
}
