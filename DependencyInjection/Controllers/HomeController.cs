using DependencyInjection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            People people = new People(new Jacket());
            People people1 = new People(new Cardigan());
            People people2 = new People(new Monte());

            StringBuilder sb = new StringBuilder();
            sb.Append("Ceket sınıfı çağrılınca\t\t" + people.Write());
            sb.Append("<br>");
            sb.Append("Hırka sınıfı çağrılınca\t\t" + people1.Write());
            sb.Append("<br>");
            sb.Append("Mont sınıfı çağrılınca\t\t" + people2.Write());

            var result = sb.ToString();

            return result; 
        }
    }
}