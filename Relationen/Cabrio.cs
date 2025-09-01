namespace Relationen
{
    public class Cabrio : Car
    {
        public bool RoofOpen { get; private set; }

        public Cabrio(string make, string model, Engine engine)
            : base(make, model, engine)
        {
            RoofOpen = false;
        }

        public void OpenRoof()
        {
            RoofOpen = true;
            Console.WriteLine("Roof opened.");
        }

        public void CloseRoof()
        {
            RoofOpen = false;
            Console.WriteLine("Roof closed.");
        }

        public override void Drive(int distance)
        {
            OpenRoof();
            base.Drive(distance);
            CloseRoof();
        }
    }
}