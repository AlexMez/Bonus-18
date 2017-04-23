using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {
        private string Make;
        private string Model;
        private int Year;
        private double Price;

       //get and set       
        #region       

        private static int Objectcount = 0;

        public string Make1
        {
            get
            {
                return Make;
            }

            set
            {
                Make = value;
            }
        }

        public string Model1
        {
            get
            {
                return Model;
            }

            set
            {
                Model = value;
            }
        }

        public int Year1
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }

        public double Price1
        {
            get
            {
                return Price;
            }

            set
            {
                Price = value;
            }
        }

        #endregion

        public Car(string MakeInput, string ModelInput, int YearInput, double PriceInput)
        {
            Make1 = MakeInput;
            Model1 = ModelInput;
            Year1 = YearInput;
            Price1 = PriceInput;

            Objectcount++;
        }

        public Car()
        {

            Objectcount++;

        }


    }
}
