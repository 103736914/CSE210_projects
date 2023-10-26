using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Console.WriteLine();

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        string mathAssignmentSummary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathAssignmentSummary);
        Console.WriteLine(homeworkList);

        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Walters", "European History", "The Causes of World War II");
        string writingAssignmentSummary = writingAssignment.GetSummary();
        string writingInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignmentSummary);
        Console.WriteLine(writingInformation);

        Console.WriteLine();
        
    }
}

