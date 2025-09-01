namespace Relationen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create car and cabrio objects before asking the user
            var carEngine = new Engine(150);
            var car = new Car("Toyota", "Corolla", carEngine);

            var cabrioEngine = new Engine(200);
            var cabrio = new Cabrio("BMW", "Z4", cabrioEngine);

            Car myVehicle;

            Console.WriteLine("Which car would you like to use for driving? (car/cabrio):");
            string? choice = Console.ReadLine();


            if (choice != null && choice.Trim().ToLower() == "cabrio")
            {
                myVehicle = cabrio;
            }
            else
            {
                myVehicle = car;
            }

            myVehicle.Drive(50);

            Console.WriteLine("Drive finished.");
        }
    }
}
