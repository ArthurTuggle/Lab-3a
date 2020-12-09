using System;

namespace Solve 
{

   class CelsiusToFahrenheit 
   {

      static void Main(string[] args) 
      {

         double fahrenheit;
         double celsius;
         string input;
         Console.WriteLine("Enter temperature");
         input = Console.ReadLine();
                 
             celsius = Convert.ToDouble(input);

         fahrenheit = (celsius * 9) / 5 + 32;
         
         Console.WriteLine("Fahrenheit equivalent for {0} degree celsius is {1}",celsius,fahrenheit);
         
         if(fahrenheit<32)
         Console.WriteLine("The temperature is below freezing temperature of 32 degrees fahrenheit");
         
         else if(fahrenheit>212)
         Console.WriteLine("The temperature is above boiling temperature of 212 degrees fahrenheit");
         
         Console.ReadLine();
      }
   }
}