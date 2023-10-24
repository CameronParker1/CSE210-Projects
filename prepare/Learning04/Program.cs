using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.StudentName = "Samuel Bennett";
        assignment.topic = "Multiplication";

        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment();
        math.StudentName = "Roberto Rodriguez";
        math.topic = "Fractions";
        math.TextbookSection = "Section 7.3";
        math.problems = "Problems 8-19";

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment();
        writing.StudentName = "Mary Waters";
        writing.topic = "European History";
        writing.title = "The Causes of World War II by Mary Waters";

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}