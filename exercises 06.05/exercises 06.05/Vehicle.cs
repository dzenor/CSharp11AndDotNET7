using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_06._05
{
    public abstract class Vehicle
    {

        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption) { 
        
           this.fuelQuantity = fuelQuantity;
            this.fuelConsumption= fuelConsumption;
        
        }


        public double FuleConsumption
        {
        get { return this.fuelConsumption; }
            set { this.fuelConsumption = value;}
        }


        public abstract void Drive(double distance);
        public abstract double Refuel(double liters);

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
