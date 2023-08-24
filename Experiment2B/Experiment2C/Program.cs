using Experiment2B;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ethan
        char firstInitial = 'E';
        char middleInitial = 'O';
        char lastInitial = 'Z';

        // Taps
        char friendFirstInitial = 'A';
        char friendMiddleInitial = 'A';
        char friendLastInitial = 'T';

        // Stored initials using string interpolation
        string ethansInitials = $"{firstInitial}. {middleInitial}. {lastInitial}.";
        string tapsInitials = $"{friendFirstInitial}. {friendMiddleInitial}. {friendLastInitial}.";

        // calls the method with the paramters of where the initials are stored
        DisplayMonogram(ethansInitials);
        DisplayMonogram(tapsInitials);
  
    }

    static void DisplayMonogram(string initials)
    {
        Console.WriteLine("* " + initials + " *");
    }
}