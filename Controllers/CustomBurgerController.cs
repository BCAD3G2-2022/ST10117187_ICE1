using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CustomBurgerController : ControllerBase
    {
            [HttpGet]
            public List<string> Get(bool Tomato, bool Cheese, bool Lettuce, bool Bun, bool Patty)
            {
                IComponent burgerTomato = new Tomato();
                IComponent burgerCheese = new Cheese();
                IComponent burgerLettuce = new Lettuce();
                IComponent burgerBun = new Bun();
                IComponent burgerPatty = new Patty();

                Composite BaseBurger = new Composite();
                BaseBurger.addBurgerParts(burgerBun);
                BaseBurger.addBurgerParts(burgerCheese);
                BaseBurger.addBurgerParts(burgerLettuce);
                BaseBurger.addBurgerParts(burgerPatty);
                BaseBurger.addBurgerParts(burgerTomato);

                    if (!Tomato)
                    {
                        BaseBurger.removeBurgerParts(burgerTomato);
                    }

                    if (!Lettuce)
                    {
                        BaseBurger.removeBurgerParts(burgerLettuce);
                    }

                    if (!Cheese)
                    {
                        BaseBurger.removeBurgerParts(burgerCheese);
                    }

                List<string> returnList = new List<string>();
                returnList.Add(BaseBurger.getBurgerPart());


                return returnList;
            }
    }
}