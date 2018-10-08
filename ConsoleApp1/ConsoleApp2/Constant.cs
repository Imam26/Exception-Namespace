using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Constant
    {
        private const double pi = 3.141592;
        private const int countOfMonth = 12;
        private const string planetName = "Mars";
        private const string starName = "Big Dipper";

        public double Pi { get => pi;}
        public int CountOfMonth { get => countOfMonth; }
        public string PlanetName { get => planetName; }
        public string StarName { get => starName; }
    }
}
