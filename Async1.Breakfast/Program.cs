using System.Diagnostics;

namespace Async1.Breakfast
{

    // https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/


    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Measuring async parallel breakfast:");
            var swAsync = Stopwatch.StartNew();
            await MakeBreakfastParalell();
            swAsync.Stop();
            Console.WriteLine($"Async parallel breakfast time: {swAsync.ElapsedMilliseconds} ms\n");

            Console.WriteLine("Measuring sync breakfast:");
            var swSync = Stopwatch.StartNew();
            MakeBreakfastSync();
            swSync.Stop();
            Console.WriteLine($"Sync breakfast time: {swSync.ElapsedMilliseconds} ms\n");
        }

        private static void MakeBreakfastSync()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            // Synchronous tasks (executed sequentially)
            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = MakeToastWithButterAndJam(2);
            Console.WriteLine("toast is ready");

            Juice oj = PourJuice();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        private static async Task MakeBreakfastParalell()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }

                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourJuice();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        static Toast MakeToastWithButterAndJam(int number)
        {
            var toast = ToastBread(number);
            ApplyButter(toast);
            ApplyJam(toast);
            return toast;
        }

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Thread.Sleep(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Thread.Sleep(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Thread.Sleep(3000);
            Console.WriteLine("Put bacon on plate");
            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Thread.Sleep(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Thread.Sleep(3000);
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }

        private static Juice PourJuice()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");
        }

        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
        }
    }
}