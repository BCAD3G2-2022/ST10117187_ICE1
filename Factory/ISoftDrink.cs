using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SoftDrinkAPI
{
    public interface ISoftDrink
    {
        string getFlavour();

        string getDiet();
    }
}