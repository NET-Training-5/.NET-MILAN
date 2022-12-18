// LINQ Languaage Intregated Query
using System;
using System.Collections.Generic;
using System.Linq;

class LINQ1
{
    int[] numbers = {1, 3, 4, 5, 7, 8, 11, 12, 15, 20, 31, 33, 14, 50, 51, 70, 21, 42, 35 };

    public void LearnToQuery()
    {
        PrintValues(numbers, "Input Array: ");
        // List all even numbers from "numbers" array
        
        //Declarative
        var evenNumbers = numbers.Where( num => num % 2 ==0);
        PrintValues( evenNumbers, "Even Number:");
        // Console.WriteLine("Even Number:");
        // foreach (var item in evenNumbers)
        // Console.Write(item + "");

        //List all odd number which are divisible by 3
        var oddNumbers = numbers.Where( num => num % 2 ! == 0 && num % 3 == 0);
        PrintValues( oddNumbers, "Odd Number:");
        //  Console.WriteLine("Odd numbers divisible by 3:");
        // foreach (var item in oddNumbers)
        // Console.Write(item + "");

         // List multiples of 5 and 7 from "numbers"
         var multiplesOf5and7 = numbers.Where( num => num % 5 == 0 &&  num % 7 == 0 );
         PrintValues( multiplesOf5and7, "Multiples of 5 and 7:");
        //   Console.WriteLine("Multiple of  and 7:");
        // foreach (var item in multiplesOf5and7)
        // Console.Write(item + "");
        

        // List all items less than 100 and ends with 0, from "numbers"
        var numberswithTailing0 = numbers.Where(num => num < 100 && num % 10 == 0);
        PrintValues( numberswithTailing0, "Number Less than 100 and end with 0:");

        //Print Square root of all less than 50
        var SquareRoot1 = numbers.Where(  num => num < 50).Select(num => Math.Round( Math.Sqrt(num), 2));

        

        //Expression Syntax
        // Sort Numbers
        var numbersSorted = numbers.Order();

        //List 5 items skipping first two
        var fiveItems = numbers.Skip(2).Take(5);
        PrintValues(fiveItems, "Skip-Take:");


        //Check if any item is even number
        var isThereAnyEvenNumber = numbers.Any(num => num % 2 == 0 );
        Console.WriteLine($"Any Even: {isThereAnyEvenNumber}");

        //Check if all items are even numbers
        var areAllEvenNumber = numbers.All(num => num % 2 == 0);
        Console.WriteLine($"All Even: {areAllEvenNumber}");



       
    
    }
    public void LearnToQueryOnObjectCollection()
    {
        Person p1 = new() { fullName = "Ram Lama", gender = 'M', height = 169.27f};
        Person p2 = new() { fullName = "Sita Gurung", gender = 'F', height = 165.23f};
        Person p3 = new() { fullName = "Monica Gurung", gender = 'F', height = 166.23f};
        Person p4 = new() { fullName = "Raj Syangbo", gender = 'M', height = 172.23f};
        Person p5 = new() { fullName = "Rabi Tamang", gender = 'M', height = 168.23f};

        List<Person> people = new List<Person>(){ p1, p2, p3, p4, p5};

        //List all females
        var females = people.Where( x => x.gender == 'F');

        //List all males in ascending order of their height
        var males = from p in people
                    where p.gender == 'M'
                    orderby p.height
                    select p;
                    



    }
    void PrintValues<U>(IEnumerable<U> items,  string label)
    {
        Console.Write($"\n{label}");
        foreach(var item in items)
        Console.Write(item + "");
    }
}
