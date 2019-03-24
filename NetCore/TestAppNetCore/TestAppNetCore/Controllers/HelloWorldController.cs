using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAppNetCore.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes=1)
        {
            // return "This is the Welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        // 
        // GET: /HelloWorld/Welcome2/ 

        public string Welcome2(string name, int ID = 1)
        {
            // return "This is the Welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        }
    }
}
