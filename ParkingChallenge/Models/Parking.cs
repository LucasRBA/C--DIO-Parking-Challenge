namespace ParkingChallenge.Models
{
    public class Parking
    {
        private decimal initialFare = 0;
        private decimal pricePerHour = 0;

        public int vehicleType;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialFare, decimal pricePerHour)
        {
            this.initialFare = initialFare;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter your vehicle's license plate:");
            string vechiclePlate = Console.ReadLine();
            vehicles.Add(vechiclePlate);
         
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter your vehicle's license plate to remove it:");
            string vehiclePlate = Console.ReadLine();

            Console.WriteLine("Please enter your vehicle type: \n 1 - Car \n 2 - Motorcycle ");


            try{
                vehicleType = Convert.ToInt16(Console.ReadLine());
                if(vehicleType==1) {
                    Car c1 = new Car();
                    this.initialFare = c1.setInitialFare();
                    this.pricePerHour = c1.setPricePerHour();
                } else {
                    Motorcycle m1 = new Motorcycle();
                    this.initialFare = m1.setInitialFare();
                    this.pricePerHour = m1.setPricePerHour();
                }
            }catch {
                Console.WriteLine("Invalid iput, please try again...");
            }

            if (vehicles.Any(x => x.ToUpper() == vehiclePlate.ToUpper()))
            {
                Console.WriteLine("How many hours has your car spent here? ");


                int hours = Convert.ToInt32(Console.ReadLine());
                decimal billTotal = (hours*pricePerHour) + initialFare;
                vehicles.Remove(vehiclePlate);

                Console.WriteLine($"The vehicle {vehiclePlate.ToUpper()} was removed and your bill is {billTotal:C} ");
            }
            else
            {
                Console.WriteLine("Sorry, the vehicle you tried to search wasn't found, please try again...");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("The parked vehicles are: ");
                foreach(string vehicle in vehicles) {
                    Console.WriteLine(vehicle.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles right now");
            }
        }
    }
}
