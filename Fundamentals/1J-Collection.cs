using System;
using System.Collections.Generic;

class Collection
{
    void LearnList()
    {
        List<byte> numbers = new List<byte>();
        numbers.Add(23);
        numbers.Add(123);
        numbers.Add(237);
        numbers.Add(253);
        numbers.Add(73);
        numbers.Remove(23);

        List<string> names = new List<string>() { "Milan", "Lama"};
        foreach ( var item in names)
        {
           Console.WriteLine(item);
        }

    }

   void LearnDictionary()
   {
    Dictionary<string, long> CountryPopulation = new();
    CountryPopulation.Add("Nepal",1234556 );
    CountryPopulation.Add("Usa", 9185626727 );
    CountryPopulation.Add("India",62288292902 );
    CountryPopulation.Add("China", 60209282891 );
    CountryPopulation.Add("Bhutan", 8898182812811 );
    CountryPopulation.Add("Argetina",997786767565 );
    
    CountryPopulation.Remove("Usa");
   } 
}