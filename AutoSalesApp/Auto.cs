using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalesApp
{
    class Auto
    {
        private double cost;

        public string Description { get; set; }

        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value >= 0)
                {
                    cost = value;
                }
            }
        }
        public double ListPrice
        {
            get
            {
                return Cost * 1.1;
            }
        }
        public double Profit
        {
            get
            {
                return ListPrice - Cost;
            }
        }
        public Auto(string description, double cost)
        {
            Description = description;
            Cost = cost;
        }
    }
}
