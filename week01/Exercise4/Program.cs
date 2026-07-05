using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers,type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int number = -1;
        while (number !=0)
        {
           Console.Write("Enter number: ");
           number = int.Parse(Console.ReadLine()); 

           if (number !=0)
           {  
               numbers.Add(number);
           } 
        }

        int sum = 0;

        foreach (int numb in numbers)
        {
            sum += numb;
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int larger = numbers[0];
        foreach (int numb in numbers)
        {
            if (numb > larger)
            {
                larger = numb;
            }
        }
        
        Console.WriteLine($"The largest number is: {larger}");

    }
}