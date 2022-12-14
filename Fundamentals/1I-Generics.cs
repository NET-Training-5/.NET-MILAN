using System;

class Generic
{
    public void PrintDetails<T>(T message)
    {
        Console.WriteLine(message);
    }
//     public void PrintDetails(char message)
//     {
//         Console.WriteLine(message);
//     }
//     public void PrintDetails(bool message)
//     {
//         Console.WriteLine(message);
//     }
//
 }