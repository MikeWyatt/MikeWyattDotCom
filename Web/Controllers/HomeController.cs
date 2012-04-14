using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.Home.AboutMe;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult AboutMe()
        {
            return View(new AboutMeModel
            {
                Skills = new SkillsModel
                {
                    FluentLanguages = new List<Skill>
                    {                        
                        new Skill { Url = "http://msdn.microsoft.com/en-us/vstudio/hh388566", Text = "C#" },
                        new Skill { Url = "http://www.python.org", Text = "Python" },
                        new Skill { Url = "", Text = "JavaScript" },
                        new Skill { Url = "", Text = "jQuery" },
                        new Skill { Url = "", Text = "SQL" }

                           /* Languages: Fluent in <a href="">C#</a>, <a href="http://www.python.org/">Python</a>, JavaScript/jQuery, and SQL.  Limited Java, C/C++, Ruby.
    Design and Practices:  Complete SDLC, Relational Data Modeling, major design patterns, GRASP, SOLID, DRY, intersystem communication via WCF or REST, unit testing
    Tools and Frameworks: Visual Studio, SQL Server Management Studio, PyCharm, Eclipse, .NET Framework, ASP.NET MVC, OpenGL
    Other Technologies:  Entity Framework, iBatis, HTML, CSS, AJAX, log4net, NUnit*/
                    },
                    MinorLanguages = new List<Skill>
                    {
                        new Skill { Url = "", Text = "Java" },
                        new Skill { Url = "", Text = "C/C++" },
                        new Skill { Url = "", Text = "Ruby" },
                    }
                }
            });
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
