using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
    public class Invoice
    {
        double total_fare;

        //uc1 calculate total fare
        public double cal_Fare_forNormalRides(double distance, double time)
        {
            int cost_per_km = 10;
            int cost_per_min = 1;
            int min_fare = 5;
            try
            {
                total_fare = (cost_per_km * distance) + (cost_per_min * time);
            }
            catch (exception)
            {
                if (distance <= 0)
                    throw new exception(exception.ExceptionType.INVALID_DISTAANCE, "Invalid Distance");
                if (time < 0)
                    throw new exception(exception.ExceptionType.INVALID_TIME, "Invalid time");
            }
            return Math.Max(total_fare, min_fare);
        }

        public double cal_Fare_forPremiumRides(double distance, double time)
        {
            int cost_per_km = 15;
            int cost_per_min = 2;
            int min_fare = 20;
            try
            {
                total_fare = (cost_per_km * distance) + (cost_per_min * time);
            }
            catch (exception)
            {
                if (distance <= 0)
                    throw new exception(exception.ExceptionType.INVALID_DISTAANCE, "Invalid Distance");
                if (time < 0)
                    throw new exception(exception.ExceptionType.INVALID_TIME, "Invalid time");
            }
            return Math.Max(total_fare, min_fare);
        }
    }
}
