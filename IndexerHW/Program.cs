// See https://aka.ms/new-console-template for more information
using IndexerHW;

Vehicle car1 = new Car(4,Color.cyan,"Kia",true);
Vehicle car2 = new Car(2, Color.black, "Mazda", false);
Vehicle morocyccle1 = new Motorcycle(2,Color.red,"motor", true);
Vehicle morocyccle2 = new Motorcycle(3, Color.magenta, "fiat", false);
Vehicle morocyccle3 = new Motorcycle(2, Color.blue, "Polo", true);
Garage garage1 = new Garage();
garage1.AddCar(car1);
garage1.AddCar(car2);
garage1.AddCar(morocyccle1);
garage1.AddCar(morocyccle2);
garage1.AddCar(morocyccle3);
Vehicle vecByIndex = garage1[0];
Console.WriteLine(vecByIndex.Brand);
garage1[0] = car1;
Console.WriteLine(garage1[0].IsNeedTreatment);






