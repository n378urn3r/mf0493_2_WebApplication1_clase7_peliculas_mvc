using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_clase7_peliculas_mvc.Controllers
{
    //using System.Web;
    //using System.Web.Mvc;

    namespace MvcMovie.Controllers
    {
        public class HelloWorldController : Controller
        {
            // 
            // GET: /HelloWorld/Welcome

            public string Index()
            {
                return "This is my <b>default</b> action...";
            }

            // 
            // GET: /HelloWorld/Welcome/ 

            public string Welcome(string nombre, int veces=1)
            {
                return HttpUtility.HtmlEncode("Hello " + nombre + ", NumTimes is: " + veces);
            }
        }
    }
}