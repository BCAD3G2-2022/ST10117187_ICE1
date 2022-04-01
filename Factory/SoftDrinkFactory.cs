using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SoftDrinkAPI
{
public class SoftDrinkFactory
{
    //instance of ISoftDrink Interface 
    public ISoftDrink returnInstance;
    
   public ISoftDrink getSoftDrink(String softDrinkType)
    {
       switch(softDrinkType)
       {
           case("Coke"):
           returnInstance = new CokeSoftDrink();
           break;
           case("Fanta"):
           returnInstance = new FantaSoftDrink();
           break;
           case("Diet"):
           returnInstance = new DietSoftDrink();
           break;
       }

        return returnInstance;
       
       }
    

 }

}