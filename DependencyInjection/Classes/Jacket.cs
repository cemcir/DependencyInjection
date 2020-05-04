using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Jacket : IWear
    {
        public string Wear()
        {
            return "Resmi veya özel günlerde çeket giy";
        }
    }
}