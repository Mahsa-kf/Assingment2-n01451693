using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Assingment2.Controllers
{

    public class J2Controller : ApiController
    {
        /// <summary>
        /// receive two inputs which each one represents the number of sides in a die and return a message of possible ways to get the sum 10.
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <example>GET ../api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10"</example>
        /// <example>GET ../api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10.</example>
        /// <example>GET ../api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10 </example>
        /// <example>GET ../api/J2/Dicegame/5/5  -> There is 1 way to get the sum 10.</example>
        /// <returns> number of possible ways to get the sum 10
        /// </returns>

        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            string message;
            // declare int result as number of outcome
            int result = 0;
            // this loop go through first die
            for (int i = 1; i <= m; i++)
            {
                // this loop go through Second die
                for (int j = 1; j <= n; j++)
                {
                    //if sum is equal to ten then add one to total possible ways(result)
                    if (i + j == 10)
                    {
                        result = result + 1;
                    }
                }
            }

            if (result == 1)
            {
                message = $"There is {result} way to get the sum 10";
            }
            else
            {
                message = $"There are {result} total ways to get the sum 10";
            }

            return message;
        }


    }
}
