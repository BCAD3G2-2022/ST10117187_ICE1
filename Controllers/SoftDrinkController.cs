using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SoftDrinkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoftDrinkController : ControllerBase
    {

        [HttpGet]
        public List<SoftDrink> Get(string softDrinkType="Flavour")
        {
           SoftDrinkFactory softDrinkFactory = new SoftDrinkFactory();
           ISoftDrink softDrink = softDrinkFactory.getSoftDrink(softDrinkType);
           List<SoftDrink> returnedSoftDrink = new List<SoftDrink>();
           returnedSoftDrink.Add(new SoftDrink{flavour=softDrink.getFlavour(),diet=softDrink.getDiet()});

           return returnedSoftDrink;
        }
    }
}
