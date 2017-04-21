using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many cars do you want to enter?");

            int numberOfCars = RangeValidator(1, 100);

            Car[] CarArray = new Car[numberOfCars]; // making the lot

            List<Car> MyCarList = new List<Car>();
           
            for (int i = 0; i < numberOfCars; i++)
            {
                // filling the lot

                Console.WriteLine("-------------");
                
                // making new cars

                CarArray [i] = new Car();
                         
                Console.WriteLine("Enter the make: ");
                CarArray[i].Make1 = Console.ReadLine();

                Console.WriteLine("Enter the model: ");
                CarArray[i].Model1 = Console.ReadLine();

                Console.WriteLine("Enter the year: ");
                CarArray[i].Year1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the price: ");
                CarArray[i].Price1 = Convert.ToDouble(Console.ReadLine());
                             

            }

            Console.WriteLine("-------------------");

            foreach (var item in CarArray)
            {
                Console.WriteLine(item.Price1);
                              
            }
            Console.WriteLine("------------------------");
            foreach (var item in CarArray)
            {
                Console.WriteLine(item.Model1);
                
            }
            Console.WriteLine("---------------------------");
            foreach (var item in CarArray)
            {
                Console.WriteLine(item.Make1);
               
            }
            Console.WriteLine("-------------------------");
            foreach (var item in CarArray)
            {
                Console.WriteLine(item.Year1);
               
            }


            
           
            


            Console.WriteLine("----------------");

            foreach (Car item in CarArray)
            {
                MyCarList.Add(item);
            }
            
            
        }
        public static int RangeValidator(int min, int max)

        {

            int input;

            //Console.WriteLine($"Please enter an Integer between {min} and {max}");

            input = GetValidInteger();

            while (input < min || input > max)

            {

                Console.WriteLine("Wrong input! please enter number within range!");

                input = GetValidInteger();

            }

            return input;



        }
        public static int GetValidInteger()
        {
            int input;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("This is not a integer, please enter a integer");
            }
            return input;
        }
    }
}
