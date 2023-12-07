using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Event 1: \n" );

        Lecture lecture = new Lecture("Professor Maxwell Anderson", 150);
        lecture.StandardDetails();
        lecture.FullDetails(lecture.SetSpecifics());
        lecture.ShortDescription();

        Console.WriteLine("Event 2: \n");

        Reception reception = new Reception("reception.planner@gmail.com");
        reception.StandardDetails();
        reception.FullDetails(reception.DisplayRsvpMessage());
        reception.ShortDescription();

        Console.WriteLine("Event 3: \n");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Friday, August 18th", "95");
        outdoorGathering.StandardDetails();
        outdoorGathering.FullDetails(outdoorGathering.GetForecast());
        outdoorGathering.ShortDescription();
    }
}