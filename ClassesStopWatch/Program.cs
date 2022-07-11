﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStopWatch
{
    public class StopWatch
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }
        public TimeSpan TimeDifference { get; set; }
        public DateTime Start()
        {
            this.TimeStart = DateTime.Now;
            return this.TimeStart;
        }
        public DateTime Stop()
        {
            this.TimeStop = DateTime.Now;
            return DateTime.Now;
        }
        public TimeSpan Result()
        {
            this.TimeDifference = TimeStop - TimeStart;
            return this.TimeDifference;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            Console.WriteLine("This is a stopwatch. \nType 'start' to start and 'stop' to stop.");
            var userStart = Console.ReadLine().ToLower().Trim();
            if (userStart == "start")
            {
                stopWatch.Start();
                Console.WriteLine(stopWatch.Start());
            }
            Console.WriteLine("Type 'stop' to stop.");
            var userStop = Console.ReadLine().ToLower().Trim();
            if (userStop == "stop")
            {
                stopWatch.Stop();
                //stopWatch.Result();
                Console.WriteLine(stopWatch.Result());
            }

        }
    }
}