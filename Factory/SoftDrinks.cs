using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SoftDrinkAPI
{
    public class SoftDrink
    {
        public string flavour {get;set;}

        public string diet{get;set;}

        public string size{get;set;}
    }
}