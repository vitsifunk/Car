
namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarRental rental1 = new("Vaios", "Tsiaras", 10);
            CarRental rental2 = new("Thanasis", "Thanasopoulos", 10);
            Console.WriteLine("First Rent");
            rental1.DisplayInfo();
            rental2.DisplayInfo();

            rental1.FirstName = "Giannis";
            rental1.LastName = "Giannaros";
            rental1.NumberOfDays = 1;

            rental2.FirstName = "Eleni";
            rental2.LastName = "Elenakou";
            rental2.NumberOfDays = 12;

            Console.WriteLine("\nUpdated Rental info: ");

            rental1.DisplayInfo();
            rental2.DisplayInfo();
        }
    }
}
