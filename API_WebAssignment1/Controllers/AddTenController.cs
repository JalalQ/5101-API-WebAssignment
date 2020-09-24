using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// author: Jalaluddin Qureshi, HTTP5101 (Spring 2020, Humber College).
// Assignment 1 - Question 1.

namespace solution1.Controllers
{
    public class AddTenController : ApiController
    {

        // GET api/addten/{id}
        /// <summary>
        /// The user provide an input inter value.
        /// </summary>
        /// <param name="id">user-provided input integer</param>
        /// <returns>
        /// The return value is given as addition of 10 to the input value.
        /// </returns>
        public int Get(int id)
        {
            int addition = id + 10;
            return addition;
        }
    }
}
