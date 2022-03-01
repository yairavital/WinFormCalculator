using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHW
{
    public abstract class Vehicle
    {
        public abstract Color Color { get; set; }//צבע רכב
        public abstract string? Brand { get; set; }//סוג רכב- מותג
        public abstract bool IsNeedTreatment { get; set; }//האם צריך טיפול
        public abstract TypeVec Type { get; set; }// סוג רכב - אופנוע או רכב


    }

    public enum Color
    {
        red,
        green,
        blue,
        magenta,    
        cyan,
        black,
        yellow,
        white

    }
    public enum TypeVec
    {
        car,
        motorcycle
    }
}
