using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// author: Jalaluddin Qureshi, HTTP5101 (Spring 2020, Humber College).
// Assignment 1 - Question 3.

namespace solution1.Controllers
{
    public class GreetingController : ApiController
    {
        // Post -- From the Command Window.
        // >curl -d "" "http://localhost:XXXX/api/Greeting"
        /// <summary>
        /// Returns the string Greeting of "Hello World" using Post method
        /// </summary>
        /// <returns>"Hello World"</returns>
        public string Post()
        {
            string msg = "Hello World";
            return msg;
        }

        // GET api/Greeting/{id}
        /// <summary>
        /// Gets the user input integer value, and then outputs the Greeting message.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "Greeting to " + id + " people!";
        }


    }
}
