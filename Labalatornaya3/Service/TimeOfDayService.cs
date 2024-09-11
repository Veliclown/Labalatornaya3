namespace Labalatornaya3.Service
{
    public class TimeOfDayService
    {
        public string GetCurrentTimeOfDayMessage()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour >= 6 && currentHour < 12)
            {
                return "Зараз ранок";
            }
            if (currentHour >= 12 && currentHour < 18)
            {
                return "Зараз день";
            }
            if (currentHour >= 18 && currentHour < 24)
            {
                return "Зараз вечір";
            }
            return "Зараз ніч";
        }
    }
}
