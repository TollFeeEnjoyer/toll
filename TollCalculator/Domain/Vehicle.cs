using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollCalculator.Domain
{
    public class Vehicle
    {
        public string Type { get; set; }
    }

    public enum VehicleTypes
    {
        Car,
        Motorbike,
        Tractor,
        Emergency,
        Diplomat,
        Foreign,
        Military
    }
}