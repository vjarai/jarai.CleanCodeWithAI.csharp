namespace Routenplaner
{


    /// <summary>
    /// Plant routen zwischen zwei punkten  
    /// </summary>
    public class RoutenplanungsService
    {
        private readonly IRoutenStrategie _routenStrategie;

        public RoutenplanungsService(IRoutenStrategie routenStrategie)
        {
            _routenStrategie = routenStrategie;
        }

        /// <summary>
        /// Plant eine route zwischen zwei punkten
        /// </summary>
        /// <param name="startPunkt">Startpunkt der Route</param>
        /// <param name="endPunkt">Endpunkt der Route</param>
        /// <returns>Die geplante Route</returns>
        public string PlaneRoute(string startPunkt, string endPunkt)
        {
            return _routenStrategie.PlaneRoute(startPunkt, endPunkt);
        }
    }
}
