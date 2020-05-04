using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Cardigan : IWear
    {
        public string Wear()
        {
            return "Rüzgarlı günlerde hırka giyin";
        }
    }
}