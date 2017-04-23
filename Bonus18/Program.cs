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
                
                Console.Write($"Enter the Make for Car No. {i + 1} : ");
                string Mmake = Console.ReadLine();
                Console.Write("Enter the model: ");
                string Mmodel = Console.ReadLine();
                Console.Write("Enter the year: ");
                int Year = Validate.RangeValidator(1800, 2018);
                Console.Write("Enter the price: ");
                double Price = Validate.RangeValidDouble(0, 4000000);

                MyCarList.Add(new Car(Mmake, Mmodel, Year, Price));
            }
            Console.WriteLine("------------------------");

            
            foreach (var item in MyCarList)
            {
                Console.WriteLine(item.Make1.ToString());
                //Console.WriteLine("Make" );
                //Console.Write(item.Make1 + item.Model1 + item.Year1 + item.Price1);
            }



            //Car[] CarArray = new Car[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    // filling the lot

            //    Console.WriteLine("-------------");

            //    // making new cars

            //    CarArray[i] = new Car();

            //    Console.WriteLine("Enter the make: ");
            //    CarArray[i].Make1 = Console.ReadLine();

            //    Console.WriteLine("Enter the model: ");
            //    CarArray[i].Model1 = Console.ReadLine();

            //    Console.WriteLine("Enter the year: ");
            //    CarArray[i].Year1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter the price: ");
            //    CarArray[i].Price1 = Convert.ToDouble(Console.ReadLine());


            //}






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
