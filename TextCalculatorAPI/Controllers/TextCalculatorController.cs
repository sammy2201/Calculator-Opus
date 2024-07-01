using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("[controller]")]
public class TextCalculatorController : ControllerBase
{
     private readonly TextCalculator _calculator = new TextCalculator();

     [HttpGet]
     public ActionResult<string> Get([FromQuery] string numbers)
     {
          try
          {
               return _calculator.Add(numbers);
          }
          catch (InvalidOperationException ex)
          {
               return BadRequest(ex.Message);
          }
     }
}
