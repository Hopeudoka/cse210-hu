using System;
using System.Collections.Generic;

namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._company = "Apple";
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2024;
            job1._endYear = 2040;

            // job1.DisplayJobInfo();

            Job job2 = new Job();
            job2._company = "Microsoft";
            job2._jobTitle = "Project Manager";
            job2._startYear = 2040;
            job2._endYear = 2055;

            // job2.DisplayJobInfo();


            Resume resume = new Resume();
            resume._name = "Hope udoka";
            
            resume._jobList.Add(job1);
            resume._jobList.Add(job2);

            resume.DisplayResume();
            // Console.WriteLine($"{resume._jobList[0]._jobTitle}");


        }
    }
}
