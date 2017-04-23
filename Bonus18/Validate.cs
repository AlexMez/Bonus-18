using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Validate
    {

        int min;
        int max;

        #region

        public int Min
        {
            get
            {
                return min;
            }

            set
            {
                min = value;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }

            set
            {
                max = value;
            }
        }

        #endregion

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

        public static double GetValidDouble()
        {
            double input;

            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("This is not a valid number");
            }
            return input;
        }

        public static double RangeValidDouble(int min, int max)

        {

            double input;

            //Console.WriteLine($"Please enter an Integer between {min} and {max}");

            input = GetValidDouble();

            while (input < min || input > max)

            {

                Console.WriteLine("Wrong input! please enter number within range!");

                input = GetValidDouble();

            }

            return input;



        }



    }
}
