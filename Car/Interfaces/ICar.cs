using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Interfaces
{
    public interface ICar
    {
        string Name { get; }
        int CurrentSpeed { get; }
        IEngine Engine { get; }
        IGearBox GearBox { get; }
        void StartEngine();
        void StopEngine();
    }
}
