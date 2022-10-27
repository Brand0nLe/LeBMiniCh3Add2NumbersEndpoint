//Brandon Le
//10-25-22
//Mini Challenge 3 - Add 2 numbers
//Web API project that will take the users two inputs in the url and add the two numbers together.
//The sum will show up for the user when running MiniCh3/Adding/number1/number2.
//For example if it's MiniCh3/Adding/3/5 the outcome would be 8.
//Peer Review: Ulises Ortega - The endpoint works as intended it takes the two numbers and output the addition of the 2 numbers.


using Microsoft.AspNetCore.Mvc;

namespace MiniCh3Add2NumbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh3Controller : ControllerBase
{
    [HttpGet]
    [Route("Adding/{number1}/{number2}")]
    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        return convertNum1 + convertNum2;
    }
}
