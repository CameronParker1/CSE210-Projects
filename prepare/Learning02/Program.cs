using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Cybersecurity Specialist";
        job1.Company = "INL";
        job1.StartYear = "2012";
        job1.EndYear = "2018";

        Job job2 = new Job();
        job2.JobTitle = "Software Engineer";
        job2.Company = "Google";
        job2.StartYear = "2018";
        job2.EndYear = "2023";

        Resume MyResume = new Resume();
        MyResume.Name = "Cameron Parker";

        MyResume.job.Add(job1);
        MyResume.job.Add(job2);

        MyResume.Display();
    }
}