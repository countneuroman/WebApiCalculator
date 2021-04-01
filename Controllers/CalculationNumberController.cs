using Microsoft.AspNetCore.Mvc;
using WebApiCalculator.Models;

namespace WebApiCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationNumberController : Controller
    {

        [HttpPost]
        public IActionResult  PostCalculationNumber(CalculationNumber calculationNumber)
        {
            int result;
            switch (calculationNumber.Operation)
            {
                case "+":
                    result = calculationNumber.Num1 + calculationNumber.Num2;
                    break;
                case "-":
                    result = calculationNumber.Num1 - calculationNumber.Num2;
                    break;
                case "*":
                    result = calculationNumber.Num1 * calculationNumber.Num2;
                    break;
                case "/":
                    result = calculationNumber.Num1 / calculationNumber.Num2;
                    break;
                default:
                    return NotFound();
            }
            return Json(result);
        }

    }
}
