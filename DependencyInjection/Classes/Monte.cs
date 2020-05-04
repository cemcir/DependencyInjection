using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Monte : IWear
    {
        public string Wear()
        {
            return "Yağmurlu ve soğuk günlerde mont giyin";
        }
    }
}