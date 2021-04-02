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
                case "addition":
                    result = calculationNumber.Num1 + calculationNumber.Num2;
                    break;
                case "subtraction":
                    result = calculationNumber.Num1 - calculationNumber.Num2;
                    break;
                case "multiplication":
                    result = calculationNumber.Num1 * calculationNumber.Num2;
                    break;
                case "division":
                    result = calculationNumber.Num1 / calculationNumber.Num2;
                    break;
                default:
                    return Json("Operation not found!");
            }
            return Json(result);
        }

    }
}
