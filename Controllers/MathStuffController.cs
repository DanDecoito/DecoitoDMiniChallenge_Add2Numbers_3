// Daniel Decoito
// 10-25-22
// Mini Challenge 3
// use api to return the sum of two numbers 
// reviewed by Elizar Garcia, Code runs great. shows on postman with no problem. i put in two seperate numbers and got the correct total. code is clean and easy to read. Great job!!



using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_Add2Numbers_3.Controllers;

[ApiController]
[Route("[controller]")]
public class MathStuffController : ControllerBase
{
   
 [HttpGet]
 [Route("Adding/{num1}/{num2}")]

 public int Adding(string num1, string num2)
 {
    int number1 = int.Parse(num1);
    int number2 = int.Parse(num2);

    return number1 + number2;
 }


}
