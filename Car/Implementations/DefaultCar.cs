namespace Car.Implementations
{
    public class DefaultCar : ICar
    {
        public DefaultCar(
            IEngine engine,
            IGearBox gearBox,
            string Name)
        {
            Engine = engine;
            GearBox = gearBox;
            this.Name = Name;
        }

        public string Name { get; }

        public int CurrentSpeed { get; private set; }

        public IEngine Engine { get; }

        public IGearBox GearBox { get; }

        public void StartEngine()
        {
            Console.WriteLine("Wrooooom");
            for (int i = 1; i <= GearBox.GearCount; i++)
            {
                CurrentSpeed += Engine.SpeedPerGear;
                Console.WriteLine($"Wzzzzzzzz. Current Speed is {CurrentSpeed}");
            }
        }

        public void StopEngine()
        {
            Console.WriteLine("Bzzzzzzzrrrr");
        }
    }
}
