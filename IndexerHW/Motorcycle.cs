using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHW
{
    public class Motorcycle: Vehicle
    {
        public int NumOfWheels { get; set; } //מספר גלגלים באופנוע
        public override Color Color { get; set ; }
        public override string? Brand { get ; set ; }
        public override bool IsNeedTreatment { get ; set ; }
        public override TypeVec Type { get ; set; }

        public Motorcycle(int numOfWheels, Color color, string? brand, bool isNeedTreatment)
        {
            NumOfWheels = numOfWheels;
            Color = color;
            Brand = brand;
            IsNeedTreatment = isNeedTreatment;
            Type = TypeVec.car;
        }
    }
}
