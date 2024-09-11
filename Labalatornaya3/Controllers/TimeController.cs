using Labalatornaya3.Service;
using Microsoft.AspNetCore.Mvc;


namespace Labalatornaya3.Controllers
{
    public class TimeController : Controller
    {
        private TimeOfDayService _timeOfDayService;

       
        public TimeController(TimeOfDayService timeOfDayService)
        {
            _timeOfDayService = timeOfDayService;
        }

        
        public IActionResult Index()
        {
            var message = _timeOfDayService.GetCurrentTimeOfDayMessage();
            return Content(message);
        }
    }
}
