namespace Relationen
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public bool IsRunning { get; private set; }

        public Engine(int horsePower)
        {
            HorsePower = horsePower;
            IsRunning = false;
        }

        public virtual void Start()
        {
            IsRunning = true;
            Console.WriteLine("Engine started.");
        }

        public virtual void Stop()
        {
            IsRunning = false;
            Console.WriteLine("Engine stopped.");
        }
    }
}