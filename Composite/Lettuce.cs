using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
    public class Lettuce : IComponent
    {
        public string getBurgerPart()
        {
            return "Lettuce";
        }
    }
}