using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// author: Jalaluddin Qureshi, HTTP5101 (Spring 2020, Humber College).
// Assignment 1 - Bonus Question.

namespace solution1.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id}
        /// <summary>
        /// Gets the number of days for which the website was hosted, and based
        /// on that calculate the cost of hosting, tax and total cost.
        /// </summary>
        /// <param name="id">number of days website is hosted</param>
        /// <returns>cost, tax, total cost</returns>
        public IEnumerable<string> Get(int id)
        {
            const double FNcost = 5.5; //The cost of hosting on a fortnight basis

            // I am declaring FN and tax % as a const var so that later in the future
            // if anyone would like to change it (e.g. weekly instead of fortnight/ 
            // change in tax rate), it can be done from this var.
            const double time_interval = 14;

            const double HST = 0.13;

            // The input is taken in the form of integer, as days is an integer variable
            // and then it is static cast into double, since the input of Math.Floor method
            // is supposed to be a real number.
            double No_time_interval = Math.Floor((double)id / time_interval) + 1;

            double cost = No_time_interval * FNcost;

            double tax = HST * cost;

            double total_cost = cost + tax;

            //For specifying the number of decimal places for the output, guidance from the following was taken.
            //https://stackoverflow.com/questions/164926/how-do-i-round-a-decimal-value-to-2-decimal-places-for-output-on-a-page
            // My solution performs the rounding operation instead of truncating until the 2 decimal places.
            return new string[] {
                No_time_interval-1 + " fortnights at $5.50/FN = $" + cost.ToString("0.#0") + " CAD",
                "HST 13% = $" + tax.ToString("0.##") + " CAD",
                "Total = $" + total_cost.ToString("0.##") + " CAD"
            };
        }
    }
}
