namespace Relationen
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public Car(string make, string model, Engine engine)
        {
            Make = make;
            Model = model;
            Engine = engine;
        }

        

        public virtual void Drive(int distance)
        {
            Engine.Start();
            Console.WriteLine($"{Make} {Model} is driving for {distance} km.");
            Engine.Stop();
        }
    }
}