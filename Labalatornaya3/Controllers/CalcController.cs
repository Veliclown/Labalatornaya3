using Microsoft.AspNetCore.Mvc;
using Labalatornaya3.Service;

namespace Labalatornaya3.Controllers
{
    public class CalcController : Controller
    {
        private CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Add(int a, int b)
        {
            var result = _calcService.Add(a, b);
            return Ok(result);
        }

        public IActionResult Subtract(int a, int b)
        {
            var result = _calcService.Subtract(a, b);
            return Ok(result);
        }

        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return Ok(result);
        }

        public IActionResult Divide(int a, int b)
        {
            try
            {
                var result = _calcService.Divide(a, b);
                return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
