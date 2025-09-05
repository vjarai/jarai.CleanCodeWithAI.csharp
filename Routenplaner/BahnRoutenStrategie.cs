namespace Routenplaner;

public class BahnRoutenStrategie : IRoutenStrategie
{
    public string PlaneRoute(string startPunkt, string endPunkt)
    {
        return $"Route von {startPunkt} nach {endPunkt} mit der Bahn geplant.";
    }
}