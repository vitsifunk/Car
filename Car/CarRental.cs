using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class CarRental
    {
        public CarRental(string firstName, string lastName, int numberOfDays)
        {
            FirstName = firstName;
            LastName = lastName;
            NumberOfDays = numberOfDays;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfDays { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Customer: {FirstName} {LastName}");
            Console.WriteLine($"Rental Days: {NumberOfDays}");
        }
    
    }
}
