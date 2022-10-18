using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingChallenge.Models
{
    public class Motorcycle : Vehicle
    {
        private decimal initialFare {get;set;}
        private decimal pricePerHour {get; set;}

        public decimal setInitialFare() {
            this.initialFare=4;
            return initialFare;
        }
        public decimal setPricePerHour() {
            this.pricePerHour=4;
            return pricePerHour;
          
        }
    }
}