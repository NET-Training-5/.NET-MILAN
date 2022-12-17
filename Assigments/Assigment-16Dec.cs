// Create an array containing 20 country names. Query this collection to answer following:

// List all countries starting with letter N.
// List all countries which have length of 4 or less.
// Convert all countries to uppercase.


using System;
using System.Collections.Generic;
using System.Linq;
class LINQ3
{
    string[] Countries = {"Nepal", "USA", "UAE", "Japan", "Qatar", "Australia", "England", "India", "Bhutan", "China","UK", "Kuwait", "Wales", "Argentina", "France", "Korea", "Pakistan", "Poland", "Italy", "Brazil"};
    public void LearnAboutLinq()
    {
        PrintValues(Countries, "Input Array: ");

        // List all countries starting with letter N.
        var countryWithN = Countries.Where( x => x.StartsWith('N'));
        PrintValues(countryWithN, "Countries starting with letter N:");

        // List all countries which have length of 4 or less.
        var countryWithL4 = Countries.Where( x => x.Length <=4);
        PrintValues (countryWithL4, "Countries which have length of 4 or less:");

        // Convert all countries to uppercase.
        var countryToUp = Countries.Where(x => x.ToUpper() == x);
        PrintValues (countryToUp, "Countries to Uppercase:");



    }
      void PrintValues(IEnumerable<string> results,  string label)
    {
        Console.Write($"\n{label}");
        foreach(var item in results)
        Console.Write(item + "");
    }
}