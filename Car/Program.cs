namespace Car
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ICar> cars = new()
            {
                new DefaultCar(new StandartEngine(), new ProfessionalGearBox(), "Мазератти"),
                new DefaultCar(new BoostedEngine(), new ProfessionalGearBox(), "Лексус")
            };

            foreach (var car in cars)
            {
                car.StartEngine();
            }

            foreach (var car in cars)
            {
                car.StopEngine();
            }
        }
    }
}