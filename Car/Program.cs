namespace Car
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>();
            foreach (var car in cars)
            {
                car.Start();
            }
            foreach (var car in cars)
            for (int i = 0; i < 4; i++)
            {
         
                    car.ChangeGear();
                }
                foreach (var car in cars)
                {
                    car.Stop();
                }
            }
        }
                     public interface ICar
        {
            void Start();
            void Stop();
            void ChangeGear();
            decimal CurrentSpeed { get; }
            public class Melkus : ICar
            {
                private decimal _currentSpeed = 0m;
                public decimal CurrentSpeed => _currentSpeed;
                public void ChangeGear()
                {
                    _currentSpeed += 20;

                }
                public void Start()
                {
                    Console.WriteLine("Wroom");
                }
                public void Stop()
                {
                    Console.WriteLine("Bzz");
                    _currentSpeed = 0;
                }

                public class Maserati : ICar
                {
                    private decimal _currentSpeed = 0m;
                    public decimal CurrentSpeed => _currentSpeed;
                    public void ChangeGear()
                    {
                        _currentSpeed += 90;

                    }
                    public void Start()
                    {
                        Console.WriteLine("Wroom");
                    }
                    public void Stop()
                    {
                        Console.WriteLine("Bzz");
                        _currentSpeed = 0;
                        {

                        }



                    }
                }
            }

        }
    }





