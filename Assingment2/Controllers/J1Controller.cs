using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assingment2.Controllers
{
    public class J1Controller : ApiController
    {


        /// <summary>
        /// finding the total calories of the meal
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <example>GET ../api/J1/Menu/4/4/4/4  -> Your total calorie count is 0</example>
        /// <example>GET ../api/J1/Menu/1/2/3/4  -> Your total calorie count is 691</example>
        /// <returns>compute the total calories of the meal
        /// </returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            int[] burgers = new int[] { 461, 431, 420, 0 };
            int[] drinks = new int[] { 130, 160, 118, 0 };
            int[] sides = new int[] { 100, 57, 70, 0 };
            int[] desserts = new int[] { 167, 266, 75, 0 };
            //get the calories of the burger, drink, side and dessert and aggregate together
            var totalMenue = burgers[burger - 1] + drinks[drink - 1] + sides[side - 1] + desserts[dessert - 1];
            return "Your total calori count is " + totalMenue;
        }

    }
}

