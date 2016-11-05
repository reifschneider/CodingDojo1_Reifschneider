using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_Reifschneider
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine();
            Console.WriteLine("Choose input type by pressing the correct number: \n1) Celsius \n2) Fahrenheit \n3) Reamur \n4) Kelvin");
            String eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    Console.WriteLine("You chose Celsius as input type.");
                    break;
                case "2":
                    Console.WriteLine("You chose Fahrenheit as input type.");
                    break;
                case "3":
                    Console.WriteLine("You chose Reamur as input type.");
                    break;
                case "4":
                    Console.WriteLine("You chose Kelvin as input type.");
                    break;
                default:
                    Console.WriteLine("Please enter a value between 1 and 4.");
                    break;
            }


            Console.WriteLine();
            Console.WriteLine("Please enter a temperature value of your chosen input type that you want to convert.");
            String value = Console.ReadLine();
            double number = Convert.ToDouble(value);



            Console.WriteLine();
            Console.WriteLine("Choose output type by pressing the correct number: \n1) Celsius \n2) Fahrenheit \n3) Reamur \n4) Kelvin");
            String ausgabe = Console.ReadLine();

            switch (ausgabe)
            {
                case "1":
                    Console.WriteLine("You chose Celsius as output type.");
                    break;
                case "2":
                    Console.WriteLine("You chose Fahrenheit as output type.");
                    break;
                case "3":
                    Console.WriteLine("You chose Reamur as output type.");
                    break;
                case "4":
                    Console.WriteLine("You chose Kelvin as output type.");
                    break;
                default:
                    Console.WriteLine("Please enter a value between 1 and 4.");
                    break;
            }

            int input = Int32.Parse(eingabe);
            int output = Int32.Parse(ausgabe);

            double result = 0;

            if (input == output)
            {
                result = number;
            }
            else if (input == 1)
            {
                if (output == 2)
                    result = number * 1.8 + 32;
                else if (output == 3)
                    result = 0.8 * number;
                else if (output == 4)
                    result = number + 273.15;
            }
            else if (input == 2)
            {
                if (output == 1)
                    result = (number - 32) / 1.8;
                else if (output == 3)
                    result = (number - 32) / 2.25;
                else if (output == 4)
                    result = (number + 459.67) / 1.8;
            }
            else if (input == 3)
            {
                if (output == 1)
                    result = number / 0.8;
                else if (output == 2)
                    result = number * 2.25 + 32;
                else if (output == 4)
                    result = number * 1.25 + 273.15;
            }
            else if (input == 4)
            {
                if (output == 1)
                    result = number - 273.15;
                else if (output == 2)
                    result = number * 1.8 - 459.67;
                else if (output == 3)
                    result = (number - 273.15) * 0.8;
            }

            //http://www.sengpielaudio.com/Rechner-fahrenheitformel.htm
            //http://www.umrechnung.org/masseinheiten-temperatur-celsius-fahrenheit-kelvin/celsius-fahrenheit-umrechnung.htm

            Console.WriteLine();
            Console.WriteLine("The result is: {0}", result);

            Console.ReadLine();
        }
    }
}
