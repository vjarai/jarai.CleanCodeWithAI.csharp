namespace Routenplaner;

public class FahrradRoutenStrategie : IRoutenStrategie
{
    public string PlaneRoute(string startPunkt, string endPunkt)
    {
        return $"Route von {startPunkt} nach {endPunkt} mit dem Fahrrad geplant.";
    }
}