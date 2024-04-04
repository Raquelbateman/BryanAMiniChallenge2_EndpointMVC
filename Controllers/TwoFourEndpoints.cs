using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BryanAMiniChallenge2_EndpointMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TwoFourEndpoints : ControllerBase
    {

        [HttpGet("/sumEndpoint")]
        public string sumEndpoint(double a, double b){
            
            double sum = a + b;

            string result = "The sum of " +  a  + " and " +  b + " is " + sum + "."; 
            return result;
        }



    [HttpGet("/nameWakeUp")]

    public string nameWakeUp(string name, string wakeUp){
        
        string result = "Hello " + name + "!" + " You woke up at " + wakeUp + " today!" + " Time is money hunnay!";
        return result; 
    }

    [HttpGet("/greaterOrLesser")]

    public string greaterOrLesser(double a, double b){

       string firstNum = "";
       string secondNum = "";

       if (a > b){
                firstNum = a + " is greater than " + b + "!";
                secondNum = b + " is less than " + a + "!";
            }
             else if (b > a){
                firstNum = b + " is greater than " + a + "!";
                secondNum = a + " is less than " + b + "!";   
            }

            else {
                firstNum = b + " is equal to " + a + "!";
                secondNum = a + " is equal to " + b + "!";
            }
    
            string statement = firstNum  + "\n" + secondNum;
            return statement;


    }
}
}
