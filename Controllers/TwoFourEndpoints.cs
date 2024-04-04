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
    }
}

      

// Endpoint that accepts 2 inputs and returns their sum

// app.MapGet("/gimmeSum", (double a, double b) =>{

//     double sum = a + b;

//     string result = "The Sum of " + a + " and " + b + " is " + sum + "!";
//     return result;

// });

// // Endpoint that accepts 2 numbers and tells you if the chosen numbers are either greater or lesser than one another

//         }
// app.MapGet("/greaterOrLesser", (double a, double b) =>{
    
//    // two string variables declared to store the comparisons
//     string firstNum = "";
//     string secondNum = "";

    
//     // If and else-if statement used to compare firstNum to secondNum

//     if (a > b){
//         firstNum = a + " is greater than " + b + "!";
//         secondNum = b + " is less than " + a + "!";
//     }

//     else if (b > a){
//         firstNum = b + " is greater than " + a + "!";
//         secondNum = a + " is less than " + b + "!";   
//     }

//     else {
//         firstNum = b + " is equal to " + a + "!";
//         secondNum = a + " is equal to " + b + "!";
//     }
    
//     // Newline character ("\n") - a special character used in strings and code to represent a new line
//     string statement = firstNum + "\n" + secondNum;
//     return statement;
// });



