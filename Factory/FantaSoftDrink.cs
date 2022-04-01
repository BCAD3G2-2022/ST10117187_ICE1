using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SoftDrinkAPI
{
    public class FantaSoftDrink : ISoftDrink
    {
        public string getFlavour()
        {
            return "Fanta";
        }
        public string getDiet()
        {
            return "No";
        }
    }
}