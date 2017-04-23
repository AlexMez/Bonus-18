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

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            Console.Write("How many cars are you entering: ");
            int NumofCars = Validate.GetValidInteger();
            List<Car> MyCarList = new List<Car>();

            for (int i = 0; i < NumofCars; i++)
            {
                
                Console.Write($"Enter the Make for Car No. {i + 1}: ");
                string Mmake = Console.ReadLine();
                Console.Write($"Enter the model for Car No. {i + 1}: ");
                string Mmodel = Console.ReadLine();
                Console.Write($"Enter the year for Car No. {i + 1}: ");
                int Year = Validate.RangeValidator(1800, 2018);
                Console.Write($"Enter the price for Car No. {i + 1} ");
                double Price = Validate.RangeValidDouble(0, 4000000);
                MyCarList.Add(new Car(Mmake, Mmodel, Year, Price));
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
          
            Console.WriteLine("{0,10}{1,10}{2,11}{2,12}", "Make", "Model", "Year", "Price");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var item in MyCarList)
            {
                Console.WriteLine("{0,10}{1,10}{2,11}{3,12}", item.Make1, item.Model1, item.Year1, item.Price1);
              
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
