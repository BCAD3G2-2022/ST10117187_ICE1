using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
    public class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "Rye";
        }

        public string getPatty()
        {
            return "Chicken";
        }
    }
}