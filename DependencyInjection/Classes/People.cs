using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class People
    {
        IWear _wear;

        public People(IWear wear)
        {
            _wear = wear;
        }

        public string Write()
        {
            return _wear.Wear();
        }

    }
}