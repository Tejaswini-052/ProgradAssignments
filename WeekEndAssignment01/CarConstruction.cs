namespace WeekEndAssignment01
{
    internal class CarConstruction
    {

        public class Car
        {
            int fuellevel;
            int MaxtankSize;
            bool enginerunning ;
            int speed;
            int acceleration;
            int braking;
            int distancedriven;
            int drivingtime;
            int totaldistance;
            int totaldrivingtime;

            public Car(int fuellevel,int MaxtankSize)
            {
                this.fuellevel = fuellevel;
                this.MaxtankSize = MaxtankSize;
                this.enginerunning = false;
                this.speed = 0;
                this.acceleration = 10;
                this.braking = 10;
                this.distancedriven = 0;
                this.drivingtime = 0;
                this.totaldistance = 0;
                this.totaldrivingtime = 0;


            }
            public void StartEngine(bool enginerunning) {
                Console.WriteLine("Car engine started.");
                enginerunning = true;
            }

            public void StopEngine(bool enginerunning) {
                Console.WriteLine("Car engine stopped.");
                enginerunning = false;
           }
            public void Refuel(int value) {
                if (fuellevel +value  > MaxtankSize)
                    fuellevel = MaxtankSize;
                else {
                      fuellevel += value;
                     }
             }

            public double Getfuelconsumption() {
                if (speed >= 1 && speed <= 60) {
                    return 0.0020;
                }
                else if (speed >= 61 && speed <= 100) {
                    return 0.0014;
                }
                else if (speed >= 101 && speed <= 140) {
                    return 0.0020;
                }
                else if (speed >= 141 && speed <= 200) {
                    return 0.0025;
                }
                else if (speed >= 201 && speed <= 250) {
                    return 0.0030;
                }
                else {
                    return 0;
                     }

             }

             public void UpdateSpeed(int seconds, int pedalposition) {
                if (pedalposition > 0 && speed < 250) {
                    speed += acceleration * pedalposition * seconds;
                    if (speed > 250) {
                        speed = 250;
                    }
                }

    }
            


        }
        static void Main(string[] args)
        {
            Car honda = new Car(5, 60);
            honda.StartEngine(true);
            honda.UpdateSpeed(30,1);
            Console.WriteLine(honda.Getfuelconsumption());
            honda.Refuel(20);



        }
    }
}