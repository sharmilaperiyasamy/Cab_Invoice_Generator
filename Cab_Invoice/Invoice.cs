using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
    internal class Invoice
    {
        int cost_per_km = 10;
        int cost_per_min = 1;
        int min_fare = 5;
        double total_fare;

        //uc1 calculate total fare
        public double cal_Fare(double distance, double time)
        {
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
