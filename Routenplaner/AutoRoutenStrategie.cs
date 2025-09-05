namespace Routenplaner
{
    public class AutoRoutenStrategie : IRoutenStrategie
    {
        public string PlaneRoute(string startPunkt, string endPunkt)
        {
            return $"Route von {startPunkt} nach {endPunkt} mit dem Auto geplant.";
        }
    }
}
