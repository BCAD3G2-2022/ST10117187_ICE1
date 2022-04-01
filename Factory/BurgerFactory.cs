using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI
{
public class BurgerFactory
{
    //instance of IBurger Interface 
    public IBurger returnInstance;
    
   public IBurger getBurger(String burgerType)
    {
       switch(burgerType)
       {
           case("Chicken"):
           returnInstance = new ChickenBurger();
           break;
           case("Plain"):
           returnInstance = new PlainBurger();
           break;
           case("Cheese"):
           returnInstance = new CheeseBurger();
           break;
           case("Veggie"):
           returnInstance = new VeggieBurger();
           break;


       }

        return returnInstance;


    }
    

 }

}