using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingChallenge.Models
{
    public class Car : Vehicle
    {
        protected decimal initialFare {get;set;}
        protected decimal pricePerHour {get; set;}

        public decimal setInitialFare() {
            this.initialFare=6;
            return initialFare;
        }
        public decimal setPricePerHour() {
            this.pricePerHour=4;
            return pricePerHour;
          
        }
    }
}