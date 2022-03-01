using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHW
{
    public class Car: Vehicle
    {
        public int NumOfDoors { get; set; } //מספר דלתות ברכב
        public override TypeVec Type { get ; set; }
        public override Color Color { get; set ; }
        public override string? Brand { get ; set ; }
        public override bool IsNeedTreatment { get; set; }

        public Car(int numOfDoors, Color color, string? brand, bool isNeedTreatment)
        {
            NumOfDoors = numOfDoors;
            Type = TypeVec.car;
            Color = color;
            Brand = brand;
            IsNeedTreatment = isNeedTreatment;
        }
    }
}
