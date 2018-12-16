using System;
using dotnet_code_challenge.Models;
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
            Console.WriteLine("Hello World!");
            
            IMeetingRepository meetingRepository = new MeetingRepository(new MeetingContext());
            var horses = meetingRepository.GetHorses(92217, 1536514);
            Console.WriteLine("HorseNames");
            foreach (var horse in horses)
            {
                Console.WriteLine(horse.Name);
            }
        }
    }
}
