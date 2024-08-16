namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car toyotaRav4 = new Car();

            toyotaRav4.Make = "Toyota";
            toyotaRav4.Model = "Rav 4";
            toyotaRav4.Year = 2024;

            Console.WriteLine($"You own a {toyotaRav4.Year} {toyotaRav4.Make} {toyotaRav4.Model}");

        }
    }
}
