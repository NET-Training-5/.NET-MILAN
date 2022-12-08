using System;
public class AreaOfRectangle
{
    public static void Main()
    {
        Console.WriteLine("Enter number of rows :");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine("\n");
        }
        Console.ReadKey();
    }
}  
public class Pyramid 
{  
    public static void Main() 
{
   int i, j, rows;
   Console.Write("Enter number of rows : ");
   rows= Convert.ToInt32(Console.ReadLine());   
   for(i=1;i<=rows;i++)
   {
	for(j=1;j<=i;j++)
	   Console.Write("{0}",j);
	Console.Write("\n");
   }
  }
}
