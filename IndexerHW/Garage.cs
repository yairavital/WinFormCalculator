using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHW
{
    public class Garage : GarageBase
    {
        private Vehicle[] vehicles = new Vehicle[5];
        public static int counter = 0;

        public void AddCar(Vehicle vehicle)
        {
            counter++;
            for (int i = 0; i < counter; i++)
            {
                if (vehicles[i] == null)
                    vehicles[i] = vehicle;


            }
        }

        public Vehicle this[int index]
        {
            get
            {

                return vehicles[index];
            }
            set
            { if(index == 0)
                vehicles[index].IsNeedTreatment = false;

            }

        }
      

    }
}
