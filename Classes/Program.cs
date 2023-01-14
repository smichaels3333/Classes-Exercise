namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Silverado",
                Year = 2015


            };

            var toyota = new Car("Toyota", "Tundra", 2016);

            var carList = new List<Car>() { myCar, chevy, toyota};
            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
