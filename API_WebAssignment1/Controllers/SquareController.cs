using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// author: Jalaluddin Qureshi, HTTP5101 (Spring 2020, Humber College).
// Assignment 1 - Question 2.

namespace solution1.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/square/{id}
        /// <summary>
        /// User provides an input interger value
        /// </summary>
        /// <param name="id">user provided input integer</param>
        /// <returns>The square of the input integer value</returns>
        public int Get(int id)
        {
            int square = id;
            square *= id;
            return square;
        }
    }
}
